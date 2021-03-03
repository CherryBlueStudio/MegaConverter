using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MegaConverter
{
    public partial class pressureForm : Form
    {
        // Lists for the two listboxes that contain all of the selection
        List<string> fromList = new List<string>();
        List<string> toList = new List<string>();

        // The checked and converted number
        private double inputNum;

        public pressureForm()
        {
            InitializeComponent();

            fromList.Add("PSI");
            fromList.Add("bar");
            fromList.Add("standard atmosphere");
            fromList.Add("torr");
            fromList.Add("pascal");

            fromListBox.DataSource = fromList;

            toList.Add("PSI");
            toList.Add("bar");
            toList.Add("standard atmosphere");
            toList.Add("torr");
            toList.Add("pascal");

            toListBox.DataSource = toList;
        }

        private double FindFromUnit()
        {
            // 1 bar is base unit the rest are units of 1 bar
            int fromIndex = fromListBox.SelectedIndex;
            double fromUnit = 0;


            switch (fromIndex)
            {
                case 0: // PSI
                    fromUnit = 0.0689476;
                    break;
                case 1: // bar
                    fromUnit = 1;
                    break;
                case 2: // standard atmosphere
                    fromUnit = 1.01325;
                    break;
                case 3: // torr
                    fromUnit = 0.00133322;
                    break;
                case 4: // pascal
                    fromUnit = 0.00001;
                    break;
                default:
                    fromUnit = 1;
                    break;
            }

            return fromUnit;
        }

        private double FindToUnit()
        {
            // 1 bar is base unit the rest are units that equal 1 bar
            int toIndex = toListBox.SelectedIndex;
            double toUnit = 0;

            switch (toIndex)
            {
                case 0: // PSI
                    toUnit = 14.5038;
                    break;
                case 1: // bar
                    toUnit = 1;
                    break;
                case 2: // standard atmosphere
                    toUnit = 0.986923;
                    break;
                case 3: // torr
                    toUnit = 750.062;
                    break;
                case 4: // pascal
                    toUnit = 100000;
                    break;
                default:
                    toUnit = 1;
                    break;
            }
            return toUnit;
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
            // Check if unit conversion is using same selected values to bypass rounding errors
            if (fromListBox.SelectedIndex == toListBox.SelectedIndex)
            {
                toTextBox.Text = fromTextBox.Text;
            }
            else
            {
                // Find the base units
                double fromUnit = FindFromUnit();
                double toUnit = FindToUnit();

                // Perform conversion
                double fromSum = inputNum * fromUnit;
                double returnValue = fromSum * toUnit;

                toTextBox.Text = returnValue.ToString();
            }
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
