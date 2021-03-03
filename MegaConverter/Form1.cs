using System;
using System.Windows.Forms;

namespace MegaConverter
{
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        private void lengthBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            lengthForm temp = new lengthForm();
            temp.ShowDialog();
            this.Close();
        }

        private void weightBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            weightForm temp = new weightForm();
            temp.ShowDialog();
            this.Close();
        }

        private void tempBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            tempForm temp = new tempForm();
            temp.ShowDialog();
            this.Close();
        }

        private void fluidBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            fluidForm temp = new fluidForm();
            temp.ShowDialog();
            this.Close();
        }

        private void areaBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            areaForm temp = new areaForm();
            temp.ShowDialog();
            this.Close();
        }

        private void elecBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            pressureForm temp = new pressureForm();
            temp.ShowDialog();
            this.Close();
        }
    }
}
