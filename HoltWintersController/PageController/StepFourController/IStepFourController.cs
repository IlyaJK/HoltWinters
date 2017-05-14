using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoltWintersController.PageController.StepFourController
{
    public interface IStepFourController
    {
        double[] GetYt();
        double[] GetY();
    }
}
