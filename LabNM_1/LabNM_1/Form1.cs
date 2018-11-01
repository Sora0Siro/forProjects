using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabNM_1
{
    public partial class Form1 : Form
    {     
        const int n = 10;
        double[] x = new double[n];
        double[] y = new double[n];
        public Form1()
        {
            InitializeComponent();
            int i;           
            for (i = 0; i < n; i++) x[i] = i + 1;           
            y[0] = 5;
            y[1] = 10;
            y[2] = 8;
            y[3] = 5;
            y[4] = 3;
            y[5] = 8;
            y[6] = 7;
            y[7] = 6;
            y[8] = 9;
            y[9] = 5;
            for(i = 0; i < n; i++) chart1.Series[1].Points.AddXY(x[i], y[i]);
        }    

        private void StartButton_Click(object sender, EventArgs e) { for (double i = x[0]; i < n; i += 0.05) chart1.Series[0].Points.AddXY(i, Poly(i)); }

        private double Poly(double ex)
        {
            double sum = 0, mult;
            int i, j;
            for (i = 0; i < n; i++)
            {
                mult = 1;
                for (j = 0; j < n; j++) if (j != i) mult *= (ex - x[j]) / (x[i] - x[j]);                
                sum += y[i] * mult;
            }
            return sum;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
