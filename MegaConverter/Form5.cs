using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MegaConverter
{
    public partial class fluidForm : Form
    {
        // Lists for the two listboxes that contain all of the selection
        List<string> fromList = new List<string>();
        List<string> toList = new List<string>();

        // The checked and converted number
        private double inputNum;
        public fluidForm()
        {
            InitializeComponent();

            fromList.Add("millilitre");
            fromList.Add("centilitre");
            fromList.Add("decilitre");
            fromList.Add("litre");
            fromList.Add("decalitre");
            fromList.Add("kilolitre");
            fromList.Add("megalitre");
            fromList.Add("teaspoon UK");
            fromList.Add("tablespoon UK");
            fromList.Add("fluid ounce UK");
            fromList.Add("pint UK");
            fromList.Add("quart UK");
            fromList.Add("gallon UK");
            fromList.Add("peck UK");
            fromList.Add("bushel UK");

            fromListBox.DataSource = fromList;

            toList.Add("millilitre");
            toList.Add("centilitre");
            toList.Add("decilitre");
            toList.Add("litre");
            toList.Add("decalitre");
            toList.Add("kilolitre");
            toList.Add("megalitre");
            toList.Add("teaspoon UK");
            toList.Add("tablespoon UK");
            toList.Add("fluid ounce UK");
            toList.Add("pint UK");
            toList.Add("quart UK");
            toList.Add("gallon UK");
            toList.Add("peck UK");
            toList.Add("bushel UK");

            toListBox.DataSource = toList;
        }

        private double FindFromUnit()
        {
            // 1 metre is base unit the rest are units of a metre
            // Example a centilitre is 0.01 of a litre
            int fromIndex = fromListBox.SelectedIndex;
            double fromUnit = 0;

            switch (fromIndex)
            {
                case 0: // millilitre
                    fromUnit = 0.001;
                    break;
                case 1: // centilitre
                    fromUnit = 0.01;
                    break;
                case 2: // decilitre
                    fromUnit = 0.1;
                    break;
                case 3: // litre
                    fromUnit = 1;
                    break;
                case 4: // decalitre
                    fromUnit = 10;
                    break;
                case 5: // kilolitre
                    fromUnit = 1000;
                    break;
                case 6: // megalitre
                    fromUnit = 1000000;
                    break;
                case 7: // teaspoon UK
                    fromUnit = 0.00591939;
                    break;
                case 8: // tablespoon UK
                    fromUnit = 0.0177582;
                    break;
                case 9: // fluid ounce
                    fromUnit = 0.0295735;
                    break;
                case 10: // pint UK
                    fromUnit = 0.568261;
                    break;
                case 11: // quart UK
                    fromUnit = 1.13652;
                    break;
                case 12: // gallon
                    fromUnit = 4.54609;
                    break;
                case 13: // peck
                    fromUnit = 9.09218;
                    break;
                case 14: // bushel
                    fromUnit = 36.3687;
                    break;
                default:
                    fromUnit = 1;
                    break;
            }

            return fromUnit;
        }

        private double FindToUnit()
        {
            // 1 litre is base unit, everything else is the number of units compared to a litre
            // Example a gram is 0.1 of a decagram
            int toIndex = toListBox.SelectedIndex;
            double toUnit = 0;

            switch (toIndex)
            {
                case 0: // millilitre
                    toUnit = 1000;
                    break;
                case 1: // centilitre
                    toUnit = 100;
                    break;
                case 2: // decilitre
                    toUnit = 10;
                    break;
                case 3: // litre
                    toUnit = 1;
                    break;
                case 4: // decalitre
                    toUnit = 0.1;
                    break;
                case 5: // kilolitre
                    toUnit = 0.001;
                    break;
                case 6: // megalitre
                    toUnit = 0.000001;
                    break;
                case 7: // teaspoon UK
                    toUnit = 168.936;
                    break;
                case 8: // tablespoon UK
                    toUnit = 56.3121;
                    break;
                case 9: // fluid ounce
                    toUnit = 35.1951;
                    break;
                case 10: // pint UK
                    toUnit = 1.75975;
                    break;
                case 11: // quart UK
                    toUnit = 0.879877;
                    break;
                case 12: // gallon
                    toUnit = 0.219969;
                    break;
                case 13: // peck
                    toUnit = 0.109985;
                    break;
                case 14: // bushel
                    toUnit = 0.0274962;
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
