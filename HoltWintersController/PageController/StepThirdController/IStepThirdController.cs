using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoltWintersController.PageController.StepThirdController
{
    public interface IStepThirdController
    {

        double[,] GetData();
        double[] GetKorni();
        void Setat(double[] at);
        void Setbt(double[] bt);
        void SetFt(double[] ft);
        void SetYt(double[] yt);

        double[] GetY();
        double[] Getat();
        double[] GetYp();
        double[] GetF();
        double[] Getbt();
        double[] GetFt();
        double[] GetYt();

        void Count();

    }
}
