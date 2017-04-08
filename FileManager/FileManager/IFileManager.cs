namespace HoltWintersModel.FileManager
{
    public interface IFileManager
    {
        string Filter { get; }

        double[,] GetData(string path);
    }
}