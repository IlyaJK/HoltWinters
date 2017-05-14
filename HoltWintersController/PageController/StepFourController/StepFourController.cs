using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoltWintersModel;

namespace HoltWintersController.PageController.StepFourController
{
    public class StepFourController: IStepFourController
    {
        private readonly IData _data;

        public StepFourController()
        {
            _data = ModelManager.GetData();
        }

        public double[] GetYt() => _data.Yt;
        public double[] GetY()
        {
            var y = new double[_data.Data.GetLength(1)];

            for (int i = 0; i < y.Length; i++)
            {
                y[i] = _data.Data[1, i];
            }
            return y;
        }
    }
}
