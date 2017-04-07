using FileManager;
using System.Windows.Forms;

namespace HoltWintersModel
{
    internal class CurrentData : IData
    {
        public double[,] Data { get; private set; }

        private readonly IFileManager _fileManager;

        internal CurrentData() : this(new CSVManager()) { }
        internal CurrentData(IFileManager fileManager)
        {
            _fileManager = fileManager;
        }

        public bool LoadData()
        {
            OpenFileDialog openFile = new OpenFileDialog { Filter = _fileManager.Filter };
            if (openFile.ShowDialog() != DialogResult.OK) return false;
            string path = openFile.FileName;
            Data = _fileManager.GetData(path);
            return true;
        }
    }
}