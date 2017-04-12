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
            InitializeComponent();
            _controller = container;
            СalculationDGV.AllowUserToAddRows = false;
            SourceDataDGV.AllowUserToAddRows = false;
        }
    }
}
