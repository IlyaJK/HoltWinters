using System.Windows.Forms;
using HoltWintersController.PageController.StepFourController;

namespace HoltWintersUI.Page
{
    public partial class StepFourth : UserControl
    {

        private readonly IStepFourController _stepFourController;

        public StepFourth() : this(new StepFourController()) { }
        public StepFourth(IStepFourController stepFourController)
        {
            InitializeComponent();
            _stepFourController = stepFourController;
            DrawGraphicY();
            DrawGraphicYt();
        }

        private void DrawGraphicYt()
        {
            var y = _stepFourController.GetY();
            for (double i = 1; i <= y.Length; i++)
            {
                chart1.Series[0].Points.AddXY(i, y[(int)(i-1)]);
                chart1.Series[1].Points.AddXY(i, y[(int)(i-1)]);
            }
        }

        private void DrawGraphicY()
        {
            var y = _stepFourController.GetYt();
            for (double i = 1; i <= y.Length; i++)
            {
                chart1.Series[2].Points.AddXY(i, y[(int)(i - 1)]);
                chart1.Series[3].Points.AddXY(i, y[(int)(i - 1)]);
            }
        }
    }
}
