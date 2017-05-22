using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoltWintersController.PageController.StepFiveController
{
   public interface IStepFiveController
   {
       double[] E();
       double[] PovTochki();
       double[,] GetData();
       double[] YMinusYtDivy();
       double[] SqrE();
       double[] EtMinusEt_1();
       double[] SqrEtMinusEt_1();
       double[] EtMultEt_1();
       double Sum_t { get; set; }
       double Sum_y { get; set; }
       double Sum_E { get; set; }
       double Sum_povToch { get; set; }
       double Sum_YMinusYtDivy { get; set; }
       double Sum_sqrE { get; set; }
       double Sum_EtMinusEt_1 { get; set; }
       double Sum_SqrEtMinusEt_1 { get; set; }
       double Sum_EtMultEt_1 { get; set; }

    }
}
