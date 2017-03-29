namespace HoltWintersUI.Page
{
    partial class StepFourth
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
            this.richTextBox10 = new System.Windows.Forms.RichTextBox();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.NextBT3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox10
            // 
            this.richTextBox10.Location = new System.Drawing.Point(409, 63);
            this.richTextBox10.Name = "richTextBox10";
            this.richTextBox10.Size = new System.Drawing.Size(461, 206);
            this.richTextBox10.TabIndex = 7;
            this.richTextBox10.Text = "";
            // 
            // richTextBox9
            // 
            this.richTextBox9.Location = new System.Drawing.Point(119, 173);
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.Size = new System.Drawing.Size(137, 96);
            this.richTextBox9.TabIndex = 6;
            this.richTextBox9.Text = "";
            // 
            // richTextBox8
            // 
            this.richTextBox8.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox8.Location = new System.Drawing.Point(119, 63);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.ReadOnly = true;
            this.richTextBox8.Size = new System.Drawing.Size(137, 65);
            this.richTextBox8.TabIndex = 5;
            this.richTextBox8.Text = "Параметры сглаживания";
            // 
            // NextBT3
            // 
            this.NextBT3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextBT3.Location = new System.Drawing.Point(827, 401);
            this.NextBT3.Name = "NextBT3";
            this.NextBT3.Size = new System.Drawing.Size(143, 49);
            this.NextBT3.TabIndex = 4;
            this.NextBT3.Text = "Дальше";
            this.NextBT3.UseVisualStyleBackColor = true;
            // 
            // StepFourth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox10);
            this.Controls.Add(this.richTextBox9);
            this.Controls.Add(this.richTextBox8);
            this.Controls.Add(this.NextBT3);
            this.Name = "StepFourth";
            this.Size = new System.Drawing.Size(1178, 528);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox10;
        private System.Windows.Forms.RichTextBox richTextBox9;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.Button NextBT3;
    }
}
