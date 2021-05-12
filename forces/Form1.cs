using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }

        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }
        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }

        double acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // read force and angle from textboxes
                double Force = double.Parse(textBox1.Text);
                double Angle = double.Parse(textBox2.Text);
                //
                double Fx = Force * cos(Angle);
                double Fy = Force * sin(Angle);
                //d
                label1.Text = "Fx = " + Fx;
                label2.Text = "Fy = " + Fy;
            }
            catch
            {
                // show error message on screen if fail
                MessageBox.Show("D'oh!");

            }
        }
    }
}