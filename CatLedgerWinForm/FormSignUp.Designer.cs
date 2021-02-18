
namespace CatLedgerWinForm
{
    partial class FormSignUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSignUp = new System.Windows.Forms.Button();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.btnConformCode = new System.Windows.Forms.Button();
            this.labelExplain = new System.Windows.Forms.Label();
            this.labelConformCode = new System.Windows.Forms.Label();
            this.textBoxConformCode = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(93, 253);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(440, 34);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "가입하기";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Location = new System.Drawing.Point(248, 38);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(84, 25);
            this.labelSignUp.TabIndex = 1;
            this.labelSignUp.Text = "회원가입";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(197, 109);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(263, 31);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(197, 173);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(263, 31);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(126, 109);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(64, 25);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email :";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(93, 173);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(98, 25);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password :";
            // 
            // btnConformCode
            // 
            this.btnConformCode.Location = new System.Drawing.Point(371, 544);
            this.btnConformCode.Name = "btnConformCode";
            this.btnConformCode.Size = new System.Drawing.Size(112, 34);
            this.btnConformCode.TabIndex = 6;
            this.btnConformCode.Text = "인증하기";
            this.btnConformCode.UseVisualStyleBackColor = true;
            // 
            // labelExplain
            // 
            this.labelExplain.Location = new System.Drawing.Point(77, 465);
            this.labelExplain.Name = "labelExplain";
            this.labelExplain.Size = new System.Drawing.Size(456, 61);
            this.labelExplain.TabIndex = 7;
            this.labelExplain.Text = "가입하신 이메일로 인증코드를 보냈습니다. 이메일을 확인하여 인증코드를 입력해 주세요.";
            // 
            // labelConformCode
            // 
            this.labelConformCode.AutoSize = true;
            this.labelConformCode.Location = new System.Drawing.Point(93, 544);
            this.labelConformCode.Name = "labelConformCode";
            this.labelConformCode.Size = new System.Drawing.Size(94, 25);
            this.labelConformCode.TabIndex = 8;
            this.labelConformCode.Text = "인증코드 :";
            // 
            // textBoxConformCode
            // 
            this.textBoxConformCode.Location = new System.Drawing.Point(193, 544);
            this.textBoxConformCode.Name = "textBoxConformCode";
            this.textBoxConformCode.Size = new System.Drawing.Size(150, 31);
            this.textBoxConformCode.TabIndex = 9;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(93, 613);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(440, 34);
            this.btnLogIn.TabIndex = 10;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 730);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.textBoxConformCode);
            this.Controls.Add(this.labelConformCode);
            this.Controls.Add(this.labelExplain);
            this.Controls.Add(this.btnConformCode);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelSignUp);
            this.Controls.Add(this.btnSignUp);
            this.Name = "FormSignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label labelSignUp;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button btnConformCode;
        private System.Windows.Forms.Label labelExplain;
        private System.Windows.Forms.Label labelConformCode;
        private System.Windows.Forms.TextBox textBoxConformCode;
        private System.Windows.Forms.Button btnLogIn;
    }
}

