namespace HoltWintersUI.Page
{
    partial class StepSeventh
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
            this.dataGridView_Prognoz = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox_Rasch = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Prognoz)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Prognoz
            // 
            this.dataGridView_Prognoz.AllowUserToAddRows = false;
            this.dataGridView_Prognoz.AllowUserToDeleteRows = false;
            this.dataGridView_Prognoz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Prognoz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.dataGridView_Prognoz.Location = new System.Drawing.Point(29, 3);
            this.dataGridView_Prognoz.Name = "dataGridView_Prognoz";
            this.dataGridView_Prognoz.ReadOnly = true;
            this.dataGridView_Prognoz.Size = new System.Drawing.Size(343, 463);
            this.dataGridView_Prognoz.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "t";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "y(t)";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Y(t)";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // richTextBox_Rasch
            // 
            this.richTextBox_Rasch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.richTextBox_Rasch.Location = new System.Drawing.Point(434, 3);
            this.richTextBox_Rasch.Name = "richTextBox_Rasch";
            this.richTextBox_Rasch.Size = new System.Drawing.Size(493, 294);
            this.richTextBox_Rasch.TabIndex = 2;
            this.richTextBox_Rasch.Text = "";
            // 
            // StepSeventh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox_Rasch);
            this.Controls.Add(this.dataGridView_Prognoz);
            this.Name = "StepSeventh";
            this.Size = new System.Drawing.Size(1178, 561);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Prognoz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Prognoz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.RichTextBox richTextBox_Rasch;
    }
}
