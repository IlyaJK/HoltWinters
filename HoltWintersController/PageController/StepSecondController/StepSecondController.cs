using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoltWintersModel;

namespace HoltWintersController.PageController.StepSecondController
{
    public class StepSecondController : IStepSecondController
    {

        private readonly IData _data;

        public StepSecondController()
        {
            _data = ModelManager.GetData();
        }
        public double[] GetYp()
        {
            return _data.Yp;
        }

        public double[] GetKorni()
        {
            return _data.Korni;
        }

        public string GetKorniString()
        {
            var korni = _data.Korni;
            return "a1 = " + _data.Korni[1] + '\n' +
                   "a0 = " + _data.Korni[0];
        }

        public string GetYpString()
        {
            return "y1p = " + _data.Yp[0] + '\n' +
                   "y2p = " + _data.Yp[1] + '\n' +
                   "y3p = " + _data.Yp[2] + '\n' +
                   "y4p = " + _data.Yp[3] + '\n' +
                   "y5p = " + _data.Yp[4] + '\n' +
                   "y6p = " + _data.Yp[5] + '\n' +
                   "y7p = " + _data.Yp[6] + '\n' +
                   "y8p = " + _data.Yp[7];
        }

        public string GetNormalSystemString()
        {
            var dataKoreal = _data.DataKorel;
            return "a1*" + dataKoreal[2, 8].ToString() + " + a0*" + dataKoreal[0, 8] + " = " +
                   dataKoreal[4, 8].ToString() + "\n" +
                   "a1*" + dataKoreal[0, 8].ToString() + " + a0*" + dataKoreal[0, 7].ToString() + " = " +
                   dataKoreal[1, 8].ToString();
        }

    }
}
