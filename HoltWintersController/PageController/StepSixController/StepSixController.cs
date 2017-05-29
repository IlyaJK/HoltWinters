using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoltWintersModel;
using System.Windows.Forms;

namespace HoltWintersController.PageController.StepSixController
{
   public class StepSixController : IStepSixController
    {
        private IData _data;

        public StepSixController()
        {
            _data = ModelManager.GetData();
        }

        public void Solve_d(ref string coeff)
        {
            coeff = _data.Sum_SqrEtMinusEt_1.ToString() + " / "   + _data.Sum_sqrE.ToString() + " = " +
                            (_data.Sum_SqrEtMinusEt_1 / _data.Sum_sqrE).ToString();
         
        }

        public double[] Get_Emax_Emin()
        {
            return new double[]{_data.E.Max(), _data.E.Min()};
        }

        public double Solve_Se()
        {
            double n = _data.Data.GetLength(1);
            return Math.Sqrt((n * _data.Sum_sqrE - _data.Sum_E * _data.Sum_E) / (n * (n - 1)));
        }

        public double Solve_RS()
        {
            var emax_emin = Get_Emax_Emin();
            var se = Solve_Se();
            return (emax_emin[0]-emax_emin[1])/se;
        }

        public double Solve_srErrorAproks()
        {
            double n = _data.Data.GetLength(1);
            return _data.Sum_YMinusYtDivy / n * 100;
        }
    }
}
