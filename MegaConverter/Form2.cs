using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MegaConverter
{
    public partial class lengthForm : Form
    {
        // Lists for the two listboxes that contain all of the selection
        List<string> fromList = new List<string>();
        List<string> toList = new List<string>();

        // The checked and converted number
        private double inputNum;

        public lengthForm()
        {
            InitializeComponent();

            fromList.Add("nanometre");
            fromList.Add("micrometre");
            fromList.Add("millimetre");
            fromList.Add("centimetre");
            fromList.Add("metre");
            fromList.Add("kilometre");
            fromList.Add("inch");
            fromList.Add("foot");
            fromList.Add("yard");
            fromList.Add("mile");
            fromList.Add("nautical mile");

            fromListBox.DataSource = fromList;

            toList.Add("nanometre");
            toList.Add("micrometre");
            toList.Add("millimetre");
            toList.Add("centimetre");
            toList.Add("metre");
            toList.Add("kilometre");
            toList.Add("inch");
            toList.Add("foot");
            toList.Add("yard");
            toList.Add("mile");
            toList.Add("nautical mile");

            toListBox.DataSource = toList;
        }

        private double FindFromUnit()
        {
            // 1 metre is base unit the rest are units of a metre
            int fromIndex = fromListBox.SelectedIndex;
            double fromUnit = 0;

            switch (fromIndex)
            {
                case 0: // nanometre
                    fromUnit = 0.000000001;
                    break;
                case 1: // micrometre
                    fromUnit = 0.000001;
                    break;
                case 2: // millimetre
                    fromUnit = 0.001;
                    break;
                case 3: // centimetre
                    fromUnit = 0.01;
                    break;
                case 4: // metre
                    fromUnit = 1;
                    break;
                case 5: // kilometre
                    fromUnit = 1000;
                    break;
                case 6: // inch
                    fromUnit = 0.0254;
                    break;
                case 7: // foot
                    fromUnit = 0.3048;
                    break;
                case 8: // yard
                    fromUnit = 0.9144;
                    break;
                case 9: // mile
                    fromUnit = 1609.34;
                    break;
                case 10: // nautical mile
                    fromUnit = 1852;
                    break;
                default:
                    fromUnit = 1;
                    break;
            }

            return fromUnit;
        }

        private double FindToUnit()
        {
            // 1 metre is base unit, everything else is the number of units in a metre
            int toIndex = toListBox.SelectedIndex;
            double toUnit = 0;

            switch (toIndex)
            {
                case 0: // nanometre
                    toUnit = 1000000000;
                    break;
                case 1: // micrometre
                    toUnit = 1000000;
                    break;
                case 2: // millimetre
                    toUnit = 1000;
                    break;
                case 3: // centimetre
                    toUnit = 100;
                    break;
                case 4: // metre
                    toUnit = 1;
                    break;
                case 5: // kilometre
                    toUnit = 0.001;
                    break;
                case 6: // inch
                    toUnit = 39.3701;
                    break;
                case 7: // foot
                    toUnit = 3.28084;
                    break;
                case 8: // yard
                    toUnit = 1.09361;
                    break;
                case 9: // mile
                    toUnit = 0.000621371;
                    break;
                case 10: // nautical mile
                    toUnit = 0.000539957;
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

        private void backBut_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            homeForm home = new homeForm();
            home.ShowDialog();
            this.Close();
        }
    }
}
