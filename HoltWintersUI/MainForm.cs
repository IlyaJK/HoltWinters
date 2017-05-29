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
            NextBT.Enabled = false;
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
            StepTC.SelectedTab = tabPage;
        }

        private void Open_Click(object sender, EventArgs e)
        {

            if (!_controller.LoadData()) return;             
            NextStep();
            NextBT.Enabled = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            _controller.Clear();
            NextBT.Enabled = false;
            ClearStep();
        }

        private void ClearStep()
        {
            _step = 0;
            StepTC.TabPages.Clear();
            ChangeCountTabs();
    
        }
    
        public void ChangeCountTabs()
        {
            _step = 3;
            for (int i = StepTC.TabCount; i > 3; i--)
            {
                StepTC.TabPages[i-1].Dispose();
            }
            StepTC.SelectedTab = StepTC.TabPages[2];
        }
    }
}