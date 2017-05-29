using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoltWintersController.PageController.StepSixController
{
    public interface IStepSixController
    {
        void Solve_d(ref string coeff);
        double[] Get_Emax_Emin();
        double Solve_Se();
        double Solve_RS();
        double Solve_srErrorAproks();

    }
}
