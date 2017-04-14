namespace HoltWintersModel
{
    public interface IData
    {
        double[,] Data { get; }
        double[,] DataKorel { get; set; }
        double[] Korni { get; set; }
        double[] Yp { get; set; }

        bool LoadData();
        void Clear();
    }
}