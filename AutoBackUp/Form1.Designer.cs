
namespace AutoBackUp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.BackUpFolders = new System.Windows.Forms.DataGridView();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackUpPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBarElems = new System.Windows.Forms.ProgressBar();
            this.progressBarCountRows = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BackUpFolders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Копировать вручную";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BackUpFolders
            // 
            this.BackUpFolders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BackUpFolders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Source,
            this.BackUpPath});
            this.BackUpFolders.Location = new System.Drawing.Point(24, 27);
            this.BackUpFolders.Name = "BackUpFolders";
            this.BackUpFolders.RowTemplate.Height = 25;
            this.BackUpFolders.Size = new System.Drawing.Size(861, 150);
            this.BackUpFolders.TabIndex = 1;
            // 
            // Source
            // 
            this.Source.HeaderText = "Source";
            this.Source.Name = "Source";
            this.Source.Width = 400;
            // 
            // BackUpPath
            // 
            this.BackUpPath.HeaderText = "BackUpPath";
            this.BackUpPath.Name = "BackUpPath";
            this.BackUpPath.Width = 400;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Каталоги для резервного копирования";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Применить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "В какое время сделать backup?";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(625, 256);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 23);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(705, 256);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(55, 23);
            this.numericUpDown2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = ":";
            // 
            // progressBarElems
            // 
            this.progressBarElems.Location = new System.Drawing.Point(745, 337);
            this.progressBarElems.Name = "progressBarElems";
            this.progressBarElems.Size = new System.Drawing.Size(163, 23);
            this.progressBarElems.TabIndex = 11;
            // 
            // progressBarCountRows
            // 
            this.progressBarCountRows.Location = new System.Drawing.Point(745, 299);
            this.progressBarCountRows.Name = "progressBarCountRows";
            this.progressBarCountRows.Size = new System.Drawing.Size(163, 23);
            this.progressBarCountRows.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 395);
            this.Controls.Add(this.progressBarCountRows);
            this.Controls.Add(this.progressBarElems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackUpFolders);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackUpFolders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView BackUpFolders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn BackUpPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBarElems;
        private System.Windows.Forms.ProgressBar progressBarCountRows;
        private System.Windows.Forms.Timer timer2;
    }
}

