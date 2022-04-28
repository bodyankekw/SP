using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            double[,] matrix = new double[4, 4];
            matrix[0, 0] = double.Parse(a11.Text);
            matrix[0, 1] = double.Parse(a12.Text);
            matrix[0, 2] = double.Parse(a13.Text);
            matrix[0, 3] = double.Parse(a14.Text);
            matrix[1, 0] = double.Parse(a21.Text);
            matrix[1, 1] = double.Parse(a22.Text);
            matrix[1, 2] = double.Parse(a23.Text);
            matrix[1, 3] = double.Parse(a24.Text);
            matrix[2, 0] = double.Parse(a31.Text);
            matrix[2, 1] = double.Parse(a32.Text);
            matrix[2, 2] = double.Parse(a33.Text);
            matrix[2, 3] = double.Parse(a34.Text);
            matrix[3, 0] = double.Parse(a41.Text);
            matrix[3, 1] = double.Parse(a42.Text);
            matrix[3, 2] = double.Parse(a43.Text);
            matrix[3, 3] = double.Parse(a44.Text);

            double[] vector = new double[4];
            vector[0] = double.Parse(b1.Text);
            vector[1] = double.Parse(b2.Text);
            vector[2] = double.Parse(b3.Text);
            vector[3] = double.Parse(b4.Text);
            if (
                (matrix[0, 0] + matrix[0, 1] + matrix[0, 2] + matrix[0, 3] != 1) ||
                (matrix[1, 0] + matrix[1, 1] + matrix[1, 2] + matrix[1, 3] != 1) ||
                (matrix[2, 0] + matrix[2, 1] + matrix[2, 2] + matrix[2, 3] != 1) ||
                (matrix[3, 0] + matrix[3, 1] + matrix[3, 2] + matrix[3, 3] != 1))
            {
                MessageBox.Show("Введите корректные данные");
                return;
            }
            

            int M = int.Parse(N.Text);
            int iteration = 1;
            while (iteration <= M)
            {
                double[] v = new double[4];
                v[0] = Math.Round((vector[0] * matrix[0, 0] + vector[1] * matrix[1, 0] + vector[2] * matrix[2, 0] + vector[3] * matrix[3, 0]), 9);
                v[1] = Math.Round((vector[0] * matrix[0, 1] + vector[1] * matrix[1, 1] + vector[2] * matrix[2, 1] + vector[3] * matrix[3, 1]), 9);
                v[2] = Math.Round((vector[0] * matrix[0, 2] + vector[1] * matrix[1, 2] + vector[2] * matrix[2, 2] + vector[3] * matrix[3, 2]), 9);
                v[3] = Math.Round((vector[0] * matrix[0, 3] + vector[1] * matrix[1, 3] + vector[2] * matrix[2, 3] + vector[3] * matrix[3, 3]), 9);
                vector[0] = v[0];
                vector[1] = v[1];
                vector[2] = v[2];
                vector[3] = v[3];
                richTextBox1.Text += $"Цикл №{iteration} - [{v[0]}][{v[1]}][{v[2]}][{v[3]}]\n";
                iteration++;
            }
        }
    }
}
