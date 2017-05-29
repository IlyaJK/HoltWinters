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
        double[] YtPrognoz { get; set; }
        double[] E { get; set; }
        double[] PovTochki { get; set; }
        double[] YMinusYtDivy { get; set; }
        double Sum_t { get; set; }
        double Sum_y { get; set; }
        double Sum_E { get; set; }
        double Sum_povToch { get; set; }
        double Sum_YMinusYtDivy { get; set; }
        double Sum_sqrE { get; set; }
        double Sum_EtMinusEt_1 { get; set; }
        double Sum_SqrEtMinusEt_1 { get; set; }
        double Sum_EtMultEt_1 { get; set; }

        

        bool LoadData();
        void Clear();
     
       
    }
}