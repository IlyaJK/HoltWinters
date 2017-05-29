using System.Windows.Forms;
using HoltWintersController.PageController.StepEightController;

namespace HoltWintersUI.Page
{
    public partial class StepEighth : UserControl
    {

        private readonly IStepEightController _stepEightController;

        public StepEighth() : this(new StepEightController()) { }

        public StepEighth(IStepEightController stepEightController)
        {
            InitializeComponent();

            _stepEightController = stepEightController;
            DrawGraphicY(_stepEightController.Get_y());
            DrawGraphicYtPrognoz(_stepEightController.GetYtPrognoz());
            
        }



        private void DrawGraphicYtPrognoz(double[] y)
        {
      
            for (double i = 1; i <= y.Length; i++)
            {
                chart1.Series[2].Points.AddXY(i, y[(int)(i - 1)]);
                chart1.Series[3].Points.AddXY(i, y[(int)(i - 1)]);
            }
        }

        private void DrawGraphicY(double[] yt_prognoz)
        {
            
            for (double i = 1; i <= yt_prognoz.Length; i++)
            {
                chart1.Series[0].Points.AddXY(i, yt_prognoz[(int)(i - 1)]);
                chart1.Series[1].Points.AddXY(i, yt_prognoz[(int)(i - 1)]);
            }
        }

    }
}
