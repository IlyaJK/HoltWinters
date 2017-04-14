using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoltWintersController.PageController.StepSecondController
{
    public interface IStepSecondController
    {
        double[] GetYp();

        string GetNormalSystemString();

        double[] GetKorni();

        string GetKorniString();

        string GetYpString();
    }
}
