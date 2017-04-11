using System;
using System.IO;
using System.Text.RegularExpressions;

namespace HoltWintersModel.FileManager
{
    public class CSVManager : IFileManager
    {
        public string Filter { get; }

        public CSVManager()
        {
            Filter = "Files|*.csv";
        }

        public double[,] GetData(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException();
            string file = Open(path);
            if (string.IsNullOrEmpty(file))
                throw new ArgumentNullException("Считываемый файл пуст");
            var table = Parse(file);
            if (table.GetLength(0) == 0 || table.GetLength(1) == 0)
                throw new Exception("Выбран не корректный файл");
            return table;
        }

        private string Open(string path)
        {
            using (var sr = new StreamReader(path))
            {
                return sr.ReadToEnd();
            }
        }

        private double[,] Parse(string data)
        {
            var reg = new Regex(@"([-]?\d+[,]?\d*)[;]([-]?\d+[,]?\d*)", RegexOptions.None);
            var matchs = reg.Matches(data);
            var table = new double[2, matchs.Count];

            for (var i = 0; i < matchs.Count; i++)
            {
                table[0, i] = double.Parse(matchs[i].Groups[1].Value);
                table[1, i] = double.Parse(matchs[i].Groups[2].Value);
            }
            return table;
        }
    }
}