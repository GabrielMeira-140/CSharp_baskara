using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhaskara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmCalcular_Click(object sender, EventArgs e)
        {
            double a, b, c, delta, res;
             a =(double)(numUDA.Value);
             b = (double)(numUDB.Value);
             c = (double)(numUDC.Value);
            delta = (double) (Math.Pow(b, 2) - (4 * a * c));


                res = (-b + Math.Sqrt(delta)) / 2 * a;
                MessageBox.Show("x1: " + res);
 
                res = (-b - Math.Sqrt(delta)) / 2 * a;
                MessageBox.Show("x2: " + res);
  
        }
    }
}
