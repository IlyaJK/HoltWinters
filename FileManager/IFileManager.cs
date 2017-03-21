namespace FileManager
{
    public interface IFileManager
    {
        string Filter { get; }

        double[,] OpenAndParse(string path);
    }
}