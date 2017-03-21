using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Diplom
{
    public partial class Form1 : Form
    {

        List<TabPage> pages = new List<TabPage>();
        int tekShag;

        string data;

        private void OpenCsv()
        {

            openFileDialog1.Filter = "Files|*.csv";
            openFileDialog1.Title = "Select File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    data = sr.ReadToEnd();
                }
            }
        }

        private void RegParse()
        {
            Regex reg = new Regex(@"([-]?\d+[,]?\d*)[;]([-]?\d+[,]?\d*)", RegexOptions.None);
            MatchCollection matchs = reg.Matches(data);

            int i = 0;
            foreach (Match m in matchs)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = m.Groups[1].Value;
                dataGridView1.Rows[i].Cells[1].Value = m.Groups[2].Value;
                i++;
            }
            t_yt = new double[2, i];

            for (int j = 0; j < i; j++)
            {
                t_yt[0, j] = double.Parse(dataGridView1.Rows[j].Cells[0].Value.ToString());
                t_yt[1, j] = double.Parse(dataGridView1.Rows[j].Cells[1].Value.ToString());

            }
        }

        public Form1()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            pages.Add(tabPage1);
            pages.Add(tabPage2);
            pages.Add(tabPage3);
            pages.Add(tabPage4);
            pages.Add(tabPage5);
            pages.Add(tabPage6);
            pages.Add(tabPage7);
            pages.Add(tabPage8);
            pages.Add(tabPage9);
            pages.Add(tabPage10);
            pages.Add(tabPage11);
            pages.Add(tabPage12);
            pages.Add(tabPage13);
            pages.Add(tabPage14);
            pages.Add(tabPage15);
            HideAllPages();

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenCsv();
            RegParse();
            ZapTable2();
            buttonNext1.Enabled = true;

        }

        void HideAllPages()
        {
            for (int i = 1; i < pages.Count; i++)
            {
                pages[i].Parent = null;
            }
        }

        void NextShag()
        {
            tekShag++;
            pages[tekShag].Parent = tabControl1;
            tabControl1.SelectedTab = pages[tekShag];

        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            NextShag();
            ZapYp();
        }

        #region Шаг 1

        double[,] t_yt;
        double[,] i_t_yt;
        double[] sum_i_t_yt;
        double[] sums;

        void ZapTable2()
        {

            sums = new double[6];
            i_t_yt = new double[9, 6];
            sum_i_t_yt = new double[9];
            for (int i = 0; i < i_t_yt.GetLength(0); i++)
            {
                dataGridView2.Rows.Add();

                sums[0] += i < i_t_yt.GetLength(0) - 1 ? i + 1 : 0;
                dataGridView2.Rows[i].Cells[0].Value = i < i_t_yt.GetLength(0) - 1 ? (i + 1).ToString() : "Σ";

                sums[1] += i < i_t_yt.GetLength(0) - 1 ? t_yt[0, i] : 0;
                dataGridView2.Rows[i].Cells[1].Value = i < i_t_yt.GetLength(0) - 1 ? t_yt[0, i] : sums[1];

                sums[2] += i < i_t_yt.GetLength(0) - 1 ? t_yt[1, i] : 0;
                dataGridView2.Rows[i].Cells[2].Value = i < i_t_yt.GetLength(0) - 1 ? t_yt[1, i] : sums[2];

                sums[3] += i < i_t_yt.GetLength(0) - 1 ? t_yt[0, i] * t_yt[0, i] : 0;
                dataGridView2.Rows[i].Cells[3].Value = i < i_t_yt.GetLength(0) - 1 ? t_yt[0, i] * t_yt[0, i] : sums[3];

                sums[4] += i < i_t_yt.GetLength(0) - 1 ? t_yt[1, i] * t_yt[1, i] : 0;
                dataGridView2.Rows[i].Cells[4].Value = i < i_t_yt.GetLength(0) - 1 ? t_yt[1, i] * t_yt[1, i] : sums[4];

                sums[5] += i < i_t_yt.GetLength(0) - 1 ? t_yt[0, i] * t_yt[1, i] : 0;
                dataGridView2.Rows[i].Cells[5].Value = i < i_t_yt.GetLength(0) - 1 ? t_yt[0, i] * t_yt[1, i] : sums[5];


            }

        }

        void ClearData()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

        }


        #endregion

        #region Шаг 2

        double[] _yp;
        double[] _korni;

        public double[] Kramer(double a1, double a2, double a3, double a4, double a5, double a6)
        {
            double det = a1 * a5 - a2 * a4;
            double det1 = a3 * a5 - a2 * a6;
            double det2 = a1 * a6 - a3 * a4;
            return new[] { det2 / det, det1 / det };
        }

        void ZapYp()
        {
            string krn = "";
            _korni = Kramer(sums[0], sums[1], sums[2], sums[3], sums[4], sums[5]);
            _yp = new double[i_t_yt.GetLength(0)];
            for (int i = 0; i < _yp.Length; i++)
            {
                _yp[i] = _korni[0] * i + _korni[1];
                krn += _yp[i].ToString() + '\n';
            }
            label1.Text = krn;
        }

        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            ClearData();
            buttonNext1.Enabled = false;
        }

    }
}
