using System;
using System.Windows.Forms;
namespace Tip_Calculator
{
    public partial class tip_calculator : Form
    {
        public tip_calculator()
        {
            InitializeComponent();
        }
        public void DoCalculation()     //this function will call by other functions to avoid repetition
        {
            string amount = bill_amount_input.Text;     //storing Total Bill inputted by user
            decimal tip = tip_input.Value;  //storing tip % inputted by user
            decimal person = total_people_input.Value;  //storing total person inputted by user
            decimal calculate_tip = 0;  //initialize
            decimal calculate_total = 0;    //initialize
            decimal amt = 0;    //initialize
            try
            {
                amt = Convert.ToDecimal(amount);    //type conversion of amount to decimal
                alert.Text = "";        //to set alert to nothing when amount has no character
            }
            catch (FormatException) { alert.Text = "Invalid Input! Please provide numeric bill amount"; }
            if (amt < 0)
            {
                //amount entered by user is negative -> no need to do calculation
            }
            else     //if amount entered by user is positive than only do the calculation
            {
                try
                {
                    //calculating tip per person in decimal form
                    calculate_tip = (amt * tip) / (person * 100);
                }
                catch (DivideByZeroException) { }
                try
                {
                    //calculating total amount to be paid by per person
                    calculate_total = (amt - calculate_tip * person) / person;
                }
                catch (DivideByZeroException) { }
                finally
                {
                    //displaying the total tip per person 
                    tip_amt_per_person.Text = "\u20B9" + calculate_tip.ToString("#.00");
                    //displaying total amount to be paid by per person
                    total_amt_per_person.Text = "\u20B9" + calculate_total.ToString("#.00");
                }
            }
        }
        private void bill_amount_input_TextChanged(object sender, EventArgs e)
        {
            DoCalculation();    //function call
        }

        private void tip_input_ValueChanged(object sender, EventArgs e)
        {
            DoCalculation();    //function call
        }

        private void total_people_input_ValueChanged(object sender, EventArgs e)
        {
            DoCalculation();    //function call
        }
        private void tip_calculator_Load(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e){ }

        private void label3_Click(object sender, EventArgs e){ }

        private void tip_amt_per_person_Click(object sender, EventArgs e){ }

        private void total_amt_per_person_Click(object sender, EventArgs e) { }
    }
}
