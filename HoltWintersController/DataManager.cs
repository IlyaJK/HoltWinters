using System.Windows.Forms;
using FileManager;

namespace HoltWintersController
{
    public class DataManager
    {
        private readonly IFileManager _fileManager;

        
        
        public DataManager() : this(new CSVManager()) { }
        public DataManager(IFileManager fileManager)
        {
            _fileManager = fileManager;
        }

        public bool LoadFile()
        {
            OpenFileDialog openFile = new OpenFileDialog { Filter = _fileManager.Filter };
            if (openFile.ShowDialog() != DialogResult.OK) return false;
            string path = openFile.FileName;
            return true;
        }

    }
}