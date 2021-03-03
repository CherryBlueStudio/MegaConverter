using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MegaConverter
{
    public partial class tempForm : Form
    {
        // Lists for the two listboxes that contain all of the selection
        List<string> fromList = new List<string>();
        List<string> toList = new List<string>();

        // The checked and converted number
        private double inputNum;

        public tempForm()
        {
            InitializeComponent();

            fromList.Add("celsius");
            fromList.Add("farenheit");
            fromList.Add("kelvin");

            fromListBox.DataSource = fromList;

            toList.Add("celsius");
            toList.Add("farenheit");
            toList.Add("kelvin");

            toListBox.DataSource = toList;
        }

        private void CheckForNumbers()
        {
            bool result = Double.TryParse(fromTextBox.Text, out inputNum);

            if (result)
            {
                enterNumberWarningPic.Visible = false;
                CalculateValues();
            }
            else
            {
                enterNumberWarningPic.Visible = true;
            }
        }

        private void CalculateValues()
        {
            int fromIndex = fromListBox.SelectedIndex;
            int toIndex = toListBox.SelectedIndex;
            double finalValue = 0.0;

            if (fromIndex == 0) // celsius
            {
                if (toIndex == 0)
                {
                    finalValue = inputNum;
                }
                else if (toIndex == 1)
                {
                    finalValue = inputNum * 1.8 + 32.0;
                }
                else
                {
                    finalValue = inputNum + 273.15;
                }
            }

            if (fromIndex == 1) // farenheit
            {
                if (toIndex == 1)
                {
                    finalValue = inputNum;
                }
                else if (toIndex == 2)
                {
                    finalValue = (inputNum + 459.67) * 5 / 9;
                }
                else
                {
                    finalValue = (inputNum - 32) / 1.8;
                }
            }
            if
                (fromIndex == 2) // kelvin
            {
                if (toIndex == 2)
                {
                    finalValue = inputNum;
                }
                else if (toIndex == 0)
                {
                    finalValue = inputNum - 273.15;
                }
                else
                {
                    finalValue = inputNum * 1.8 - 459.67;
                }
            }

            toTextBox.Text = finalValue.ToString();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            toTextBox.Text = "";
            CheckForNumbers();
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeForm home = new homeForm();
            home.ShowDialog();
            this.Close();
        }
    }
}
