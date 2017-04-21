using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoltWintersController.PageController.StepSecondController
{
    public interface IStepSecondController
    {
      

        string GetNormalSystemString();

        string GetKorniString();

        string GetYpString();
        string GetFString();

        void SolveYp();
        double[] GetYp();
        void Kramer(double a1, double a2, double a3, double a4, double a5, double a6);
     
        double[] GetKorni();

        double[,] GetKorel();

        void SolveF();
    }
}
