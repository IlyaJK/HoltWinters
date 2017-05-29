using System.Windows.Forms;
using HoltWintersController.PageController.StepSixController;

namespace HoltWintersUI.Page
{
    public partial class StepSixth : UserControl
    {
        private readonly IStepSixController _stepSixController;

        private string _kritdarbinUotson = "Критерий Дарбина-Уотсона\n";
        private string _rsKrit = "\n\nRS - критерий\n";
        private string _srErrorAproks = "Средняя ошибка аппроксимации\n";



        public StepSixth() : this(new StepSixController()) { }

        public StepSixth(IStepSixController stepSixController)
        {
            InitializeComponent();
            _stepSixController = stepSixController;
            string coeff = null;
            _stepSixController.Solve_d(ref coeff);
            PrintCoeff_d(coeff);

            PrintCoeff_RS(_stepSixController.Get_Emax_Emin(), _stepSixController.Solve_Se(), _stepSixController.Solve_RS());
            PrintSrErrorAproks(_stepSixController.Solve_srErrorAproks());
        }

        private void PrintCoeff_d(string coeff)
        {
            richTextBox_Kriterii.Text = _kritdarbinUotson;
            richTextBox_Kriterii.Text += "d = " + coeff;
        }
        private void PrintCoeff_RS(double[] coeffmax_min, double coeffSE, double coeffRS)
        {
            richTextBox_Kriterii.Text += _rsKrit;
            richTextBox_Kriterii.Text += "Emax = " + coeffmax_min[0].ToString() + "\nEmin = " + coeffmax_min[1].ToString()+"\n";
            richTextBox_Kriterii.Text += "Se = " + coeffSE.ToString() + "\n";
            richTextBox_Kriterii.Text += "Rs = " + coeffRS.ToString();
        }

        private void PrintSrErrorAproks(double srErrorAproks)
        {
            richTextBox_SrErApr.Text = _srErrorAproks + "A = " + srErrorAproks.ToString()+"%";
        }
    }
}
