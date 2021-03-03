using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MegaConverter
{
    public partial class areaForm : Form
    {
        // Lists for the two listboxes that contain all of the selection
        List<string> fromList = new List<string>();
        List<string> toList = new List<string>();

        // The checked and converted number
        private double inputNum;

        public areaForm()
        {
            InitializeComponent();

            fromList.Add("square millimetre");
            fromList.Add("square centimetre");
            fromList.Add("square decimetre");
            fromList.Add("square metre");
            fromList.Add("square decametre");
            fromList.Add("square hectometre");
            fromList.Add("square kilometre");
            fromList.Add("square inch");
            fromList.Add("square foot");
            fromList.Add("square yard");
            fromList.Add("square rod");
            fromList.Add("acre");
            fromList.Add("square mile");

            fromListBox.DataSource = fromList;

            toList.Add("square millimetre");
            toList.Add("square centimetre");
            toList.Add("square decimetre");
            toList.Add("square metre");
            toList.Add("square decametre");
            toList.Add("square hectometre");
            toList.Add("square kilometre");
            toList.Add("square inch");
            toList.Add("square foot");
            toList.Add("square yard");
            toList.Add("square rod");
            toList.Add("acre");
            toList.Add("square mile");

            toListBox.DataSource = toList;
        }

        private double FindFromUnit()
        {
            // 1 square metre is base unit the rest are units of a metre
            int fromIndex = fromListBox.SelectedIndex;
            double fromUnit = 0;


            switch (fromIndex)
            {
                case 0: // square millimetre
                    fromUnit = 0.000001;
                    break;
                case 1: // square centimetre
                    fromUnit = 0.0001;
                    break;
                case 2: // square decimetre
                    fromUnit = 0.01;
                    break;
                case 3: // square metre
                    fromUnit = 1;
                    break;
                case 4: // square decametre
                    fromUnit = 100;
                    break;
                case 5: // square hectometre
                    fromUnit = 10000;
                    break;
                case 6: // square kilometre
                    fromUnit = 1000000;
                    break;
                case 7: // square inch
                    fromUnit = 0.00064516;
                    break;
                case 8: // square foot
                    fromUnit = 0.092903;
                    break;
                case 9: // square yard
                    fromUnit = 0.836127;
                    break;
                case 10: // square rod
                    fromUnit = 25.2929;
                    break;
                case 11: // acre
                    fromUnit = 4046.86;
                    break;
                case 12: // square mile
                    fromUnit = 2590000;
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
                case 0: // square millimetre
                    toUnit = 1000000;
                    break;
                case 1: // square centimetre
                    toUnit = 10000;
                    break;
                case 2: // square decimetre
                    toUnit = 100;
                    break;
                case 3: // square metre
                    toUnit = 1;
                    break;
                case 4: // square decametre
                    toUnit = 0.01;
                    break;
                case 5: // square hectometre
                    toUnit = 0.0001;
                    break;
                case 6: // square kilometre
                    toUnit = 0.000001;
                    break;
                case 7: // square inch
                    toUnit = 1550;
                    break;
                case 8: // square foot
                    toUnit = 10.7639;
                    break;
                case 9: // square yard
                    toUnit = 1.19599;
                    break;
                case 10: // square rod
                    toUnit = 0.0395369;
                    break;
                case 11: // acre
                    toUnit = 0.000247105;
                    break;
                case 12: // square mile
                    toUnit = 0.0000003861;
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
