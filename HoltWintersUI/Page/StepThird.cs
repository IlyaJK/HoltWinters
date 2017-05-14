using System.Windows.Forms;
using HoltWintersController.PageController.StepThirdController;

namespace HoltWintersUI.Page
{
    public partial class StepThird : UserControl
    {

        private readonly IStepThirdController _stepThirdController;

        public StepThird() : this(new StepThirdController()) { }
        public StepThird(IStepThirdController stepThirdController)
        {
            InitializeComponent();
            _stepThirdController = stepThirdController;
            SolveData3();
            ZapolnTable();

        }


        private void ZapolnTable()
        {
            int count_row = 0;
            double[,] _data = _stepThirdController.GetData();
            int count_column = _data.GetLength(1) / 2;
            double[] data = null;
            for (int i = 0; i < _data.GetLength(1); i++)
            {
                dataGridView_3.Rows.Add();
            }
            for (int i = 0; i < count_column; i++)
            {
                switch (i)
                {
                    case 0:
                        count_row = _data.GetLength(1);
                        break;
                    case 1: count_row = _data.GetLength(1); break;
                    case 2:
                        _data = null;
                        data = _stepThirdController.GetYp();
                        count_row = data.Length;
                        break;
                    case 3:
                        data = _stepThirdController.GetF();
                        count_row = data.Length;
                        break;
                    case 4:
                        data = _stepThirdController.Getat();
                        count_row = data.Length;
                        break;
                    case 5:
                        data = _stepThirdController.Getbt();
                        count_row = data.Length;
                        break;
                    case 6:
                        data = _stepThirdController.GetFt();
                        count_row = data.Length;
                        break;
                    case 7:
                        data = _stepThirdController.GetYt();
                        count_row = data.Length;
                        break;
                    default: break;
                }

                for (int j = 0; j < count_row; j++)
                {
                    if (_data != null)
                    {
                        dataGridView_3.Rows[j].Cells[i].Value = _data[i, j];
                    }
                    else
                    {

                        dataGridView_3.Rows[j].Cells[i].Value = data[j];
                    }

                }
            }
        }

        private void SolveData3()
        {
            double alpha1 = double.Parse(textBox_alpha1.Text.Replace('.', ','));
            double alpha2 = double.Parse(textBox_alpha2.Text.Replace('.', ','));
            double alpha3 = double.Parse(textBox_alpha3.Text.Replace('.', ','));
            var a0 = _stepThirdController.GetKorni()[0];
            var b0 = _stepThirdController.GetKorni()[1];
            var Y = _stepThirdController.GetY();
            var F = _stepThirdController.GetF();
            var at = new double[Y.Length];
            var bt = new double[Y.Length];
            var Ft = new double[Y.Length];
            var Yt = new double[Y.Length];

            for (int j = 0; j < 4; j++)
            {
                if (j == 0)
                {
                    at[j] = alpha1 * Y[j] / F[j] + (1 - alpha1) * (a0 + b0);
                    bt[j] = alpha3 * (at[j] - a0) + (1 - alpha3) * b0;
                }
                else
                {
                    at[j] = alpha1 * Y[j] / F[j] + (1 - alpha1) * (at[j - 1] + bt[j - 1]);
                    bt[j] = alpha3 * (at[j] - at[j - 1]) + (1 - alpha3) * bt[j - 1];
                }
                Ft[j] = alpha2 * Y[j] / at[j] + (1 - alpha2) * F[j];


            }
            for (int i = 4; i < 16; i++)
            {

                at[i] = alpha1 * Y[i] / Ft[i - 4] + (1 - alpha1) * (at[i - 1] + bt[i - 1]);

                bt[i] = alpha3 * (at[i] - at[i - 1]) + (1 - alpha3) * bt[i - 1];

                Ft[i] = alpha2 * Y[i] / at[i] + (1 - alpha2) * Ft[i - 4];

            }

            for (int i = 0; i < 16; i++)
            {
                if (i == 0)
                    Yt[i] = (at[i] + bt[i]) * F[i];
                else if (i == 1)
                    Yt[i] = (at[i-1] + bt[i-1]) * F[i];
                else if (i < 4)
                    Yt[i] = (at[i-1] + bt[i - 1]) * F[i];
                else
                    Yt[i] = (at[i-1] + bt[i - 1]) * Ft[i-4];
            }

            _stepThirdController.Setat(at);
            _stepThirdController.Setbt(bt);
            _stepThirdController.SetFt(Ft);
            _stepThirdController.SetYt(Yt);


        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            SolveData3();
            ZapolnTable();
        }
    }
}
