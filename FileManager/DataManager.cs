using System.Windows.Forms;
using HoltWintersModel.FileManager;
using System;

namespace HoltWintersModel
{
    internal class CurrentData : IData
    {
        public double[,] Data { get; private set; }

        public double[,] DataKorel { get; set; }
        public double[] Korni { get; set; }
        public double[] Yp { get; set; }
        public double[] F { get; set; }
        public double[] at { get; set; }
        public double[] bt { get; set; }
        public double[] Ft { get; set; }
        public double[] Yt { get; set; }

        public virtual void Op()
        {

        }



        private readonly IFileManager _fileManager;

        internal CurrentData() : this(new CSVManager()) { }
        internal CurrentData(IFileManager fileManager)
        {
            _fileManager = fileManager;
        }

        public bool LoadData()
        {
            var openFile = new OpenFileDialog {Filter = _fileManager.Filter};
            if (openFile.ShowDialog() == DialogResult.OK) 
            {
                var path = openFile.FileName;
                Data = _fileManager.GetData(path);
                return true;
            }
            return false;
        }

    

        public void Clear()
        {
            Data = null;
        }
    }
}