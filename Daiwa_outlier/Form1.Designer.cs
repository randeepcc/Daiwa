namespace Daiwa_outlier
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_first_Calc = new System.Windows.Forms.Label();
            this.txt_formula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_history = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "test";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(412, 22);
            this.textBox1.TabIndex = 1;
            // 
            // dGrid
            // 
            this.dGrid.AllowUserToAddRows = false;
            this.dGrid.AllowUserToDeleteRows = false;
            this.dGrid.AllowUserToOrderColumns = true;
            this.dGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid.GridColor = System.Drawing.Color.Ivory;
            this.dGrid.Location = new System.Drawing.Point(26, 77);
            this.dGrid.Name = "dGrid";
            this.dGrid.ReadOnly = true;
            this.dGrid.RowTemplate.Height = 24;
            this.dGrid.Size = new System.Drawing.Size(360, 341);
            this.dGrid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "File";
            // 
            // lbl_first_Calc
            // 
            this.lbl_first_Calc.AutoSize = true;
            this.lbl_first_Calc.Location = new System.Drawing.Point(435, 77);
            this.lbl_first_Calc.Name = "lbl_first_Calc";
            this.lbl_first_Calc.Size = new System.Drawing.Size(228, 17);
            this.lbl_first_Calc.TabIndex = 4;
            this.lbl_first_Calc.Text = "Calculation using Standard formula";
            // 
            // txt_formula
            // 
            this.txt_formula.Location = new System.Drawing.Point(563, 115);
            this.txt_formula.Name = "txt_formula";
            this.txt_formula.ReadOnly = true;
            this.txt_formula.Size = new System.Drawing.Size(100, 22);
            this.txt_formula.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Outlier value";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Remove outlier and reload data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(438, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(253, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Remove outlier and reload data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Outlier value";
            // 
            // txt_history
            // 
            this.txt_history.Location = new System.Drawing.Point(563, 264);
            this.txt_history.Name = "txt_history";
            this.txt_history.ReadOnly = true;
            this.txt_history.Size = new System.Drawing.Size(100, 22);
            this.txt_history.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Calculation using historical record";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_history);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_formula);
            this.Controls.Add(this.lbl_first_Calc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGrid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Daiwa Outlier application";
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_first_Calc;
        private System.Windows.Forms.TextBox txt_formula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_history;
        private System.Windows.Forms.Label label4;
    }
}

