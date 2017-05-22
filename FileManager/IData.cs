using System;

namespace HoltWintersModel
{
    public interface IData
    {
        double[,] Data { get; }
        double[,] DataKorel { get; set; }
        double[] Korni { get; set; }
        double[] Yp { get; set; }
        double[] F { get; set; }
        double[] at { get; set; }
        double[] bt { get; set; }
        double[] Ft { get; set; }
        double[] Yt { get; set; }
        double[] E { get; set; }
        double[] PovTochki { get; set; }
        double[] YMinusYtDivy { get; set; }

        bool LoadData();
        void Clear();
        void Op();
       
    }
}