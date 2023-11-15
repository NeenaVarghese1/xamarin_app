using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace APP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        
            private void OnCalculateClicked(object sender, EventArgs e)
        {
            if (double.TryParse(principalEntry.Text, out double principal) &&
                double.TryParse(rateEntry.Text, out double rate) &&
                double.TryParse(timeEntry.Text, out double time))
            {
                // Calculate simple interest
                double interest = (principal * rate * time) / 100;

                // Display the result
                resultEntry.Text = $" {interest:C}";
            }
            else
            {
                // Display an error message if input is invalid
                resultEntry.Text = "Invalid input. Please enter valid numbers.";
            }
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            // Clear all entry fields and result label
            principalEntry.Text = string.Empty;
            rateEntry.Text = string.Empty;
            timeEntry.Text = string.Empty;
            resultEntry.Text = string.Empty;
        }
    }
}

