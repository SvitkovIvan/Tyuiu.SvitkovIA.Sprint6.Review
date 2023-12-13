using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.SvitkovIA.Sprint6.TaskReview.V21.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;

namespace Tyuiu.SvitkovIA.Sprint6.TaskReview.V21
{
    public partial class FormMain_SIA : Form
    {

        public FormMain_SIA()
        {
            InitializeComponent();
        }

        private void  GenerateButton_Click_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(NumRowsTextBox_SIA.Text);
            int columns = Convert.ToInt32(NumColumnsTextBox_SIA.Text);
            int[,] array = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(1, 100);
                }
            }

            MatrixDataGridView_SIA.RowCount = rows;
            MatrixDataGridView_SIA.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    MatrixDataGridView_SIA.Rows[i].Cells[j].Value = array[i, j];
                }
            }
        }

        private void MaxElementButton_Click_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(n1TextBox_SIA.Text);
            int n2 = Convert.ToInt32(n2TextBox_SIA.Text);
            int c = Convert.ToInt32(cTextBox_SIA.Text);
            int k = Convert.ToInt32(kTextBox_SIA.Text);
            int l = Convert.ToInt32(lTextBox_SIA.Text);

            try
            {
                int[,] array = new int[MatrixDataGridView_SIA.RowCount, MatrixDataGridView_SIA.ColumnCount];

                for (int i = 0; i < MatrixDataGridView_SIA.RowCount; i++)
                {
                    for (int j = 0; j < MatrixDataGridView_SIA.ColumnCount; j++)
                    {
                        array[i, j] = Convert.ToInt32(MatrixDataGridView_SIA.Rows[i].Cells[j].Value);
                    }
                }

                int maxElement = GetMatrix(array, n1, n2, c, k, l);
                MaxElementTextBox_SIA.Text = maxElement.ToString();
            }
            catch
            {
                MessageBox.Show("Неверно введенные данные");
            }
        }

        private int GetMatrix(int[,] array, int n1, int n2, int c, int k, int l)
        {
            int maxElement = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > maxElement)
                    {
                        maxElement = array[i, j];
                    }
                }
            }
            return maxElement;


        }

        private void buttonInfo_SIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("СпринтРевью6 выполнил студент группы АСОиУБ-23-2 Cвитков Иван Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
