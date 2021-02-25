
namespace CatLedgerWinForm
{
    partial class FormMainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCtrlMainPage = new System.Windows.Forms.TabControl();
            this.btnAddTab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabCtrlMainPage
            // 
            this.tabCtrlMainPage.Location = new System.Drawing.Point(0, 100);
            this.tabCtrlMainPage.Name = "tabCtrlMainPage";
            this.tabCtrlMainPage.SelectedIndex = 0;
            this.tabCtrlMainPage.Size = new System.Drawing.Size(598, 632);
            this.tabCtrlMainPage.TabIndex = 0;
            // 
            // btnAddTab
            // 
            this.btnAddTab.Location = new System.Drawing.Point(25, 47);
            this.btnAddTab.Name = "btnAddTab";
            this.btnAddTab.Size = new System.Drawing.Size(112, 34);
            this.btnAddTab.TabIndex = 1;
            this.btnAddTab.Text = "AddTab";
            this.btnAddTab.UseVisualStyleBackColor = true;
            this.btnAddTab.Click += new System.EventHandler(this.btnAddTab_Click);
            // 
            // FormMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 730);
            this.Controls.Add(this.btnAddTab);
            this.Controls.Add(this.tabCtrlMainPage);
            this.Name = "FormMainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlMainPage;
        private System.Windows.Forms.Button btnAddTab;
    }
}