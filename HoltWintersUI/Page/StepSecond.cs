using System.Windows.Forms;
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
            var dataKoreal = _stepSecondController.GetKorel();
            _stepSecondController.Kramer(dataKoreal[2, 8], dataKoreal[0, 8], dataKoreal[4, 8], dataKoreal[0, 8], dataKoreal[0, 7], dataKoreal[1, 8]);
            _stepSecondController.SolveYp();
            _stepSecondController.SolveF();
            richTextBox_SystYp.Text = _stepSecondController.GetNormalSystemString();
            richTextBox_Korni.Text = _stepSecondController.GetKorniString();
            richTextBoxKSeason.Text = _stepSecondController.GetYpString();

            richTextBox_CoeffSezon.Text = _stepSecondController.GetFString();






        }
    }
}
