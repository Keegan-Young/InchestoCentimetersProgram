using System;
using System.Windows.Forms;

namespace InchesToCentimetersGUI
{
    public partial class InchesToCentimetrsGUI : Form
    {
        const double CENTIMETERSINANINCH = 2.54;

        public InchesToCentimetrsGUI()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            double inches = 0.0;
            double centimeters = 0.0;

            inches = Convert.ToDouble(textBox1.Text);
            centimeters = inches * CENTIMETERSINANINCH;

            textBox2.Text = centimeters.ToString("f2");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Do you really want to exit?",
                "Exit Program?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
