using System.Windows.Forms;
using HoltWintersController.StepController;

namespace HoltWintersUI.Page
{
    public partial class StepOne : UserControl
    {
        private IStepOneController _controller;

        public StepOne(IStepOneController container)
        {
            _controller = container;
            InitializeComponent();
            СalculationDGV.AllowUserToAddRows = false;
            SourceDataDGV.AllowUserToAddRows = false;
        }
    }
}
