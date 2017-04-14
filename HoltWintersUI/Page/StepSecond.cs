using System.Windows.Forms;
using HoltWintersController.PageController;
using HoltWintersController.PageController.StepSecondController;

namespace HoltWintersUI.Page
{
    public partial class StepSecond : UserControl
    {
        private readonly IStepSecondController _stepSecondController;

        public StepSecond() : this(new StepSecondController()){ }

        public StepSecond(IStepSecondController stepSecondController)
        {
            InitializeComponent();
            _stepSecondController = stepSecondController;
            richTextBox_SystYp.Text = _stepSecondController.GetNormalSystemString();
            richTextBox_Korni.Text = _stepSecondController.GetKorniString();
            richTextBoxKSeason.Text = _stepSecondController.GetYpString();
        }
    }
}
