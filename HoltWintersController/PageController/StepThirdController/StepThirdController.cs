using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoltWintersModel;
using System.Windows.Forms;

namespace HoltWintersController.PageController.StepThirdController
{
    public class StepThirdController : IStepThirdController
    {

        private readonly IData _data;

        public StepThirdController()
        {
            _data = ModelManager.GetData();
        }

        public double[] GetF() => _data.F;

        public double[] GetYp() => _data.Yp;

        public double[,] GetData() => _data.Data;

        public double[] Getat()
        {
            
            return _data.at;
                
         }
        public double[] Getbt()
        {
            
            return _data.bt;

        }
        public double[] GetYt()
        {
          
            return _data.Yt;

        }

        public void Count()
        {
           
        }

        public double[] GetFt()
        {
            
            return _data.Ft;
                
        }

        public void Setat(double[] at)
        {
            _data.at = at;

        }
        public void Setbt(double[] bt)
        {
            _data.bt = bt;

        }
        public void SetYt(double[] yt)
        {
            _data.Yt = yt;

        }
        public void SetFt(double[] ft)
        {
            _data.Ft =ft;

        }
        public double[] GetKorni() => _data.Korni;
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
