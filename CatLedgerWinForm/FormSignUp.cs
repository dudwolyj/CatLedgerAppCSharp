using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatLedgerWinForm
{
    public partial class FormSignUp : Form
    {
        private static readonly string SignUpURL = "signup";
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Program.frmLogIn.Show();
            Program.frmSignUp.Hide();
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

            MessageBox.Show(resultGet);
        }
    }
}
