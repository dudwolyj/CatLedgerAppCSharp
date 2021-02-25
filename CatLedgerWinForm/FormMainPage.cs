using Newtonsoft.Json.Linq;
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
        private static readonly string TabListURL = "tab/list";
        public FormMainPage()
        {
            InitializeComponent();
        }

        public void InitTabList()
        {
            string Response = RestApiInterface.RequestURL(TabListURL);

            JObject jsonRoot = JObject.Parse(Response);
            if (jsonRoot.ContainsKey("statuscode"))
            {
                // 200 : 정상, 300 : 중복
                if (jsonRoot["statuscode"].ToString().Equals("200"))
                {
                    if (jsonRoot.ContainsKey("tablist"))
                    {
                        JArray jsonArray = (JArray)jsonRoot["tablist"];
                        foreach (var tab in jsonArray)
                        {
                            JObject tabData = (JObject)tab;
                            if (tabData.ContainsKey("tabName"))
                                tabCtrlMainPage.TabPages.Add(tabData["tabName"].ToString());
                        }
                    }
                }
            }

            if(0 == tabCtrlMainPage.TabPages.Count)
                tabCtrlMainPage.TabPages.Add("Main");
        }

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            tabCtrlMainPage.TabPages.Add("Tab");
        }
    }
}
