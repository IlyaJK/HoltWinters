using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoltWintersController.PageController.StepSevenController
{
    public interface IStepSevenController
    {
        double[,] GetData();
        double[] SolveYt();
        string AnalitYt { get; set; }
    }
}
