﻿namespace HoltWintersUI.Page
{
    partial class StepThird
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_3 = new System.Windows.Forms.DataGridView();
            this.textBox_alpha1 = new System.Windows.Forms.TextBox();
            this.textBox_alpha2 = new System.Windows.Forms.TextBox();
            this.textBox_alpha3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Column_t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_yp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_bt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Ft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Yt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_3
            // 
            this.dataGridView_3.AllowUserToAddRows = false;
            this.dataGridView_3.AllowUserToDeleteRows = false;
            this.dataGridView_3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_t,
            this.Column_y,
            this.Column_yp,
            this.Column_F,
            this.Column_at,
            this.Column_bt,
            this.Column_Ft,
            this.Column_Yt});
            this.dataGridView_3.Location = new System.Drawing.Point(66, 104);
            this.dataGridView_3.Name = "dataGridView_3";
            this.dataGridView_3.ReadOnly = true;
            this.dataGridView_3.Size = new System.Drawing.Size(845, 379);
            this.dataGridView_3.TabIndex = 0;
            // 
            // textBox_alpha1
            // 
            this.textBox_alpha1.Location = new System.Drawing.Point(50, 19);
            this.textBox_alpha1.Name = "textBox_alpha1";
            this.textBox_alpha1.Size = new System.Drawing.Size(102, 20);
            this.textBox_alpha1.TabIndex = 1;
            this.textBox_alpha1.Text = "0,2";
            // 
            // textBox_alpha2
            // 
            this.textBox_alpha2.Location = new System.Drawing.Point(216, 19);
            this.textBox_alpha2.Name = "textBox_alpha2";
            this.textBox_alpha2.Size = new System.Drawing.Size(102, 20);
            this.textBox_alpha2.TabIndex = 2;
            this.textBox_alpha2.Text = "0,1";
            // 
            // textBox_alpha3
            // 
            this.textBox_alpha3.Location = new System.Drawing.Point(393, 19);
            this.textBox_alpha3.Name = "textBox_alpha3";
            this.textBox_alpha3.Size = new System.Drawing.Size(102, 20);
            this.textBox_alpha3.TabIndex = 3;
            this.textBox_alpha3.Text = "0,9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "α_1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "α_2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "α_3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_alpha1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_alpha3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_alpha2);
            this.groupBox1.Location = new System.Drawing.Point(181, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 65);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры сглаживания";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(771, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Пересчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column_t
            // 
            this.Column_t.HeaderText = "t";
            this.Column_t.Name = "Column_t";
            this.Column_t.ReadOnly = true;
            // 
            // Column_y
            // 
            this.Column_y.HeaderText = "y(t)";
            this.Column_y.Name = "Column_y";
            this.Column_y.ReadOnly = true;
            // 
            // Column_yp
            // 
            this.Column_yp.HeaderText = "yрасч";
            this.Column_yp.Name = "Column_yp";
            this.Column_yp.ReadOnly = true;
            // 
            // Column_F
            // 
            this.Column_F.HeaderText = "F (оценки)";
            this.Column_F.Name = "Column_F";
            this.Column_F.ReadOnly = true;
            // 
            // Column_at
            // 
            this.Column_at.HeaderText = "at";
            this.Column_at.Name = "Column_at";
            this.Column_at.ReadOnly = true;
            // 
            // Column_bt
            // 
            this.Column_bt.HeaderText = "bt";
            this.Column_bt.Name = "Column_bt";
            this.Column_bt.ReadOnly = true;
            // 
            // Column_Ft
            // 
            this.Column_Ft.HeaderText = "Ft";
            this.Column_Ft.Name = "Column_Ft";
            this.Column_Ft.ReadOnly = true;
            // 
            // Column_Yt
            // 
            this.Column_Yt.HeaderText = "Y(t)";
            this.Column_Yt.Name = "Column_Yt";
            this.Column_Yt.ReadOnly = true;
            // 
            // StepThird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_3);
            this.Name = "StepThird";
            this.Size = new System.Drawing.Size(1152, 536);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_3;
        private System.Windows.Forms.TextBox textBox_alpha1;
        private System.Windows.Forms.TextBox textBox_alpha2;
        private System.Windows.Forms.TextBox textBox_alpha3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_t;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_yp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_F;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_bt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Ft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Yt;
    }
}
