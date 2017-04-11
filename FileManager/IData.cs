namespace HoltWintersModel
{
    public interface IData
    {
        double[,] Data { get; }

        bool LoadData();
    }
}