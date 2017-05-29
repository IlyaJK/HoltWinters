using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoltWintersController.PageController.StepEightController
{
    public interface IStepEightController
    {
        double[] GetYtPrognoz();
        double[] Get_y();
    }
}
