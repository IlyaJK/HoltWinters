namespace HoltWintersUI.Page
{
    partial class StepSecond
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
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Korni = new System.Windows.Forms.RichTextBox();
            this.richTextBox_SystYp = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox5.Location = new System.Drawing.Point(60, 326);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.Size = new System.Drawing.Size(322, 171);
            this.richTextBox5.TabIndex = 13;
            this.richTextBox5.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox4.Location = new System.Drawing.Point(60, 254);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(287, 53);
            this.richTextBox4.TabIndex = 12;
            this.richTextBox4.Text = "Оценки начальных значений коэффициентов сезонности ";
            // 
            // richTextBox_Korni
            // 
            this.richTextBox_Korni.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_Korni.Location = new System.Drawing.Point(645, 138);
            this.richTextBox_Korni.Name = "richTextBox_Korni";
            this.richTextBox_Korni.ReadOnly = true;
            this.richTextBox_Korni.Size = new System.Drawing.Size(272, 110);
            this.richTextBox_Korni.TabIndex = 11;
            this.richTextBox_Korni.Text = "";
            // 
            // richTextBox_SystYp
            // 
            this.richTextBox_SystYp.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_SystYp.Location = new System.Drawing.Point(60, 138);
            this.richTextBox_SystYp.Name = "richTextBox_SystYp";
            this.richTextBox_SystYp.ReadOnly = true;
            this.richTextBox_SystYp.Size = new System.Drawing.Size(322, 110);
            this.richTextBox_SystYp.TabIndex = 10;
            this.richTextBox_SystYp.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox3.Location = new System.Drawing.Point(645, 56);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(272, 56);
            this.richTextBox3.TabIndex = 9;
            this.richTextBox3.Text = "По правилу Крамера имеем следующие корни:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.Location = new System.Drawing.Point(60, 54);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(322, 58);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "Система нормальных уравнений примет вид:";
            // 
            // StepSecond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox_Korni);
            this.Controls.Add(this.richTextBox_SystYp);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Name = "StepSecond";
            this.Size = new System.Drawing.Size(1221, 536);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox_Korni;
        private System.Windows.Forms.RichTextBox richTextBox_SystYp;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}
