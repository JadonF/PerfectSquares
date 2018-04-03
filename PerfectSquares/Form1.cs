/*
 * Created by: Jadon Fournier
 * Created on: 3-Mar-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #21 - Perfect Squares
 * This program calculates which numbers are perfect squares below a user inputted value.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectSquares
{
    public partial class PerfectSquares : Form
    {
        public PerfectSquares()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Define variables
            int MaxValue;
            int Value = 1;
            double RootDouble;
            int RootInt;

            //Clear list
            this.lstPerfectSquaresList.Items.Clear();

            //Get the max value from user
            MaxValue = Convert.ToInt32(nudMaxValue.Value);

            //Use a while loop to check it
            while (Value <= MaxValue)
            {
                //Take square root of value
                RootDouble = Math.Sqrt(Value);

                //Convert the root as a double to an int and assign it to a variable
                RootInt = Convert.ToInt32(RootDouble);

                if (RootDouble == RootInt)
                {
                    //add the lsit item
                    this.lstPerfectSquaresList.Items.Add(Value + " is a perfect square.");

                    //Refresh the form
                    this.Refresh();
                }
                Value = Value + 1;
            }
            
        }
    }
}
