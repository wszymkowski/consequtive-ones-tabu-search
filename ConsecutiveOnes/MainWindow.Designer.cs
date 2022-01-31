
namespace ConsecutiveOnes
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Generate_matrix = new System.Windows.Forms.Button();
            this.button_Load_matrix_ff = new System.Windows.Forms.Button();
            this.textBox_matrix = new System.Windows.Forms.TextBox();
            this.button_Update_matrix_tbox = new System.Windows.Forms.Button();
            this.button_Run_tabu = new System.Windows.Forms.Button();
            this.button_Save_matrix_to_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Generate_matrix
            // 
            this.button_Generate_matrix.Location = new System.Drawing.Point(12, 42);
            this.button_Generate_matrix.Name = "button_Generate_matrix";
            this.button_Generate_matrix.Size = new System.Drawing.Size(131, 23);
            this.button_Generate_matrix.TabIndex = 0;
            this.button_Generate_matrix.Text = "Generate matrix";
            this.button_Generate_matrix.UseVisualStyleBackColor = true;
            this.button_Generate_matrix.Click += new System.EventHandler(this.button_Generate_matrix_Click);
            // 
            // button_Load_matrix_ff
            // 
            this.button_Load_matrix_ff.Location = new System.Drawing.Point(12, 13);
            this.button_Load_matrix_ff.Name = "button_Load_matrix_ff";
            this.button_Load_matrix_ff.Size = new System.Drawing.Size(131, 23);
            this.button_Load_matrix_ff.TabIndex = 1;
            this.button_Load_matrix_ff.Text = "Load matrix from file";
            this.button_Load_matrix_ff.UseVisualStyleBackColor = true;
            this.button_Load_matrix_ff.Click += new System.EventHandler(this.button_Load_matrix_ff_Click);
            // 
            // textBox_matrix
            // 
            this.textBox_matrix.Location = new System.Drawing.Point(149, 13);
            this.textBox_matrix.Multiline = true;
            this.textBox_matrix.Name = "textBox_matrix";
            this.textBox_matrix.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_matrix.Size = new System.Drawing.Size(352, 315);
            this.textBox_matrix.TabIndex = 2;
            this.textBox_matrix.WordWrap = false;
            // 
            // button_Update_matrix_tbox
            // 
            this.button_Update_matrix_tbox.Location = new System.Drawing.Point(370, 334);
            this.button_Update_matrix_tbox.Name = "button_Update_matrix_tbox";
            this.button_Update_matrix_tbox.Size = new System.Drawing.Size(131, 23);
            this.button_Update_matrix_tbox.TabIndex = 3;
            this.button_Update_matrix_tbox.Text = "Save changes";
            this.button_Update_matrix_tbox.UseVisualStyleBackColor = true;
            this.button_Update_matrix_tbox.Click += new System.EventHandler(this.button_Update_matrix_tbox_Click);
            // 
            // button_Run_tabu
            // 
            this.button_Run_tabu.Location = new System.Drawing.Point(168, 468);
            this.button_Run_tabu.Name = "button_Run_tabu";
            this.button_Run_tabu.Size = new System.Drawing.Size(164, 47);
            this.button_Run_tabu.TabIndex = 4;
            this.button_Run_tabu.Text = "Run Tabu Search";
            this.button_Run_tabu.UseVisualStyleBackColor = true;
            this.button_Run_tabu.Click += new System.EventHandler(this.button_Run_tabu_Click);
            // 
            // button_Save_matrix_to_file
            // 
            this.button_Save_matrix_to_file.Location = new System.Drawing.Point(233, 334);
            this.button_Save_matrix_to_file.Name = "button_Save_matrix_to_file";
            this.button_Save_matrix_to_file.Size = new System.Drawing.Size(131, 23);
            this.button_Save_matrix_to_file.TabIndex = 5;
            this.button_Save_matrix_to_file.Text = "Save matrix to file";
            this.button_Save_matrix_to_file.UseVisualStyleBackColor = true;
            this.button_Save_matrix_to_file.Click += new System.EventHandler(this.button_Save_matrix_to_file_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 527);
            this.Controls.Add(this.button_Save_matrix_to_file);
            this.Controls.Add(this.button_Run_tabu);
            this.Controls.Add(this.button_Update_matrix_tbox);
            this.Controls.Add(this.textBox_matrix);
            this.Controls.Add(this.button_Load_matrix_ff);
            this.Controls.Add(this.button_Generate_matrix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Consecutive Ones - Metaheuristic";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Generate_matrix;
        private System.Windows.Forms.Button button_Load_matrix_ff;
        private System.Windows.Forms.TextBox textBox_matrix;
        private System.Windows.Forms.Button button_Update_matrix_tbox;
        private System.Windows.Forms.Button button_Run_tabu;
        private System.Windows.Forms.Button button_Save_matrix_to_file;
    }
}

