
namespace ConsecutiveOnes
{
    partial class GeneratorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Generate_data = new System.Windows.Forms.Button();
            this.label_no_ones = new System.Windows.Forms.Label();
            this.numericUpDown_columns = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_rows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_ones_percentage = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_no_errors = new System.Windows.Forms.NumericUpDown();
            this.label_no_errors = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_columns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ones_percentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_no_errors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "columns:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "rows:";
            // 
            // button_Generate_data
            // 
            this.button_Generate_data.Location = new System.Drawing.Point(142, 188);
            this.button_Generate_data.Name = "button_Generate_data";
            this.button_Generate_data.Size = new System.Drawing.Size(75, 23);
            this.button_Generate_data.TabIndex = 4;
            this.button_Generate_data.Text = "Generate";
            this.button_Generate_data.UseVisualStyleBackColor = true;
            this.button_Generate_data.Click += new System.EventHandler(this.button_Generate_data_Click);
            // 
            // label_no_ones
            // 
            this.label_no_ones.Location = new System.Drawing.Point(20, 76);
            this.label_no_ones.Name = "label_no_ones";
            this.label_no_ones.Size = new System.Drawing.Size(181, 21);
            this.label_no_ones.TabIndex = 5;
            this.label_no_ones.Text = "ones percentage in rows (1-100):";
            // 
            // numericUpDown_columns
            // 
            this.numericUpDown_columns.Location = new System.Drawing.Point(205, 15);
            this.numericUpDown_columns.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown_columns.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_columns.Name = "numericUpDown_columns";
            this.numericUpDown_columns.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_columns.TabIndex = 6;
            this.numericUpDown_columns.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDown_rows
            // 
            this.numericUpDown_rows.Location = new System.Drawing.Point(205, 45);
            this.numericUpDown_rows.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown_rows.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_rows.Name = "numericUpDown_rows";
            this.numericUpDown_rows.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_rows.TabIndex = 7;
            this.numericUpDown_rows.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDown_ones_percentage
            // 
            this.numericUpDown_ones_percentage.Location = new System.Drawing.Point(205, 75);
            this.numericUpDown_ones_percentage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ones_percentage.Name = "numericUpDown_ones_percentage";
            this.numericUpDown_ones_percentage.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_ones_percentage.TabIndex = 8;
            this.numericUpDown_ones_percentage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_no_errors
            // 
            this.numericUpDown_no_errors.Location = new System.Drawing.Point(205, 105);
            this.numericUpDown_no_errors.Name = "numericUpDown_no_errors";
            this.numericUpDown_no_errors.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_no_errors.TabIndex = 9;
            // 
            // label_no_errors
            // 
            this.label_no_errors.AutoSize = true;
            this.label_no_errors.Location = new System.Drawing.Point(99, 107);
            this.label_no_errors.Name = "label_no_errors";
            this.label_no_errors.Size = new System.Drawing.Size(99, 15);
            this.label_no_errors.TabIndex = 10;
            this.label_no_errors.Text = "number of errors:";
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 223);
            this.Controls.Add(this.label_no_errors);
            this.Controls.Add(this.numericUpDown_no_errors);
            this.Controls.Add(this.numericUpDown_ones_percentage);
            this.Controls.Add(this.numericUpDown_rows);
            this.Controls.Add(this.numericUpDown_columns);
            this.Controls.Add(this.label_no_ones);
            this.Controls.Add(this.button_Generate_data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GeneratorForm";
            this.Text = "Matrix generator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_columns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ones_percentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_no_errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Generate_data;
        private System.Windows.Forms.Label label_no_ones;
        private System.Windows.Forms.NumericUpDown numericUpDown_columns;
        private System.Windows.Forms.NumericUpDown numericUpDown_rows;
        private System.Windows.Forms.NumericUpDown numericUpDown_ones_percentage;
        private System.Windows.Forms.NumericUpDown numericUpDown_no_errors;
        private System.Windows.Forms.Label label_no_errors;
    }
}