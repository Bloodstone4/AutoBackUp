
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.BackUpFolders = new System.Windows.Forms.DataGridView();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackUpPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.NumericUpDown();
            this.minutes = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBarElems = new System.Windows.Forms.ProgressBar();
            this.progressBarCountRows = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.BackgroundMode = new System.Windows.Forms.Button();
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BackUpFolders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 335);
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
            this.button2.Location = new System.Drawing.Point(25, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сохранить изменения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "В какое время сделать backup?";
            // 
            // hours
            // 
            this.hours.Location = new System.Drawing.Point(750, 201);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(55, 23);
            this.hours.TabIndex = 7;
            this.hours.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // minutes
            // 
            this.minutes.Location = new System.Drawing.Point(830, 201);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(55, 23);
            this.minutes.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(811, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = ":";
            // 
            // progressBarElems
            // 
            this.progressBarElems.Location = new System.Drawing.Point(722, 295);
            this.progressBarElems.Name = "progressBarElems";
            this.progressBarElems.Size = new System.Drawing.Size(163, 23);
            this.progressBarElems.TabIndex = 11;
            // 
            // progressBarCountRows
            // 
            this.progressBarCountRows.Location = new System.Drawing.Point(722, 257);
            this.progressBarCountRows.Name = "progressBarCountRows";
            this.progressBarCountRows.Size = new System.Drawing.Size(163, 23);
            this.progressBarCountRows.TabIndex = 12;
            // 
            // BackgroundMode
            // 
            this.BackgroundMode.Location = new System.Drawing.Point(697, 342);
            this.BackgroundMode.Name = "BackgroundMode";
            this.BackgroundMode.Size = new System.Drawing.Size(188, 23);
            this.BackgroundMode.TabIndex = 13;
            this.BackgroundMode.Text = "Перевести в фоновый режим";
            this.BackgroundMode.UseVisualStyleBackColor = true;
            this.BackgroundMode.Click += new System.EventHandler(this.BackgroundMode_Click);
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon2.Icon")));
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            this.notifyIcon2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon2_MouseDoubleClick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 377);
            this.Controls.Add(this.BackgroundMode);
            this.Controls.Add(this.progressBarCountRows);
            this.Controls.Add(this.progressBarElems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackUpFolders);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AutoBackUp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackUpFolders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes)).EndInit();
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
        private System.Windows.Forms.NumericUpDown hours;
        private System.Windows.Forms.NumericUpDown minutes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBarElems;
        private System.Windows.Forms.ProgressBar progressBarCountRows;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button BackgroundMode;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
    }
}

