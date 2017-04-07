using FileManager;

namespace HoltWintersController
{
    public class Controller : IController
    {
        public double[,] Data { get; private set; }
        public string Filter => _fileManager.Filter;

        private readonly IFileManager _fileManager;


        public Controller() : this(new CSVManager()) { }
        public Controller(IFileManager fileManager)
        {
            _fileManager = fileManager;
           
        }

        public void FillData(string path)
        {
            double[,] data = _fileManager.GetData(path);
            Data = new double[6, data.GetLength(1)];
            for (int i = 0; i < Data.GetLength(1); i++)
            {
                Data[0, i] = i + 1;
                Data[1, i] = data[0, i];
                Data[2, i] = data[1, i];
                Data[3, i] = data[0, i] * data[0, i];
                Data[4, i] = data[1, i] * data[1, i];
                Data[5, i] = data[1, i] * data[0, i];
            }
        }

        public double[] GetSum()
        {
            double[] sum = new double[Data.GetLength(0)];
            for (int i = 0; i < Data.GetLength(0); i++)
            {
                for (int j = 0; j < Data.GetLength(1) / 2; j++)
                {
                    sum[i] += Data[i, j];
                }
            }
            return sum;
        }

        public void Clear()
        {
            Data = null;
        }

    }
}