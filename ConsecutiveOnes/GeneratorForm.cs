using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsecutiveOnes
{
    public partial class GeneratorForm : Form
    {
        MainWindow ownerForm = null;
        public GeneratorForm(MainWindow ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
        }

        

        private void button_Generate_data_Click(object sender, EventArgs e)
        {
            if(numericUpDown_columns.Text == "" || numericUpDown_rows.Text == "" || numericUpDown_ones_percentage.Text == "" || numericUpDown_no_errors.Text == "")
            {
                MessageBox.Show("Values can not be null or empty.","Error!");
            }
            if(numericUpDown_no_errors.Value > ((numericUpDown_columns.Value-2)*numericUpDown_rows.Value))
            {
                MessageBox.Show("Maximum acceptable number of errors in current size is "+(((numericUpDown_columns.Value - 1)* (numericUpDown_rows.Value-1))-1).ToString(), "Error!");
            }
            else
            {
                GenerateMatrix();
            }
        }

        Matrix matrixObject;

        private async Task GenerateTests() // funkcja do wygenerowania instancji do testów
        {
            for (int i = 0; i < 10; i++) // liczba testow
            {
                for (int j = 10; j <= 100; j += 10) // rozmiar
                {
                    for (int k = 30; k <= 90; k += 10) // %jedynek
                    {
                        for (int l = 0; l <= 80; l += 10) // %kolumn z bledami
                        {
                            string file_name = $"{j}x{j}_{k}_{l}_{i}.txt";

                            int errors = j*l/100;
                            matrixObject = new Matrix(j, j, k, errors);

                            await File.WriteAllTextAsync("C:/Users/wszym/Desktop/testin_zp/" + file_name, matrixObject.Debug_to_string());

                        }
                    }
                }
            }
        }
        private void GenerateMatrix()
        {
            matrixObject = new Matrix(Convert.ToInt32(numericUpDown_columns.Value), Convert.ToInt32(numericUpDown_rows.Value), Convert.ToInt32(numericUpDown_ones_percentage.Value), Convert.ToInt32(numericUpDown_no_errors.Value));
            MessageBox.Show($"Matrix succesfully generated! Estimated cmax: {matrixObject.Get_cmax_estimation()}");
            this.ownerForm.Pass_matrix_object(matrixObject);
            this.Visible = false;
        }
    }
}
