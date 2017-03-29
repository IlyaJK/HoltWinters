﻿namespace HoltWintersUI.Page
{
    partial class StepOne
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.СalculationDGV = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceDataDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClearBT = new System.Windows.Forms.Button();
            this.OpenBT = new System.Windows.Forms.Button();
            this.NextBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.СalculationDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceDataDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(61, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(178, 27);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "Исходные данные";
            // 
            // СalculationDGV
            // 
            this.СalculationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.СalculationDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.СalculationDGV.Location = new System.Drawing.Point(334, 64);
            this.СalculationDGV.Name = "СalculationDGV";
            this.СalculationDGV.Size = new System.Drawing.Size(645, 223);
            this.СalculationDGV.TabIndex = 14;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "i";
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "t";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Y(t)";
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "t^2";
            this.Column6.Name = "Column6";
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Y(t)^2";
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "t*Y(t)";
            this.Column8.Name = "Column8";
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SourceDataDGV
            // 
            this.SourceDataDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SourceDataDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.SourceDataDGV.Location = new System.Drawing.Point(24, 64);
            this.SourceDataDGV.Name = "SourceDataDGV";
            this.SourceDataDGV.Size = new System.Drawing.Size(243, 375);
            this.SourceDataDGV.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "t";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Y(t)";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ClearBT
            // 
            this.ClearBT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearBT.Location = new System.Drawing.Point(334, 367);
            this.ClearBT.Name = "ClearBT";
            this.ClearBT.Size = new System.Drawing.Size(143, 49);
            this.ClearBT.TabIndex = 12;
            this.ClearBT.Text = "Очистить";
            this.ClearBT.UseVisualStyleBackColor = true;
            // 
            // OpenBT
            // 
            this.OpenBT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenBT.Location = new System.Drawing.Point(589, 367);
            this.OpenBT.Name = "OpenBT";
            this.OpenBT.Size = new System.Drawing.Size(143, 49);
            this.OpenBT.TabIndex = 11;
            this.OpenBT.Text = "Обзор";
            this.OpenBT.UseVisualStyleBackColor = true;
            // 
            // NextBT
            // 
            this.NextBT.Enabled = false;
            this.NextBT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextBT.Location = new System.Drawing.Point(836, 367);
            this.NextBT.Name = "NextBT";
            this.NextBT.Size = new System.Drawing.Size(143, 49);
            this.NextBT.TabIndex = 10;
            this.NextBT.Text = "Дальше";
            this.NextBT.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.СalculationDGV);
            this.Controls.Add(this.SourceDataDGV);
            this.Controls.Add(this.ClearBT);
            this.Controls.Add(this.OpenBT);
            this.Controls.Add(this.NextBT);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1014, 456);
            ((System.ComponentModel.ISupportInitialize)(this.СalculationDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceDataDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView СalculationDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridView SourceDataDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button ClearBT;
        private System.Windows.Forms.Button OpenBT;
        private System.Windows.Forms.Button NextBT;
    }
}