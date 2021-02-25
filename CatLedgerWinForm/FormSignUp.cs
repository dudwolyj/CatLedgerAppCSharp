using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatLedgerWinForm
{
    public partial class FormSignUp : Form
    {
        private static readonly string SignUpURL = "signup";
        private static readonly string CheckEmailURL = "signup/checkemail";
        public FormSignUp()
        {
            InitializeComponent();
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private bool IsExistEmail(string email)
        {
            StringBuilder RequestParam = new StringBuilder();
            RequestParam.Append("email=");
            RequestParam.Append(email);
            string resultGet = RestApiInterface.RequestURL(CheckEmailURL, RequestParam.ToString());

            JObject jsonRoot = JObject.Parse(resultGet);
            if (jsonRoot.ContainsKey("statuscode"))
            {
                // 200 : 정상, 300 : 중복
                if (jsonRoot["statuscode"].ToString().Equals("200"))
                {
                    if (jsonRoot["isexist"].ToString().Equals("1"))
                    {
                        MessageBox.Show("이미 가입된 Email입니다.");
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("서버 응답 에러");
                    return true;
                }
            }
            else
            {
                MessageBox.Show("statuscode값 없음.");
                return true;
            }
        }

        private bool SendEmail(string email)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential("kyyj.lee@gmail.com", "dudwolyj1!");

            MailAddress from = new MailAddress("catledger@catledger.com", "catledger", Encoding.UTF8);
            MailAddress to = new MailAddress(email);

            MailMessage message = new MailMessage(from, to);
            message.Body = "인증코드 : 111222";
            message.BodyEncoding = Encoding.UTF8;
            message.Subject = "CatLedger 회원가입 인증코드";
            message.SubjectEncoding = Encoding.UTF8;

            try
            {
                smtpClient.Send(message);
                message.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

            return true;
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            btnConformCode.Enabled = false;
            labelExplain.Enabled = false;
            string Email = textBoxEmail.Text;

            if (false == IsValidEmail(Email))
            {
                MessageBox.Show("유효한 Email 주소가 아닙니다. Email 주소를 확인해주세요.");
                return;
            }
            else if (true == IsExistEmail(Email))
            {
                MessageBox.Show("중복된 이메일 입니다. ");
                return;
            }
            else
            {
                if (true == SendEmail(Email))
                {
                    btnConformCode.Enabled = true;
                    labelExplain.Enabled = true;
                }
            }
        }

        private void btnConformCode_Click(object sender, EventArgs e)
        {
            string conformCode = textBoxConformCode.Text;
            if("111222" == conformCode)
            {
                MessageBox.Show("인증성공!");
                btnSignUp.Enabled = true;
            }
            else
            {
                MessageBox.Show("인증실패");
                btnSignUp.Enabled = true;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string Email = textBoxEmail.Text;
            string PassWord = textBoxPassword.Text;

            StringBuilder RequestParam = new StringBuilder();
            RequestParam.Append("email=");
            RequestParam.Append(Email);
            RequestParam.Append("&password=");
            RequestParam.Append(PassWord);
            string resultGet = RestApiInterface.RequestURL(SignUpURL, RequestParam.ToString());

            JObject jsonRoot = JObject.Parse(resultGet);
            if (jsonRoot.ContainsKey("statuscode"))
            {
                // 200 : 정상, 300 : 중복
                if(true == jsonRoot["statuscode"].ToString().Equals("200"))
                {
                    MessageBox.Show("회원가입 성공!");
                }
                else
                {
                    MessageBox.Show("회원가입 실패");
                }
            }
            else
            {
                MessageBox.Show("statuscode값 없음.");
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Program.frmLogIn.Show();
            Program.frmSignUp.Hide();
        }
    }
}
