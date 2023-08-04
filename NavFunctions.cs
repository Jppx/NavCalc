using static System.Net.Mime.MediaTypeNames;
using System.Net.NetworkInformation;

namespace NavCalc
{
    /// <summary>
    /// Container class for Navigation Functions
    /// </summary>
    public class NavFunctions
    {
        //Calcs the distance between two lat/long points on the earth.
        /// <summary>
        /// Haversine Range Calculation based on current/destination positions in digital degrees. units: metric=default or miles=true
        /// </summary>
        /// <param name="latCurr"></param>
        /// <param name="longCurr"></param>
        /// <param name="latDest"></param>
        /// <param name="longDest"></param>
        /// <param name="units"></param>
        /// <returns></returns>
        public targetRange calcHaversineRange(double latCurr, double longCurr, double latDest, double longDest, bool units = false)
        {

            int R = 6371; //mean earth radius in km
            targetRange thisRange = new targetRange();
            string resultUnits = string.Empty;

            double latCurrentRad = latCurr * 0.0174532925;
            double longCurrentRad = longCurr * 0.0174532925;
            double latDestination = latDest * 0.0174532925;
            double longDestination = longDest * 0.0174532925;

            double dLat = latDestination - latCurrentRad;
            double dLon = longDestination - longCurrentRad;

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Cos(latCurrentRad) * Math.Cos(latDestination) * Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double distance = R * c;

            if (units) //imperial units miles/yards
            {
                //Convert to Miles from KMs
                distance = distance * 0.621371192;
                thisRange.units = "mi";

                if (distance >= 100)
                {
                    thisRange.range = distance;
                }
                if (distance < 100 && distance >= 10)
                {
                    thisRange.range = Math.Round(distance, 2);
                }
                if (distance < 10 && distance > 1)
                {
                    thisRange.range = Math.Round(distance, 2);
                }
                if (distance <= 1)
                {
                    //switch to yards
                    double j = Math.Round(distance, 3);
                    int k = Convert.ToInt32(j * 1760); //now in yards
                    thisRange.range = k;
                    thisRange.units = "yrd";
                }
            }
            else
            {
                //this result is metric kilometers or meters
                if (distance > 1)
                {
                    thisRange.range = Math.Round(distance, 2);
                    thisRange.units = "km";

                }
                if (distance <= 1)
                {
                    double j = Math.Round(distance, 3);
                    int k = Convert.ToInt32(j * 1000); //now in meters
                    thisRange.range = k;
                    thisRange.units = "m";
                }
            }

            return (thisRange);
        }

        /// <summary>
        /// Calculates the correct bearing angle from current lat/long to desitination lat/long
        /// </summary>
        /// <param name="latCurr"></param>
        /// <param name="longCurr"></param>
        /// <param name="latDest"></param>
        /// <param name="longDest"></param>
        /// <returns></returns>
        public targetBearing calcHeadingToDestination(double latCurr, double longCurr, double latDest, double longDest)
        {

            targetBearing thisBearing = new targetBearing();
            double latCurrentRad = latCurr * 0.0174532925;
            double longCurrentRad = longCurr * 0.0174532925;
            double latDestination = latDest * 0.0174532925;
            double longDestination = longDest * 0.0174532925;

            //double dLat = latDestination - latCurrentRad;
            double L = longDestination - longCurrentRad;
            double cosD = Math.Sin(latCurrentRad) * Math.Sin(latDestination) + Math.Cos(latCurrentRad) * Math.Cos(latDestination) * Math.Cos(L);
            double D = Math.Acos(cosD);
            double cosC = (Math.Sin(latDestination) - cosD * Math.Sin(latCurrentRad)) / (Math.Sin(D) * Math.Cos(latCurrentRad));

            if (cosC > 1.0)
                cosC = 1.0;
            if (cosC < -1.0)
                cosC = -1.0;

            double C = 180.0 * Math.Acos(cosC) / Math.PI;

            if (Math.Sin(L) < 0.0)
            {
                C = 360.0 - C;
            }

            thisBearing.bearing = Convert.ToInt32(Math.Round(100 * C) / 100.0);
            return (thisBearing);
        }

        /// <summary>
        /// Converts Degrees/Minutes/Seconds to Digital Degrees
        /// </summary>
        /// <param name="degrees"></param>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public digitalDegrees ConvertDMStoDD(int degrees, int minutes, int seconds)
        {
            double dd = Math.Sign(degrees) * (Math.Abs(degrees) + (minutes / 60.0) + (seconds / 3600.0));
            digitalDegrees thisDegs = new digitalDegrees();
            thisDegs.degrees = dd;
            return (thisDegs);
        }

        /// <summary>
        /// Converts Digital Degrees to Degrees/Minutes/Seconds
        /// </summary>
        /// <param name="digDegrees"></param>
        /// <returns></returns>
        public DMSReference ConvertDDtoDMS(double digDegrees)
        {
            DMSReference thisRef = new DMSReference();
            int d = (int)digDegrees;  // Truncate the decimals
            double t1 = (digDegrees - d) * 60;
            int m = (int)t1;
            double s = (t1 - m) * 60;
            thisRef.degrees = d;
            thisRef.mins = m;
            thisRef.secs = Convert.ToInt32(s);
            return (thisRef);

        }
    }

    /// <summary>
    /// Range object for returned values
    /// </summary>
    public class targetRange
    {
        public double range = 0.00;
        public string units = string.Empty;
    }

    /// <summary>
    /// Bearing (Direction) object for returned values
    /// </summary>
    public class targetBearing
    {
        public Int32 bearing = 0;
        public string CompassDirection = string.Empty;
    }

    /// <summary>
    /// GPS ref object in degree/minutes/seconds format (either a lat or long)
    /// </summary>
    public class DMSReference
    {
        public int degrees = 0;
        public int mins = 0;
        public int secs = 0;
    }

    /// <summary>
    /// A GPS position object in deiginal degrees (either lat or long)
    /// </summary>
    public class digitalDegrees
    {
        public double degrees = 0.00;
    }
}
