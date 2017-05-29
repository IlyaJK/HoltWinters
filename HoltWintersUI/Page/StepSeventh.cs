using System.Windows.Forms;
using HoltWintersController.PageController.StepSevenController;

namespace HoltWintersUI.Page
{
    public partial class StepSeventh : UserControl
    {
        private readonly IStepSevenController _stepSevenController;

        public StepSeventh() : this(new StepSevenController()) { }

        public StepSeventh(IStepSevenController stepSevenController)
        {
            InitializeComponent();
            _stepSevenController = stepSevenController;
            Print_Prognoz(_stepSevenController.GetData(), _stepSevenController.SolveYt());
            Print_Rasch(_stepSevenController.AnalitYt);
        }

        public void Print_Prognoz(double[,] data_t_y, double[] data_Y)
        {
            for (int i = 0; i < data_t_y.GetLength(1); i++)
            {
                dataGridView_Prognoz.Rows.Add();
                dataGridView_Prognoz.Rows[i].Cells[0].Value = data_t_y[0, i];
                dataGridView_Prognoz.Rows[i].Cells[1].Value = data_t_y[1, i];
            }

            for (int i = 0; i < data_Y.Length; i++)
            {
                if (i < 4) dataGridView_Prognoz.Rows.Add();
                dataGridView_Prognoz.Rows[i].Cells[2].Value = data_Y[i];
            }
        }

        public void Print_Rasch(string coeff)
        {
            richTextBox_Rasch.Text = coeff;
        }

    }
}
