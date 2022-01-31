using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsecutiveOnes
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Matrix matrix_problem; //object with matrix (problem instance)
        public void Pass_matrix_object(Matrix my_object)
        {
            matrix_problem = my_object;
            this.textBox_matrix.Text = my_object.Debug_to_string();

        }

        public Matrix Return_matrix_object()
        {
            return matrix_problem;
        }

        private void button_Generate_matrix_Click(object sender, EventArgs e)
        {
            GeneratorForm form_generator = new GeneratorForm(this);
            form_generator.ShowDialog();
        }

        private void button_Run_tabu_Click(object sender, EventArgs e)
        {
            if(textBox_matrix.Text == "")
            {
                MessageBox.Show("Matrix can not be null.", "Error!");
            }
            else
            {
                TabuProcedureForm form_tabu = new TabuProcedureForm(this);
                form_tabu.ShowDialog();
            }
            
        }

        private bool check_if_matrix_string_incorrect(string matrix)
        {
            string[] lines = matrix.Split('\n');
            int elements = lines[0].Length;
            foreach(string line in lines)
            {
                if(line.Length != elements)
                {
                    return true;
                }
            }
            return false;
        }
        private void button_Save_matrix_to_file_Click(object sender, EventArgs e)
        {
            if (textBox_matrix.Text == "")
            {
                MessageBox.Show("Field can not be empty.", "Error!");
            }else if(matrix_problem == null)
            {
                MessageBox.Show("Generate or load instance first.", "Error!");
            }
            else if (false)
            {
                MessageBox.Show("Incorrect format.", "Error!");
            }
            else
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.Title = "Save matrix to file.";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, textBox_matrix.Text);
                }
            }
            
        }

        private void button_Update_matrix_tbox_Click(object sender, EventArgs e)
        {
            
            if (textBox_matrix.Text == "")
            {
                MessageBox.Show("Field can not be empty.", "Error!");
            } else if (!IsOnesZerosOnly(textBox_matrix.Text))
            {
                MessageBox.Show("Field can only contain 0s and 1s.", "Error!");
            }
            else if (matrix_problem == null)
            {
                MessageBox.Show("Generate or load instance first.", "Error!");
            }
            else if (false)
            {
                MessageBox.Show("Incorrect format.", "Error!");
            }
            else
            {
                try 
                {
                    matrix_problem = new Matrix(textBox_matrix.Text);
                    textBox_matrix.Text = matrix_problem.Debug_to_string();
                    MessageBox.Show("Changes made succesfully.");
                }catch(Exception)
                {
                    MessageBox.Show($"Incorrect format.");
                }
                
            }
        }

        private bool IsOnesZerosOnly(string str)
        {
            
            foreach (char c in str)
            {
                if (c != '0' && c != '1' && c != ' ' && c != '\n' && c != '\r')
                {
                    Debug.WriteLine(c);
                    return false;
                }
            }
            return true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //TODO loading from file function
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
        }

        private void button_Load_matrix_ff_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Text File";
            openFileDialog.Filter = "TXT files|*.txt";
            //openFileDialog.InitialDirectory = "c:\\";

            string pathToFile = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathToFile = openFileDialog.FileName;
            }
            string text = "";
            if (File.Exists(pathToFile))
            {
                
                using (StreamReader sr = new StreamReader(pathToFile))
                {
                    text = sr.ReadToEnd();
                }
            }
            try 
            {
                matrix_problem = new Matrix(text);
                this.textBox_matrix.Text = matrix_problem.Debug_to_string();
            }
            catch (Exception)
            {
                MessageBox.Show($"Error while reading a file.");
            }
            
        }
    }
}
