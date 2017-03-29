namespace HoltWintersUI
{
    partial class StepSixth
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
            this.richTextBox12 = new System.Windows.Forms.RichTextBox();
            this.NextBT5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox12
            // 
            this.richTextBox12.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox12.Location = new System.Drawing.Point(132, 52);
            this.richTextBox12.Name = "richTextBox12";
            this.richTextBox12.ReadOnly = true;
            this.richTextBox12.Size = new System.Drawing.Size(255, 81);
            this.richTextBox12.TabIndex = 4;
            this.richTextBox12.Text = "График исходных данных (ряд 1) и расчетных значений (ряд 2)";
            // 
            // NextBT5
            // 
            this.NextBT5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextBT5.Location = new System.Drawing.Point(881, 405);
            this.NextBT5.Name = "NextBT5";
            this.NextBT5.Size = new System.Drawing.Size(143, 49);
            this.NextBT5.TabIndex = 3;
            this.NextBT5.Text = "Дальше";
            this.NextBT5.UseVisualStyleBackColor = true;
            // 
            // StepSixth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox12);
            this.Controls.Add(this.NextBT5);
            this.Name = "StepSixth";
            this.Size = new System.Drawing.Size(1205, 517);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox12;
        private System.Windows.Forms.Button NextBT5;
    }
}
