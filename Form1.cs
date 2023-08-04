
namespace TestNav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clearInputs();
        }

        private void clearInputs()
        {
            //form setup
            lblError.Text = string.Empty;
            lblError.Visible = false;
            txtCurLat.Text = string.Empty;
            txtCurLng.Text = string.Empty;
            txtDesLat.Text = string.Empty;
            txtDesLng.Text = string.Empty;
            lblBearing.Text = "Bearing: ";
            lblRange.Text = "Range: ";
        }

        private void clearOutputs()
        {
            lblBearing.Text = string.Empty;
            lblRange.Text = string.Empty;
        }

        private Boolean checkVals()
        {
            Boolean resultant = true;
            if (!refLimit(txtCurLng.Text, true) || !refLimit(txtDesLng.Text, true))
            {
                resultant = false;
            }
            if (!refLimit(txtCurLat.Text, false) || !refLimit(txtDesLat.Text, false))
            {
                resultant = false;
            }
            return resultant;

        }

        private Boolean refLimit(string inx, Boolean isLong)
        {
            Boolean resultant = true;
            if (isLong)
            {
                // is londitude
                if (Convert.ToDouble(inx) > 180 || Convert.ToDouble(inx) < -180)
                {
                    resultant = false;
                }
            }
            else
            {
                // is Latitude
                if (Convert.ToDouble(inx) > 90 || Convert.ToDouble(inx) < -90)
                {
                    resultant = false;
                }
            }
            return resultant;
        }

        /// <summary>
        /// Main Calculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkVals())
            {
                //Lets do the calculations
                targetRange target = new targetRange();
                targetBearing bearing = new targetBearing();
                NavFunctions navFunctions = new NavFunctions();
                clearOutputs();
                try
                {
                    target = navFunctions.calcHaversineRange(Convert.ToDouble(txtCurLat.Text), Convert.ToDouble(txtCurLng.Text), Convert.ToDouble(txtDesLat.Text), Convert.ToDouble(txtDesLng.Text), false);
                    lblRange.Text = "Range: " + target.range.ToString() + " " + target.units;

                    bearing = navFunctions.calcHeadingToDestination(Convert.ToDouble(txtCurLat.Text), Convert.ToDouble(txtCurLng.Text), Convert.ToDouble(txtDesLat.Text), Convert.ToDouble(txtDesLng.Text));
                    lblBearing.Text = "Bearing: " + bearing.bearing.ToString() + "º";
                    lblError.Visible = false;
                }
                catch (Exception ex)
                {
                    lblError.Text = ex.Message;
                    lblError.Visible = true;
                }
            }
            else
            {
                //display error
                lblError.Text = "Input Parameter outside limits!";
                lblError.Visible = true;
            }
            return;
        }
    }
}