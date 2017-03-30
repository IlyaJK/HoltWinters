using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HoltWintersController;
using HoltWintersController.PageController;
using HoltWintersUI.Page;

namespace HoltWintersUI
{
    public partial class MainForm : Form
    {
        private readonly IController _controller;
        private readonly List<TabPage> _pages;
        private bool NextEnable
        {
            set { NextBT.Enabled = value; }
        }

        public MainForm() : this(new Controller()) { }

        public MainForm(IController container)
        {
            _controller = container;
            _pages = new List<TabPage>();
            InitializeComponent();
            СalculationDGV.AllowUserToAddRows = false;
            SourceDataDGV.AllowUserToAddRows = false;
            for (int i = 0; i < 15; i++)
            {
                TabPage step = new TabPage("Шаг" + (i + 1));
                step.Controls.Add(new StepOne(new StepOneController()));
                _pages.Add(step);
                StepTC.TabPages.Add(step);
            }

        }

        private void OpenBT_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = _controller.Filter;
            if (OpenFileDialog.ShowDialog() != DialogResult.OK) return;
            Clear();
            _controller.FillData(OpenFileDialog.FileName);
            double[,] data = _controller.Data;

            for (int i = 0; i < data.GetLength(1); i++)
            {
                if (i < data.GetLength(1) / 2)
                {
                    СalculationDGV.Rows.Add();
                    for (int j = 0; j < data.GetLength(0); j++)
                    {
                        СalculationDGV.Rows[i].Cells[j].Value = data[j, i];
                    }
                }
                SourceDataDGV.Rows.Add();
                SourceDataDGV.Rows[i].Cells[0].Value = data[1, i];
                SourceDataDGV.Rows[i].Cells[1].Value = data[2, i];
            }
            var sum = _controller.GetSum();
            СalculationDGV.Rows.Add();
            СalculationDGV.Rows[data.GetLength(1) / 2].Cells[0].Value = "Σ";
            for (int i = 1; i < sum.Length; i++)
            {
                СalculationDGV.Rows[data.GetLength(1) / 2].Cells[i].Value = sum[i];
            }
            NextEnable = true;
        }

        private void ClearBT_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void NextBT_Click(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            _controller.Clear();
            SourceDataDGV.Rows.Clear();
            СalculationDGV.Rows.Clear();
            NextEnable = false;
        }
    }
}
