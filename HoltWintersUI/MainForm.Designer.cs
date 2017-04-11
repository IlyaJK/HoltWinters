namespace HoltWintersUI
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StepTC = new System.Windows.Forms.TabControl();
            this.NextBT = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jnrhsnmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StepTC
            // 
            this.StepTC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StepTC.ItemSize = new System.Drawing.Size(42, 18);
            this.StepTC.Location = new System.Drawing.Point(-1, 27);
            this.StepTC.Name = "StepTC";
            this.StepTC.SelectedIndex = 0;
            this.StepTC.Size = new System.Drawing.Size(1046, 473);
            this.StepTC.TabIndex = 0;
            // 
            // NextBT
            // 
            this.NextBT.Enabled = false;
            this.NextBT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextBT.Location = new System.Drawing.Point(1061, 395);
            this.NextBT.Name = "NextBT";
            this.NextBT.Size = new System.Drawing.Size(143, 49);
            this.NextBT.TabIndex = 4;
            this.NextBT.Text = "Дальше";
            this.NextBT.UseVisualStyleBackColor = true;
            this.NextBT.Click += new System.EventHandler(this.NextBT_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jnrhsnmToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1216, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jnrhsnmToolStripMenuItem
            // 
            this.jnrhsnmToolStripMenuItem.Name = "jnrhsnmToolStripMenuItem";
            this.jnrhsnmToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.jnrhsnmToolStripMenuItem.Text = "Открыть";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 497);
            this.Controls.Add(this.StepTC);
            this.Controls.Add(this.NextBT);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Holt-Winters";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl StepTC;
        private System.Windows.Forms.Button NextBT;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jnrhsnmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
    }
}

