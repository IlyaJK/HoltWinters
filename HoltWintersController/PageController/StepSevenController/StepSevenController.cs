using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoltWintersModel;

namespace HoltWintersController.PageController.StepSevenController
{
    public class StepSevenController : IStepSevenController
    {
        private IData _data;

        public StepSevenController()
        {
            _data = ModelManager.GetData();
        }

        public double[,] GetData()
        {
            return _data.Data;
        }

        public double[] SolveYt()
        {
            int end = _data.Data.GetLength(1);
            _data.YtPrognoz = new double[end+4];
            for (int i = 0; i < _data.Yt.Length; i++)
            {
                _data.YtPrognoz[i] = _data.Yt[i];   
            }
            for (int i = 0; i < 4; i++)
            {
                _data.YtPrognoz[end+i] = (_data.at[end-1] + _data.bt[end-1] * _data.Data[0, i]) * _data.Ft[end - 4 + i];
                AnalitYt += "Yп("+(end + i + 1).ToString() + ") = ("+_data.at[end - 1].ToString() +" + " + _data.bt[end - 1].ToString()+" * "+_data.Data[0, i].ToString() + ") * " + _data.Ft[end - 4 + i].ToString() + " = " + _data.YtPrognoz[end + i].ToString() + "\n";
            }
            return _data.YtPrognoz;
        }

        public string AnalitYt { get; set; }
    }
}
