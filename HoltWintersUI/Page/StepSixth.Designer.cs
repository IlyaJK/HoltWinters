namespace HoltWintersUI.Page
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
            this.richTextBox_Kriterii = new System.Windows.Forms.RichTextBox();
            this.richTextBox_SrErApr = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox_Kriterii
            // 
            this.richTextBox_Kriterii.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_Kriterii.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.richTextBox_Kriterii.Location = new System.Drawing.Point(119, 26);
            this.richTextBox_Kriterii.Name = "richTextBox_Kriterii";
            this.richTextBox_Kriterii.ReadOnly = true;
            this.richTextBox_Kriterii.Size = new System.Drawing.Size(612, 217);
            this.richTextBox_Kriterii.TabIndex = 1;
            this.richTextBox_Kriterii.Text = "";
            // 
            // richTextBox_SrErApr
            // 
            this.richTextBox_SrErApr.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_SrErApr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.richTextBox_SrErApr.Location = new System.Drawing.Point(119, 279);
            this.richTextBox_SrErApr.Name = "richTextBox_SrErApr";
            this.richTextBox_SrErApr.ReadOnly = true;
            this.richTextBox_SrErApr.Size = new System.Drawing.Size(612, 89);
            this.richTextBox_SrErApr.TabIndex = 2;
            this.richTextBox_SrErApr.Text = "";
            // 
            // StepSixth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox_SrErApr);
            this.Controls.Add(this.richTextBox_Kriterii);
            this.Name = "StepSixth";
            this.Size = new System.Drawing.Size(1205, 517);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox_Kriterii;
        private System.Windows.Forms.RichTextBox richTextBox_SrErApr;
    }
}
