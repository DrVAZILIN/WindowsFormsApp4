using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void random_b_Click(object sender, EventArgs e)
        {
           Random rnd = new Random();
            DGV.RowCount = rnd.Next(2,4);
            DGV.ColumnCount = rnd.Next(2, 4);

            for (int i = 0; i < DGV.RowCount; i++)
            {
                for (int j = 0; j < DGV.ColumnCount; j++)
                {
                    
                    DGV[j, i].Value = rnd.Next(-100, 100) +Math.Round( rnd.NextDouble(),2);
                }
            
            }
   
            
        }

        private void result_b_Click(object sender, EventArgs e)
        {
            double[,] Matr = new double[DGV.RowCount, DGV.ColumnCount];//создали массив
            for (int i = 0; i < DGV.RowCount; i++)
                for (int j = 0; j < DGV.ColumnCount; j++)
                    Matr[i, j] = Convert.ToDouble(DGV[j, i].Value);

            ////min max
            double[] mas = new double[DGV.RowCount];

            for (int i = 0; i < DGV.RowCount; i++)
            {
                double max = Matr[i, 0];
                for (int j = 1; j < DGV.ColumnCount; j++)
                {
                    if (Matr[i, j] >= max)
                        max = Matr[i, j];
                }
                mas[i] = max;
            }
            double minmax = mas[0];
            for (int i = 1; i < mas.Length; i++)
                if (minmax > mas[i])
                    minmax = mas[i];
            double p = minmax;


            
            //maxmin
            double[] mas1 = new double[DGV.ColumnCount];
            for (int i = 0; i < DGV.ColumnCount; i++)
            {
                double min = Matr[0, i];
                for (int j = 0; j < DGV.RowCount; j++)
                {
                    if (Matr[j, i] <= min)
                        min = Matr[j, i];

                }
                mas1[i] = min;
            }
            double maxmin = mas1[0];
            for (int i = 0; i < DGV.ColumnCount; i++)
                if (maxmin < mas1[i])
                    maxmin = mas1[i];
            double q = maxmin;
            MessageBox.Show($"minmax = {minmax}\nmaxmin = {maxmin}\n" + (p * q).ToString());
            //MessageBox.Show((minmax,maxmin).ToString());
        }
    }
}
