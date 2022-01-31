using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsecutiveOnes
{
    public partial class TabuProcedureForm : Form
    {
        MainWindow ownerForm = null;
        Matrix matrix_problem = null;
        TabuAlgorithm tabu_procedure;
        
        public TabuProcedureForm(MainWindow ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
            matrix_problem = ownerForm.Return_matrix_object();
        }



        CancellationTokenSource cts = new CancellationTokenSource();
        private async void button_start_tabu_Click(object sender, EventArgs e)
        {
            button_start_tabu.Enabled = false;
            int[,] temp_matrix = matrix_problem.Get_matrix().Clone() as int[,];
            if (checkBox_use_greedy_arrangement.Checked)
            {
                matrix_problem.Greedy_arrangement();
            }
            else
            {
                matrix_problem.Set_matrix(temp_matrix);
            }
            this.textBox_log.Text = "";
            cts = new CancellationTokenSource();
            await run_tabu_async();

            button_start_tabu.Enabled = true;
        }
        
        private async Task run_tabu_async()
        {
            
            tabu_procedure = new TabuAlgorithm(Convert.ToInt32(numericUpDown_no_restarts.Value), Convert.ToInt32(numericUpDown_size_tabu_list.Value), Convert.ToInt32(numericUpDown_no_improv_ite.Value), Convert.ToInt32(numericUpDown_diversify.Value), matrix_problem);
            progressBar1.Maximum = tabu_procedure.Get_number_of_restarts();
            progressBar1.Step = 1;

            var progress = new Progress<int>(v =>
            {
                progressBar1.Value = v;
            });

            
            var watch = System.Diagnostics.Stopwatch.StartNew();
            string result_report ="";
            await Task.Run(() => result_report = tabu_procedure.StartTabu(progress, cts.Token));
            
            watch.Stop();
            if(cts != null)
            {
                MessageBox.Show("Search finished.");
            }
            else
            {
                MessageBox.Show("Search finished.");
            }
            
            float elapsed_ms = watch.ElapsedMilliseconds;
            this.textBox_log.Text += result_report;
            this.textBox_log.Text += $"Total execution time: {elapsed_ms/1000} s" + Environment.NewLine;
        }

        private void button_stop_tabu_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            tabu_procedure = new TabuAlgorithm(Convert.ToInt32(numericUpDown_no_restarts.Value), Convert.ToInt32(numericUpDown_size_tabu_list.Value), Convert.ToInt32(numericUpDown_no_improv_ite.Value), Convert.ToInt32(numericUpDown_diversify.Value), matrix_problem);
            tabu_procedure.testy_bledow();
        }

        
    }
}
