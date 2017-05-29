using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HoltWintersModel;

namespace HoltWintersController.PageController.StepFiveController
{
    public class StepFiveController: IStepFiveController
    {
        private IData _data;

        public StepFiveController()
        {
            _data = ModelManager.GetData();
        }


        public double[] E()
        {
            _data.E = new double[_data.Data.GetLength(1)];

            for (int i = 0; i < _data.E.Length; i++)
            {
                _data.E[i] = _data.Data[1, i] - _data.Yt[i];
                _data.Sum_E += _data.E[i];
                Sum_E = _data.Sum_E;
            }
            return _data.E;
        }

        public double[] PovTochki()
        {
            _data.PovTochki = new double[_data.E.Length];
            for (int i = 0; i < _data.E.Length; i++)
            {
                if (i == 0 || i == _data.E.Length - 1)
                {
                    _data.PovTochki[i] = -1;
                }
                else
                {
                    _data.PovTochki[i] = (((_data.E[i] < _data.E[i - 1]) && (_data.E[i] < _data.E[i + 1])) ||
                                          ((_data.E[i] > _data.E[i - 1]) && (_data.E[i] > _data.E[i + 1])))? 1 : 0;
                    _data.Sum_povToch += _data.PovTochki[i];
                }
                
            }
            Sum_povToch = _data.Sum_povToch;
            return _data.PovTochki;
        }

        public double[,] GetData()
        {
            for (int i = 0; i < _data.Data.GetLength(1); i++)
            {
                _data.Sum_t += _data.Data[0, i];
                _data.Sum_y += _data.Data[1, i];
            }
            Sum_t = _data.Sum_t;
            Sum_y = _data.Sum_y;
            return _data.Data;
        }

        public double[] YMinusYtDivy()
        {
            _data.YMinusYtDivy = new double[_data.Data.GetLength(1)];
            for (int i = 0; i < _data.YMinusYtDivy.Length; i++)
            {
                _data.YMinusYtDivy[i] = Math.Abs((_data.Data[1, i] - _data.Yt[i]) / _data.Data[1, i]);
                _data.Sum_YMinusYtDivy += _data.YMinusYtDivy[i];
            }
            Sum_YMinusYtDivy = _data.Sum_YMinusYtDivy;
            return _data.YMinusYtDivy;
        }

        public double[] SqrE()
        {
            var sqrE = new double[_data.Data.GetLength(1)];
            for (int i = 0; i < sqrE.Length; i++)
            {
                sqrE[i] = _data.E[i] * _data.E[i];
                _data.Sum_sqrE += sqrE[i];
            }
            Sum_sqrE = _data.Sum_sqrE;
            return sqrE;
        }

        public double[] EtMinusEt_1()
        {
            var data = new double[_data.Data.GetLength(1)];

            for (int i = 1; i < data.Length; i++)
            {
                data[i] = _data.E[i] - _data.E[i-1];

                _data.Sum_EtMinusEt_1 += data[i];
            }
            Sum_EtMinusEt_1 = _data.Sum_EtMinusEt_1;
            return data;
        }

        public double[] SqrEtMinusEt_1()
        {
            var data = new double[_data.Data.GetLength(1)];

            for (int i = 1; i < data.Length; i++)
            {
                data[i] = Math.Pow(_data.E[i] - _data.E[i - 1], 2);
                _data.Sum_SqrEtMinusEt_1 += data[i];
            }
            Sum_SqrEtMinusEt_1 = _data.Sum_SqrEtMinusEt_1;
            return data;
        }

        public double[] EtMultEt_1()
        {
            var data = new double[_data.Data.GetLength(1)];

            for (int i = 1; i < data.Length; i++)
            {
                data[i] = _data.E[i] * _data.E[i - 1];
                _data.Sum_EtMultEt_1 += data[i];
            }
            Sum_EtMultEt_1 = _data.Sum_EtMultEt_1;
            return data;
        }

        public double Sum_t { get; set; }
        public double Sum_y { get; set; }
        public double Sum_E { get; set; }
        public double Sum_povToch { get; set; }
        public double Sum_YMinusYtDivy { get; set; }
        public double Sum_sqrE { get; set; }
        public double Sum_EtMinusEt_1 { get; set; }
        public double Sum_SqrEtMinusEt_1 { get; set; }
        public double Sum_EtMultEt_1 { get; set; }
    }
}
