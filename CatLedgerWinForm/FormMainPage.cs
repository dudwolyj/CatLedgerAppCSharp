using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CatLedgerWinForm
{
    public partial class FormMainPage : Form
    {
        public FormMainPage()
        {
            InitializeComponent();
        }

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            tabCtrlMainPage.TabPages.Add("Tab2");
        }
    }
}
