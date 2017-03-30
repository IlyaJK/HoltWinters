using System;
using System.Windows.Forms;
using HoltWintersController.PageController;

namespace HoltWintersUI.Page
{
    public partial class StepOne : UserControl
    {
        private readonly IStepOneController _controller;

        public StepOne(IStepOneController container)
        {
            _controller = container;
            InitializeComponent();
            СalculationDGV.AllowUserToAddRows = false;
            SourceDataDGV.AllowUserToAddRows = false;
            Clear();
        }

        private void OpenClick(object sender, EventArgs e)
        {
            Clear();
        }

        private void ClearClick(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            _controller.Clear();
            SourceDataDGV.Rows.Clear();
            СalculationDGV.Rows.Clear();
            NextBT.Enabled = false;
        }
    }
}
