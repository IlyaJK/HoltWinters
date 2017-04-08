using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HoltWintersController.PageController;
using HoltWintersUI.Page;

namespace HoltWintersUI
{
    public partial class MainForm : Form
    {
        private readonly List<StepPage> _pages;
        private bool NextEnable
        {
            set { NextBT.Enabled = value; }
        }

        public MainForm()
        {
            _pages = new List<StepPage>();
            InitializeComponent();
            for (int i = 0; i < 15; i++)
            {
                TabPage tabPage = new TabPage("Шаг" + (i + 1));
                StepPage stepPage = new StepOne(new StepOneController());
                tabPage.Controls.Add(stepPage);
                _pages.Add(stepPage);
                StepTC.TabPages.Add(tabPage);
            }

        }

        private void NextBT_Click(object sender, EventArgs e)
        {

        }

    }
}