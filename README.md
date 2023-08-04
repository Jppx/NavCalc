# NavCalc
Accurate implementation of Haversine range calculations in C# (.NET 6.0)
A class with functions for accurately calculating the range and bearing from one GPS position to another across the surface of the earth. 
This method is adapted from code originally written for a mobile Geocaching application (BasicGPS for Geocaching) written 15 years ago. The application had 100K downloads and was regarded as being very precise in its day.

Via the test application its been confirmed that this calculation seems to be as accurate as the one employed by Googlemaps. (ie. 10m error at a range of 70km)
