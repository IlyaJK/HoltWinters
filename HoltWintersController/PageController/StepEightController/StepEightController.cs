using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoltWintersModel;

namespace HoltWintersController.PageController.StepEightController
{
    public class StepEightController : IStepEightController
    {
        private IData _data;

        public StepEightController()
        {
            _data = ModelManager.GetData();
        }

 

        public double[] GetYtPrognoz()
        {
            return _data.YtPrognoz;
        }

        public double[] Get_y()
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
