using System;
using HoltWintersController.PageController;

namespace HoltWintersUI.Page
{
    public partial class StepOne : StepPage
    {
        private readonly IStepOneController _controller;

        public StepOne(IStepOneController container)
        {
            _controller = container;
            СalculationDGV.AllowUserToAddRows = false;
            SourceDataDGV.AllowUserToAddRows = false;
        }

        public override void Clear()
        {
            _controller.Clear();
            SourceDataDGV.Rows.Clear();
            СalculationDGV.Rows.Clear();
        }

        public override void StepLoad()
        {
            InitializeComponent();
        }
    }
}
