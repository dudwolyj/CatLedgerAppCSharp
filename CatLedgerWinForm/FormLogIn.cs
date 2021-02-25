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
    public partial class FormLogIn : Form
    {
        private static readonly string LoginURL = "login";
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Program.frmSignUp.Show();
            Program.frmLogIn.Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string Email = textBoxEMail.Text;
            string Password = textBoxPassword.Text;

            if(0 == Email.Length)
            {
                MessageBox.Show("Email을 입력해 주세요.");
            }
            else if(0 == Password.Length)
            {
                MessageBox.Show("Password를 입력해 주세요.");
            }
            else
            {
                StringBuilder errorMessage = new StringBuilder();
                StringBuilder RequestParam = new StringBuilder();
                RequestParam.Append("email=");
                RequestParam.Append(Email);
                RequestParam.Append("&password=");
                RequestParam.Append(Password);

                string Response = RestApiInterface.RequestURL(LoginURL, RequestParam.ToString());

                try
                {
                    JObject jsonRoot = JObject.Parse(Response);
                    if (jsonRoot.ContainsKey("statuscode"))
                    {
                        // 200 : 정상, 300 : 중복
                        if (jsonRoot["statuscode"].ToString().Equals("200"))
                        {
                            if (jsonRoot.ContainsKey("token"))
                            {
                                Program.commonData.authToken = jsonRoot["token"].ToString();
                                Program.frmMainPage.InitTabList();
                                Program.frmMainPage.Show();
                                Program.frmLogIn.Hide();
                            }
                            else
                            {
                                MessageBox.Show("로그인에 실패하였습니다./r/n error : token값 없음.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("로그인에 실패하였습니다./r/n error : " + jsonRoot["message"].ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("로그인에 실패하였습니다./r/n error : statuscode값 없음");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
