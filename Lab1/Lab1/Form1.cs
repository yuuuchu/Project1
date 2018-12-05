using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    /** This program calculates the cost of power for users
     *  Author: Eugenia Chiu
     *  Date: December 2018
     */
    public partial class Form1 : Form
    {
        //global constants 
        const decimal USER_FIRST_TIME = 1000m;

        const decimal RES_FLAT_RATE = 6.00m;
        const decimal RES_RATE = 0.052m;

        const decimal COMM_FLAT_RATE = 60.00m;
        const decimal COMM_RATE = 0.045m;
    
        const decimal INDUS_PEAK_FLAT = 76.00m;
        const decimal INDUS_PEAK_RATE = 0.065m;
        const decimal INDUS_OFFPEAK_FLAT = 40.00m;
        const decimal INDUS_OFFPEAK_RATE = 0.028m;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal resPowerAmount;     //input: residential power usage
            decimal resPowerCost;       //output: residential power cost

            decimal commPowerAmount;    //input: commercial power usage
            decimal commPowerCost;      //output: commercial power cost

            decimal indusPeakPowerAmount; //input: industrial peak power
            decimal indusNonPeakPowerAmount; //input: industrial non peak power
            decimal indusPowerAmount;  //total power amount

            decimal indusHighPowerCost;
            decimal indusLowPowerCost;
            decimal indusTotalPowerCost;
            

            /**RESIDENTIAL*/
            //get input
            resPowerAmount = Convert.ToDecimal(txtResPowerAmount.Text);
            //calculate 
            resPowerCost = RES_FLAT_RATE + (resPowerAmount * RES_RATE);
            //display
            txtResCost.Text = resPowerCost.ToString("c");
            txtResFlatRate.Text = RES_FLAT_RATE.ToString("c");
            txtResRatePerHour.Text = RES_RATE.ToString("f3");

            /**COMMERCIAL*/
            //get input
            commPowerAmount = Convert.ToDecimal(txtCommPowerAmount.Text);
            //calculate
            if (commPowerAmount <= USER_FIRST_TIME)
            {
                commPowerCost = COMM_FLAT_RATE;
            }
            else
            {
                commPowerCost = COMM_FLAT_RATE + (commPowerAmount * COMM_RATE);
            }
            //display
            txtCommCost.Text = commPowerCost.ToString("c");
            txtCommFlatRate.Text = COMM_FLAT_RATE.ToString("c");
            txtCommRatePerHour.Text = COMM_RATE.ToString("f3");

            /**INDUSTRIAL*/
            //get input
            indusPeakPowerAmount = Convert.ToDecimal(txtIndustPeakPowerAmount.Text);
            indusNonPeakPowerAmount = Convert.ToDecimal(txtIndustNonPeakPowerAmount.Text);

            //calculate

            if (indusPeakPowerAmount <= USER_FIRST_TIME)
            {
                indusHighPowerCost = INDUS_PEAK_FLAT;
            }
            else
            {
                indusHighPowerCost = INDUS_PEAK_FLAT + (INDUS_PEAK_RATE*indusPeakPowerAmount);
            }

            if(indusNonPeakPowerAmount <= USER_FIRST_TIME)
            {
                indusLowPowerCost = INDUS_OFFPEAK_FLAT;
            }
            else
            {
                indusLowPowerCost = INDUS_OFFPEAK_FLAT + (INDUS_OFFPEAK_RATE * indusNonPeakPowerAmount);
            }

            indusPowerAmount = indusPeakPowerAmount + indusNonPeakPowerAmount;
            indusTotalPowerCost = indusHighPowerCost + indusLowPowerCost;

            //display
            txtIndustPowerAmount.Text = indusPowerAmount.ToString();
            txtPeakHourFlat.Text = INDUS_PEAK_FLAT.ToString();
            txtNonPeakHourFlat.Text = INDUS_OFFPEAK_FLAT.ToString();
            txtPeakRate.Text = INDUS_PEAK_RATE.ToString();
            txtNonPeakRate.Text = INDUS_OFFPEAK_RATE.ToString();

            txtPeakHourCost.Text = indusHighPowerCost.ToString();
            txtNonPeakCost.Text = indusLowPowerCost.ToString();
            txtIndustCost.Text = indusTotalPowerCost.ToString();
        }

        //reset all form values to blank
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Residential
            txtResPowerAmount.Text = "";
            txtResCost.Text = "";
            txtResRatePerHour.Text = "";
            txtResFlatRate.Text = "";

            //Commercial
            txtCommPowerAmount.Text = "";
            txtCommCost.Text = "";
            txtCommRatePerHour.Text = "";
            txtCommFlatRate.Text = "";


            txtResPowerAmount.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
