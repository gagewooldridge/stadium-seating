
// This program will take user input values
// that represent the amount of tickets sold
// at very price points, and calculate the total
// of all ticket sales as well as keep a running
// grand total of all data input in the program

// Written by Gage Wooldridge

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333_WooldridgeG_Lab03
{
    public partial class Form1 : Form
    {
        // Declare constants that reflect the
        // constant price of each type of ticket
        //
        // Also initialize a variable for the total
        // amount and set it's value to zero

        private const decimal classAPrice = 15;
        private const decimal classBPrice = 12;
        private const decimal classCPrice = 9;
        private decimal runningTotal = 0.0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Simple exception handling solution that displays
            // a default error message if user inputs a string 
            // value that cannot be converted to decimal format

            try
            {
                // Declare all variables necessary to compute
                // total values that must be calculated

                decimal classATotal = 0.0m, classBTotal = 0.0m, classCTotal = 0.0m, total = 0.0m; ;

                // Convert user classA string input to decimal format
                // and calculate total classA decimal values

                var classA = decimal.Parse(classATextBox.Text);
                classATotal = classA * classAPrice;

                // Convert the total decimal value to a string
                // data type and display it in the output label

                outputALabel.Text = classATotal.ToString("c");

                // Convert user classB string input to decimal format
                // and calculate total classB decimal values

                var classB = decimal.Parse(classBTextBox.Text);
                classBTotal = classB * classBPrice;

                // Convert the total decimal value to a string
                // data type and display it in the output label

                outputBLabel.Text = classBTotal.ToString("c");

                // Convert user classC string input to decimal format
                // and calculate total classC decimal values

                var classC = decimal.Parse(classCTextBox.Text);
                classCTotal = classC * classCPrice;

                // Convert the total decimal value to a string
                // data type and display it in the output label

                outputCLabel.Text = classCTotal.ToString("c");

                // Compute total value of tickets sold

                total = classATotal + classBTotal + classCTotal;

                // Convert the total decimal value to a string
                // data type and display it in the output label

                totalLabel.Text = total.ToString("c");

                // Add the new total value for this calculation
                // to the running total of revenue

                runningTotal += total;

                // Convert the running total decimal value to a string
                // data type and display it in the output label

                runningTotalLabel.Text = runningTotal.ToString("c");

                // Clear text boxes and reset focus

                classATextBox.Text = ("");
                classBTextBox.Text = ("");
                classCTextBox.Text = ("");
                classATextBox.Focus();
            }
            catch (Exception ex)
            {
                // Display default error message

                MessageBox.Show(ex.Message);

                // Clear text boxes and output labels

                classATextBox.Text = ("");
                classBTextBox.Text = ("");
                classCTextBox.Text = ("");
                outputALabel.Text = ("");
                outputBLabel.Text = ("");
                outputCLabel.Text = ("");
                totalLabel.Text = ("");

                // Set focus to classATextBox

                classATextBox.Focus();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear text boxes and output labels

            classATextBox.Text = ("");
            classBTextBox.Text = ("");
            classCTextBox.Text = ("");
            outputALabel.Text = ("");
            outputBLabel.Text = ("");
            outputCLabel.Text = ("");
            totalLabel.Text = ("");

            // Set focus to classATextBox

            classATextBox.Focus();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exits the program

            this.Close();
        }
    }
}
