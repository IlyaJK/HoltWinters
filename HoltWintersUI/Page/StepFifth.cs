using System.Windows.Forms;
using HoltWintersController.PageController.StepFiveController;
using HoltWintersController.PageController.StepFourController;

namespace HoltWintersUI.Page
{
    public partial class StepFifth : UserControl
    {

      

        private readonly IStepFiveController _stepFiveController;
        public StepFifth() : this (new StepFiveController()) { }
        public StepFifth(IStepFiveController stepFiveController)
        {
            InitializeComponent();
            _stepFiveController = stepFiveController;
            PrintData(_stepFiveController);
            PrintE(_stepFiveController);
            PrintPovTochki(_stepFiveController);
            PrintYMinusYtDivy(_stepFiveController);
            PrintSqrE(_stepFiveController);
            PrintEtMinusEt_1(_stepFiveController);
            PrintSqrEtMinusEt_1(_stepFiveController);
            PrintEtMultEt_1(_stepFiveController);
        }

        private void PrintData(IStepFiveController step)
        {
            var data = step.GetData();
            for (int i = 0; i < data.GetLength(1); i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = data[0, i];
                dataGridView1.Rows[i].Cells[1].Value = data[1, i];
            }
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows[data.GetLength(1)+1].Cells[0].Value = step.Sum_t;
            dataGridView1.Rows[data.GetLength(1)+1].Cells[1].Value = step.Sum_y;
        }

        private void PrintEtMinusEt_1(IStepFiveController step)
        {
            var data = step.EtMinusEt_1();
            for (int i = 1; i < data.Length; i++)
            {
                dataGridView1.Rows[i].Cells[6].Value = data[i];
            }
            dataGridView1.Rows[data.GetLength(0) + 1].Cells[6].Value = step.Sum_EtMinusEt_1;
        }

        private void PrintSqrEtMinusEt_1(IStepFiveController step)
        {
            var data = step.SqrEtMinusEt_1();
            for (int i = 1; i < data.Length; i++)
            {
                dataGridView1.Rows[i].Cells[7].Value = data[i];
            }
            dataGridView1.Rows[data.GetLength(0) + 1].Cells[7].Value = step.Sum_SqrEtMinusEt_1;
        }

        private void PrintEtMultEt_1(IStepFiveController step)
        {
            var data = step.EtMultEt_1();
            for (int i = 1; i < data.Length; i++)
            {
                dataGridView1.Rows[i].Cells[8].Value = data[i];
            }
            dataGridView1.Rows[data.GetLength(0) + 1].Cells[8].Value = step.Sum_EtMultEt_1;
        }

        private void PrintE(IStepFiveController step)
        {
            var data = step.E();
            for (int i = 0; i < data.Length; i++)
            {
                dataGridView1.Rows[i].Cells[2].Value = data[i];
            }
            dataGridView1.Rows[data.GetLength(0) + 1].Cells[2].Value = step.Sum_E;
        }

        private void PrintSqrE(IStepFiveController step)
        {
            var data = step.SqrE();
            for (int i = 0; i < data.Length; i++)
            {
                dataGridView1.Rows[i].Cells[5].Value = data[i];
            }
            dataGridView1.Rows[data.GetLength(0) + 1].Cells[5].Value = step.Sum_sqrE;
        }

        private void PrintYMinusYtDivy(IStepFiveController step)
        {
            var data = step.YMinusYtDivy();
            for (int i = 0; i < data.Length; i++)
            {
                dataGridView1.Rows[i].Cells[4].Value = data[i];
            }
            dataGridView1.Rows[data.GetLength(0) + 1].Cells[4].Value = step.Sum_YMinusYtDivy;
        }

        private void PrintPovTochki(IStepFiveController step)
        {
            var data = step.PovTochki();
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == -1) continue;
                dataGridView1.Rows[i].Cells[3].Value = data[i];
            }
            dataGridView1.Rows[data.GetLength(0) + 1].Cells[3].Value = step.Sum_povToch;
        }
    }
}
