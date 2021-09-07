using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Lytaya_jija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Double n, p1, p2, x, z;
            try
            {
                n = Convert.ToDouble(textBoxN1.Text);
                p1 = Convert.ToDouble(textBoxP1.Text);
                p2 = Convert.ToDouble(textBoxP2.Text);
            

            // 6 стр по 75% =  18 стр по 25%
            // n1       p1     z        p2

            x = p1 / p2;
            z = n * x;

            if (z >= 0)
                textBoxAnsw.Text = Convert.ToString(z);
            else
                textBoxAnsw.Text = "Отриц. число";
            }
            catch { textBoxAnsw.Text = "что-то не так"; }
        }
    }
}
