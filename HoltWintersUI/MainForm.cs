using System;
using System.Windows.Forms;

namespace HoltWintersUI
{
    public partial class MainForm : Form
    {
        private int _step;

        public MainForm()
        {
            InitializeComponent();
            _step = 0;
        }

        private void NextBT_Click(object sender, EventArgs e)
        {
            NextStep();
        }

        private void NextStep()
        {
            var stepPage = StepFactory.GetStap(_step + 1);
            if (stepPage == null) return;
            _step++;
            var tabPage = new TabPage("Шаг" + _step);
            tabPage.Controls.Add(stepPage);
            StepTC.TabPages.Add(tabPage);
        }

    }
}