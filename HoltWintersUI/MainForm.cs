using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HoltWintersController;

namespace HoltWintersUI
{
    public partial class MainForm : Form
    {
        private readonly IController _container;
        private readonly List<TabPage> _pages;

        public MainForm() : this(new Controller()) { }

        public MainForm(IController container)
        {
            _container = container;
            _pages = new List<TabPage>();
            InitializeComponent();
            СalculationDGV.AllowUserToAddRows = false;
            СalculationDGV.AllowUserToAddRows = false;

        }

        private void OpenBT_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog.Filter = _container.Filter;
            OpenFileDialog.Title = "Select File";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                _container.FillData(OpenFileDialog.FileName);
                double[,] data = _container.Data;
               
                for (int i = 0; i < data.GetLength(1)/2; i++)
                {
                    СalculationDGV.Rows.Add();
                    for (int j = 0; j < data.GetLength(0); j++)
                    {

                        СalculationDGV.Rows[i].Cells[j].Value = data[j, i];
                        
                    }
                }
            }

        }
    }
}
