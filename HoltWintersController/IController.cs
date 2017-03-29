namespace HoltWintersController
{
    public interface IController
    {
        double[,] Data { get; }
        string Filter { get; }

        void FillData(string path);
        double[] GetSum();
        void Clear();
    }
}