using System;
using System.Windows.Forms;
using HoltWintersController;

namespace HoltWintersUI
{
    public partial class MainForm : Form
    {
        private int _step;
        private readonly IController _controller;

        public MainForm(IController controller)
        {
            InitializeComponent();
            _step = 0;
            _controller = controller;
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

        private void Open_Click(object sender, EventArgs e)
        {
            _controller.LoadData();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            _controller.Clear();
            ClearStep();
        }

        private void ClearStep()
        {
            _step = 0;
            StepTC.TabPages.Clear();
        }
    }
}