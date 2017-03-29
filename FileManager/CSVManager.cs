using System;
using System.IO;
using System.Text.RegularExpressions;

namespace FileManager
{
    public class CSVManager : IFileManager
    {
        public string Filter { get; }

        public CSVManager()
        {
            Filter = "Files|*.csv";
        }

        public double[,] OpenAndParse(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException();
            string file = Open(path);
            if (string.IsNullOrEmpty(file))
                throw new ArgumentNullException("Считываемый файл пуст");
            double[,] table = Parse(file);
            if (table.GetLength(0) == 0 || table.GetLength(1) == 0)
                throw new Exception("Выбран не корректный файл");
            return table;
        }

        private string Open(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd();
            }
        }

        private double[,] Parse(string data)
        {
            Regex reg = new Regex(@"([-]?\d+[,]?\d*)[;]([-]?\d+[,]?\d*)", RegexOptions.None);
            MatchCollection matchs = reg.Matches(data);
            double[,] table = new double[2, matchs.Count];

            for (int i = 0; i < matchs.Count; i++)
            {
                table[0, i] = double.Parse(matchs[i].Groups[1].Value);
                table[1, i] = double.Parse(matchs[i].Groups[2].Value);
            }
            return table;
        }
    }
}