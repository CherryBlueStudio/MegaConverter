using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MegaConverter
{
    public partial class weightForm : Form
    {
        // Lists for the two listboxes that contain all of the selection
        List<string> fromList = new List<string>();
        List<string> toList = new List<string>();

        // The checked and converted number
        private double inputNum;

        public weightForm()
        {
            InitializeComponent();

            fromList.Add("milligram");
            fromList.Add("centigram");
            fromList.Add("decigram");
            fromList.Add("gram");
            fromList.Add("decagram");
            fromList.Add("kilogram");
            fromList.Add("tonne");
            fromList.Add("ounce");
            fromList.Add("pound");
            fromList.Add("stone UK");
            fromList.Add("quarter UK");
            fromList.Add("hundredweight UK");
            fromList.Add("ton UK");

            fromListBox.DataSource = fromList;

            toList.Add("milligram");
            toList.Add("centigram");
            toList.Add("decigram");
            toList.Add("gram");
            toList.Add("decagram");
            toList.Add("kilogram");
            toList.Add("tonne");
            toList.Add("ounce");
            toList.Add("pound");
            toList.Add("stone UK");
            toList.Add("quarter UK");
            toList.Add("hundredweight UK");
            toList.Add("ton UK");

            toListBox.DataSource = toList;
        }

        private double FindFromUnit()
        {
            // 1 gram is base unit the rest are units of a gram
            int fromIndex = fromListBox.SelectedIndex;
            double fromUnit = 0;

            switch (fromIndex)
            {
                case 0: // milligram
                    fromUnit = 0.001;
                    break;
                case 1: // centigram
                    fromUnit = 0.01;
                    break;
                case 2: // decigram
                    fromUnit = 0.1;
                    break;
                case 3: // gram
                    fromUnit = 1;
                    break;
                case 4: // decagram
                    fromUnit = 10;
                    break;
                case 5: // kilogram
                    fromUnit = 1000;
                    break;
                case 6: // tonne
                    fromUnit = 1000000;
                    break;
                case 7: // ounce
                    fromUnit = 28.349523125;
                    break;
                case 8: // pound
                    fromUnit = 453.59237;
                    break;
                case 9: // stone UK
                    fromUnit = 6350.29318;
                    break;
                case 10: // quarter UK
                    fromUnit = 12700.58636;
                    break;
                case 11: // hundredweight UK
                    fromUnit = 50802.34544;
                    break;
                case 12: // ton UK
                    fromUnit = 1016046.9088;
                    break;
                default:
                    fromUnit = 1;
                    break;
            }

            return fromUnit;
        }

        private double FindToUnit()
        {
            // 1 gram is base unit, everything else is the number of units in a gram
            int toIndex = toListBox.SelectedIndex;
            double toUnit = 0;

            switch (toIndex)
            {
                case 0: // milligram
                    toUnit = 1000;
                    break;
                case 1: // centigram
                    toUnit = 100;
                    break;
                case 2: // decigram
                    toUnit = 10;
                    break;
                case 3: // gram
                    toUnit = 1;
                    break;
                case 4: // decagram
                    toUnit = 0.1;
                    break;
                case 5: // kilogram
                    toUnit = 0.001;
                    break;
                case 6: // tonne
                    toUnit = 0.000001;
                    break;
                case 7: // ounce
                    toUnit = 0.0352739619;
                    break;
                case 8: // pound
                    toUnit = 0.0022046226;
                    break;
                case 9: // stone UK
                    toUnit = 0.000157473;
                    break;
                case 10: // quarter UK
                    toUnit = 0.0000787365;
                    break;
                case 11: // hundredweight UK
                    toUnit = 0.0000196841;
                    break;
                case 12: // ton UK
                    toUnit = 9.8421e-7;
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

                // Perfrom conversion
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

        // Find out how to get rid of this
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
