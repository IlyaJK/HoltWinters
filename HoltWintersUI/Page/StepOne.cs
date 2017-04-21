using System;
using System.Windows.Forms;
using HoltWintersController.PageController;

namespace HoltWintersUI.Page
{
    public partial class StepOne : UserControl
    {
        private readonly IStepOneController _stepOneController;

        public StepOne() : this(new StepOneController()){}
        public StepOne(IStepOneController stepOneController)
        {
            InitializeComponent();

            _stepOneController = stepOneController;
            var dataKoreal = _stepOneController.GetDataKorel();
            СalculationDGV.AllowUserToAddRows = false;
            SourceDataDGV.AllowUserToAddRows = false;
            LoadDataGrid();
           

        }

        public void LoadDataGrid()
        {
            var data = _stepOneController.GetStartData();
            var dataKoreal = _stepOneController.GetDataKorel();
            for (var i = 0; i < data.GetLength(1); i++)
            {
                if (i < dataKoreal.GetLength(1))
                {
                    СalculationDGV.Rows.Add();
                    СalculationDGV.Rows[i].Cells[0].Value = i + 1;
                    for (var j = 0; j < dataKoreal.GetLength(0); j++)
                    {
                        СalculationDGV.Rows[i].Cells[j+1].Value = dataKoreal[j, i];
                    }
                }
                SourceDataDGV.Rows.Add();
                SourceDataDGV.Rows[i].Cells[0].Value = data[0, i];
                SourceDataDGV.Rows[i].Cells[1].Value = data[1, i];
            }
            СalculationDGV.Rows[dataKoreal.GetLength(1)-1].Cells[0].Value = "Σ";

        }

       

    }
}
