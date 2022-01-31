
namespace ConsecutiveOnes
{
    partial class TabuProcedureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_start_tabu = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button_stop_tabu = new System.Windows.Forms.Button();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.label_log = new System.Windows.Forms.Label();
            this.label_no_restarts = new System.Windows.Forms.Label();
            this.label_tabu_list_size = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_no_restarts = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_size_tabu_list = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_no_improv_ite = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_use_greedy_arrangement = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_diversify = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_no_restarts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size_tabu_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_no_improv_ite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_diversify)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start_tabu
            // 
            this.button_start_tabu.Location = new System.Drawing.Point(12, 415);
            this.button_start_tabu.Name = "button_start_tabu";
            this.button_start_tabu.Size = new System.Drawing.Size(120, 23);
            this.button_start_tabu.TabIndex = 0;
            this.button_start_tabu.Text = "Start";
            this.button_start_tabu.UseVisualStyleBackColor = true;
            this.button_start_tabu.Click += new System.EventHandler(this.button_start_tabu_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 386);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(524, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // button_stop_tabu
            // 
            this.button_stop_tabu.Location = new System.Drawing.Point(416, 415);
            this.button_stop_tabu.Name = "button_stop_tabu";
            this.button_stop_tabu.Size = new System.Drawing.Size(120, 23);
            this.button_stop_tabu.TabIndex = 3;
            this.button_stop_tabu.Text = "Stop";
            this.button_stop_tabu.UseVisualStyleBackColor = true;
            this.button_stop_tabu.Click += new System.EventHandler(this.button_stop_tabu_Click);
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(12, 265);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ReadOnly = true;
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_log.Size = new System.Drawing.Size(524, 115);
            this.textBox_log.TabIndex = 4;
            // 
            // label_log
            // 
            this.label_log.AutoSize = true;
            this.label_log.Location = new System.Drawing.Point(12, 247);
            this.label_log.Name = "label_log";
            this.label_log.Size = new System.Drawing.Size(30, 15);
            this.label_log.TabIndex = 5;
            this.label_log.Text = "Log:";
            // 
            // label_no_restarts
            // 
            this.label_no_restarts.AutoSize = true;
            this.label_no_restarts.Location = new System.Drawing.Point(94, 33);
            this.label_no_restarts.Name = "label_no_restarts";
            this.label_no_restarts.Size = new System.Drawing.Size(109, 15);
            this.label_no_restarts.TabIndex = 6;
            this.label_no_restarts.Text = "Number of restarts:";
            // 
            // label_tabu_list_size
            // 
            this.label_tabu_list_size.AutoSize = true;
            this.label_tabu_list_size.Location = new System.Drawing.Point(114, 62);
            this.label_tabu_list_size.Name = "label_tabu_list_size";
            this.label_tabu_list_size.Size = new System.Drawing.Size(89, 15);
            this.label_tabu_list_size.TabIndex = 7;
            this.label_tabu_list_size.Text = "Size of tabu list:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Iterations without improvement:";
            // 
            // numericUpDown_no_restarts
            // 
            this.numericUpDown_no_restarts.Location = new System.Drawing.Point(209, 31);
            this.numericUpDown_no_restarts.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_no_restarts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_no_restarts.Name = "numericUpDown_no_restarts";
            this.numericUpDown_no_restarts.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_no_restarts.TabIndex = 10;
            this.numericUpDown_no_restarts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_size_tabu_list
            // 
            this.numericUpDown_size_tabu_list.Location = new System.Drawing.Point(209, 60);
            this.numericUpDown_size_tabu_list.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_size_tabu_list.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_size_tabu_list.Name = "numericUpDown_size_tabu_list";
            this.numericUpDown_size_tabu_list.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_size_tabu_list.TabIndex = 11;
            this.numericUpDown_size_tabu_list.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_no_improv_ite
            // 
            this.numericUpDown_no_improv_ite.Location = new System.Drawing.Point(209, 89);
            this.numericUpDown_no_improv_ite.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numericUpDown_no_improv_ite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_no_improv_ite.Name = "numericUpDown_no_improv_ite";
            this.numericUpDown_no_improv_ite.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_no_improv_ite.TabIndex = 12;
            this.numericUpDown_no_improv_ite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "User parameters:";
            // 
            // checkBox_use_greedy_arrangement
            // 
            this.checkBox_use_greedy_arrangement.AutoSize = true;
            this.checkBox_use_greedy_arrangement.Location = new System.Drawing.Point(12, 214);
            this.checkBox_use_greedy_arrangement.Name = "checkBox_use_greedy_arrangement";
            this.checkBox_use_greedy_arrangement.Size = new System.Drawing.Size(199, 19);
            this.checkBox_use_greedy_arrangement.TabIndex = 15;
            this.checkBox_use_greedy_arrangement.Text = "Use greedy column arrangement";
            this.checkBox_use_greedy_arrangement.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.MaximumSize = new System.Drawing.Size(200, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Amount of diversify movements in iterations without improvement:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numericUpDown_diversify
            // 
            this.numericUpDown_diversify.Location = new System.Drawing.Point(209, 125);
            this.numericUpDown_diversify.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_diversify.Name = "numericUpDown_diversify";
            this.numericUpDown_diversify.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_diversify.TabIndex = 17;
            // 
            // TabuProcedureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.numericUpDown_diversify);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_use_greedy_arrangement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_no_improv_ite);
            this.Controls.Add(this.numericUpDown_size_tabu_list);
            this.Controls.Add(this.numericUpDown_no_restarts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_tabu_list_size);
            this.Controls.Add(this.label_no_restarts);
            this.Controls.Add(this.label_log);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.button_stop_tabu);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_start_tabu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TabuProcedureForm";
            this.Text = "Tabu search algorithm";
            
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_no_restarts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size_tabu_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_no_improv_ite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_diversify)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start_tabu;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button_stop_tabu;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Label label_log;
        private System.Windows.Forms.Label label_no_restarts;
        private System.Windows.Forms.Label label_tabu_list_size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_no_restarts;
        private System.Windows.Forms.NumericUpDown numericUpDown_size_tabu_list;
        private System.Windows.Forms.NumericUpDown numericUpDown_no_improv_ite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_use_greedy_arrangement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_diversify;
    }
}