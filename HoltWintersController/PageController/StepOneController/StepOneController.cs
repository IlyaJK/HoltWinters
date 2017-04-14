using System.Linq;
using System.Windows.Forms;
using HoltWintersModel;

namespace HoltWintersController.PageController
{
    public class StepOneController : IStepOneController
    {
        private readonly IData _data;

        public StepOneController()
        {
            _data = ModelManager.GetData();
        }

        public double[,] GetStartData()
        {
            return _data.Data;
        }

        public double[,] GetDataKorel()
        {
            var data = _data.Data;
            var dataKorel = new double[5, data.GetLength(1) / 2 + 1];
            for (var i = 0; i < dataKorel.GetLength(1); i++)
            {
                dataKorel[0, i] = data[0, i];
                dataKorel[1, i] = data[1, i];
                dataKorel[2, i] = data[0, i] * data[0, i];
                dataKorel[3, i] = data[1, i] * data[1, i];
                dataKorel[4, i] = data[1, i] * data[0, i];
            }
            for (var i = 0; i < dataKorel.GetLength(0); i++)
            {
                var sum = 0.0;
                for (var j = 0; j < dataKorel.GetLength(1)-1; j++)  sum += dataKorel[i, j];
                dataKorel[i, dataKorel.GetLength(1) - 1] = sum;
            }
            _data.DataKorel = dataKorel;
            return _data.DataKorel;
        }

        public double[] SolveYp()
        {
            _data.Yp = new double[GetDataKorel().GetLength(1) - 1];
            var korni = _data.Korni;
            for (var i = 1; i <= _data.Yp.Length; i++)
            {
                _data.Yp[i-1] = korni[1]* i + korni[0];
               
            }
            return _data.Yp;

        }

        public double[] GetYp()
        {
            return _data.Yp;
        }

        public double[] GetKorni()
        {
            return _data.Korni;
        }

        public void SetKorni(double[] korni)
        {
            _data.Korni = korni;
        }

        public double[] Kramer(double a1, double a2, double a3, double a4, double a5, double a6)
        {
            double det = a1 * a5 - a2 * a4;
            double det1 = a3 * a5 - a2 * a6;
            double det2 = a1 * a6 - a3 * a4;
            var res = new double[2];
            res[0] = det2 / det;
            res[1] = det1 / det;
            return res;
        }


    }
}