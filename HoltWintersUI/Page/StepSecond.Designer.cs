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
            this.richTextBoxKSeason = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Korni = new System.Windows.Forms.RichTextBox();
            this.richTextBox_SystYp = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_CoeffSezon = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxKSeason
            // 
            this.richTextBoxKSeason.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxKSeason.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.richTextBoxKSeason.Location = new System.Drawing.Point(73, 251);
            this.richTextBoxKSeason.Name = "richTextBoxKSeason";
            this.richTextBoxKSeason.ReadOnly = true;
            this.richTextBoxKSeason.Size = new System.Drawing.Size(322, 162);
            this.richTextBoxKSeason.TabIndex = 13;
            this.richTextBoxKSeason.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox4.Location = new System.Drawing.Point(73, 192);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(322, 53);
            this.richTextBox4.TabIndex = 12;
            this.richTextBox4.Text = "Оценки начальных значений коэффициентов сезонности ";
            // 
            // richTextBox_Korni
            // 
            this.richTextBox_Korni.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_Korni.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.richTextBox_Korni.Location = new System.Drawing.Point(623, 102);
            this.richTextBox_Korni.Name = "richTextBox_Korni";
            this.richTextBox_Korni.ReadOnly = true;
            this.richTextBox_Korni.Size = new System.Drawing.Size(272, 70);
            this.richTextBox_Korni.TabIndex = 11;
            this.richTextBox_Korni.Text = "";
            // 
            // richTextBox_SystYp
            // 
            this.richTextBox_SystYp.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_SystYp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_SystYp.Location = new System.Drawing.Point(73, 102);
            this.richTextBox_SystYp.Name = "richTextBox_SystYp";
            this.richTextBox_SystYp.ReadOnly = true;
            this.richTextBox_SystYp.Size = new System.Drawing.Size(322, 70);
            this.richTextBox_SystYp.TabIndex = 10;
            this.richTextBox_SystYp.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox3.Location = new System.Drawing.Point(623, 40);
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
            this.richTextBox2.Location = new System.Drawing.Point(73, 38);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(322, 58);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "Система нормальных уравнений примет вид:";
            // 
            // richTextBox7
            // 
            this.richTextBox7.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox7.Location = new System.Drawing.Point(511, 192);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.ReadOnly = true;
            this.richTextBox7.Size = new System.Drawing.Size(495, 87);
            this.richTextBox7.TabIndex = 15;
            this.richTextBox7.Text = "Оценим приближенные значения коэффициентов сезонности F(-3), F(-2), F(-1) и F(0) " +
    "1-4 кварталов для года, предшествующего первому году.";
            // 
            // richTextBox_CoeffSezon
            // 
            this.richTextBox_CoeffSezon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.richTextBox_CoeffSezon.Location = new System.Drawing.Point(551, 285);
            this.richTextBox_CoeffSezon.Name = "richTextBox_CoeffSezon";
            this.richTextBox_CoeffSezon.Size = new System.Drawing.Size(434, 128);
            this.richTextBox_CoeffSezon.TabIndex = 14;
            this.richTextBox_CoeffSezon.Text = "";
            // 
            // StepSecond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox7);
            this.Controls.Add(this.richTextBox_CoeffSezon);
            this.Controls.Add(this.richTextBoxKSeason);
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

        private System.Windows.Forms.RichTextBox richTextBoxKSeason;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox_Korni;
        private System.Windows.Forms.RichTextBox richTextBox_SystYp;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.RichTextBox richTextBox_CoeffSezon;
    }
}
