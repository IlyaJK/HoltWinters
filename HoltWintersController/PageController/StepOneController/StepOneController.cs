using System.Linq;
using System.Windows.Forms;
using HoltWintersModel;

namespace HoltWintersController.PageController
{
    public class StepOneController : IStepOneController
    {
        private readonly IData _data;

        public StepOneController()
        {
            _data = ModelManager.GetData();
        }

        public double[,] GetStartData()
        {
            return _data.Data;
        }

        public double[,] GetDataKorel()
        {
            var data = _data.Data;
            var dataKorel = new double[5, data.GetLength(1) / 2 + 1];
            for (var i = 0; i < dataKorel.GetLength(1); i++)
            {
                dataKorel[0, i] = data[0, i];
                dataKorel[1, i] = data[1, i];
                dataKorel[2, i] = data[0, i] * data[0, i];
                dataKorel[3, i] = data[1, i] * data[1, i];
                dataKorel[4, i] = data[1, i] * data[0, i];
            }
            for (var i = 0; i < dataKorel.GetLength(0); i++)
            {
                var sum = 0.0;
                for (var j = 0; j < dataKorel.GetLength(1)-1; j++)  sum += dataKorel[i, j];
                dataKorel[i, dataKorel.GetLength(1) - 1] = sum;
            }
            _data.DataKorel = dataKorel;
            return _data.DataKorel;
        }

     

     

 

      

       


    }
}