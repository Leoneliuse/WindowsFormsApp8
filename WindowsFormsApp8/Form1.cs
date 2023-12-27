using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int min = 0, minI=0, minJ=0;
            dataGridView1.ColumnCount = 3;
            dataGridView1.RowCount = 3;
            Random jo = new Random();
            int n = dataGridView1.RowCount;
            int m = dataGridView1.ColumnCount;
            int[,] mass = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mass[i, j] = jo.Next(-10,10);
                    dataGridView1.Rows[i].Cells[j].Value = mass[i, j].ToString();
                }
            }
            min = mass[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (min > mass[i,j])
                    {
                        min = mass[i,j];
                        minI = i;
                        minJ = j;
                    }
                }

            }
            label1.Text = "min:mass[" + minI + "," + minJ + "]" + "= " + min;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
