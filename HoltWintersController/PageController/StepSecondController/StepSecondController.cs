using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HoltWintersModel;

namespace HoltWintersController.PageController.StepSecondController
{
    public class StepSecondController : IStepSecondController
    {

        private readonly IData _data;

        public StepSecondController()
        {
            _data = ModelManager.GetData();
        }


        public string GetFString()
        {
            return "F(-3) = " + _data.F[0] + '\n' +
                    "F(-2) = " + _data.F[1] + '\n' +
                    "F(-1) = " + _data.F[2] + '\n' +
                    "F(0) = " + _data.F[3];
        }

        public void SolveYp()
        {
            
            _data.Yp = new double[_data.DataKorel.GetLength(1) - 1];
            var korni = _data.Korni;
            for (var i = 1; i <= _data.Yp.Length; i++)
            {
                _data.Yp[i - 1] = korni[1] * i + korni[0];

            }
          
        }

        public double[] GetYp()
        {
            return _data.Yp;
        }

        public void Kramer(double a1, double a2, double a3, double a4, double a5, double a6)
        {
            double det = a1 * a5 - a2 * a4;
            double det1 = a3 * a5 - a2 * a6;
            double det2 = a1 * a6 - a3 * a4;
            var res = new double[2];
            res[0] = det2 / det;
            res[1] = det1 / det;
            _data.Korni = res;
        }


        public double[] GetKorni()
        {
            return _data.Korni;
        }

        public double[,] GetKorel()
        {
            return _data.DataKorel;
        }

        public void SolveF()
        {
            var yp = _data.Yp;
            var f = new double[yp.Length/2];
           
            f[0] = (_data.DataKorel[1,0] / yp[0] + _data.DataKorel[1,4] / yp[4]) /2;
            f[1] = (_data.DataKorel[1,1] / yp[1] + _data.DataKorel[1,5] / yp[5]) / 2;
            f[2] = (_data.DataKorel[1, 2] / yp[2] + _data.DataKorel[1,6] / yp[6]) / 2;
            f[3] = (_data.DataKorel[1,3] / yp[3] + _data.DataKorel[1,7] / yp[7]) / 2;

            _data.F = f;
        }

        public string GetKorniString()
        {
            var korni = _data.Korni;
            return "a1 = " + _data.Korni[1] + '\n' +
                   "a0 = " + _data.Korni[0];
        }

        public string GetYpString()
        {
            return "y1p = " + _data.Yp[0] + '\n' +
                   "y2p = " + _data.Yp[1] + '\n' +
                   "y3p = " + _data.Yp[2] + '\n' +
                   "y4p = " + _data.Yp[3] + '\n' +
                   "y5p = " + _data.Yp[4] + '\n' +
                   "y6p = " + _data.Yp[5] + '\n' +
                   "y7p = " + _data.Yp[6] + '\n' +
                   "y8p = " + _data.Yp[7];
        }



        public string GetNormalSystemString()
        {
            var dataKoreal = _data.DataKorel;
            return "a1*" + dataKoreal[2, 8].ToString() + " + a0*" + dataKoreal[0, 8] + " = " +
                   dataKoreal[4, 8].ToString() + "\n" +
                   "a1*" + dataKoreal[0, 8].ToString() + " + a0*" + dataKoreal[0, 7].ToString() + " = " +
                   dataKoreal[1, 8].ToString();
        }

    }
}
