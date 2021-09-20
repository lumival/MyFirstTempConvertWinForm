using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstTempConvertWinForm
{
    public partial class TemperatureConverter : Form
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void btn_Fahrenheit_Click(object sender, EventArgs e)
        {
            
            float f = 0;
            try
            {
                f = float.Parse(txtFahrenheit.Text);
            }
            catch
            {
                MessageBox.Show("Only enter numbers!");
            }


            float c = (5f / 9f) * (f - 32);
            txtCelcius.Text = c.ToString();

            float k = (f - 32) * (5f / 9f) + 273;
            txtKelvin.Text = k.ToString();
        }

        private void btn_Celcius_Click(object sender, EventArgs e)
        {
            float c = 0;

            try
            {
                c = float.Parse(txtCelcius.Text);
            }
            catch
            {
                MessageBox.Show("Only enter numbers!");
            }

            float f = (9f / 5f) * c + 32;
            txtFahrenheit.Text = f.ToString();

            float k = c + 273;
            txtKelvin.Text = k.ToString();
        }

        private void btn_Kelvin_Click(object sender, EventArgs e)
        {
            float k = 0;

            try
            {
                k = float.Parse(txtKelvin.Text);
            }
            catch
            {
                MessageBox.Show("Only enter numbers!");
            }

            float f = (9f / 5f) * ( k - 273 )  + 32;
            txtFahrenheit.Text = f.ToString();

            float c = k - 273;
            txtCelcius.Text = c.ToString();
        }
    }
}
