//Written By Matthew Bethke, Andrew Poppenberg
//Date: 01/28/17
//Chapter 3, Case Problem 1
//Program Calculates Estimated revenue for contest and displays revenue and whether or not it increased from the year prior
//No Issues Encountered
using System;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class RevenueForm : Form
    {
        public RevenueForm()
        {
            InitializeComponent();
        }

        private void getRevenue_Click(object sender, EventArgs e)
        {
            int lastAttend = Convert.ToInt32(lastYearInput.Text);
            int thisAttend = Convert.ToInt32(thisYearInput.Text);
            bool isGreater = (thisAttend > lastAttend);
            revenueOutput.Text = Convert.ToString(thisAttend * 25);
            greaterOutput.Text = Convert.ToString(isGreater);
        }

        private void TYALabel_Click(object sender, EventArgs e)
        {

        }
    }
}
