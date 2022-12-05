namespace DirectoryServicesLDAP
{
  partial class DirectoryServicesLDAPForm
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
      this.groupBoxAdminInfo = new System.Windows.Forms.GroupBox();
      this.comboBoxConnectionType = new System.Windows.Forms.ComboBox();
      this.lbl5 = new System.Windows.Forms.Label();
      this.chckDisableCertCheck = new System.Windows.Forms.CheckBox();
      this.comboBoxPort = new System.Windows.Forms.ComboBox();
      this.txtAdminUserName = new System.Windows.Forms.TextBox();
      this.isAdminConnect = new System.Windows.Forms.Button();
      this.lbl1 = new System.Windows.Forms.Label();
      this.lbl2 = new System.Windows.Forms.Label();
      this.lbl4 = new System.Windows.Forms.Label();
      this.txtAdminPassword = new System.Windows.Forms.TextBox();
      this.txtHost = new System.Windows.Forms.TextBox();
      this.lbl3 = new System.Windows.Forms.Label();
      this.groupBoxUserInfo = new System.Windows.Forms.GroupBox();
      this.isUserLogin = new System.Windows.Forms.Button();
      this.lbl8 = new System.Windows.Forms.Label();
      this.txtResult = new System.Windows.Forms.TextBox();
      this.lbl6 = new System.Windows.Forms.Label();
      this.txtUserName = new System.Windows.Forms.TextBox();
      this.lbl7 = new System.Windows.Forms.Label();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.isThereAUser = new System.Windows.Forms.Button();
      this.statusStripVersion = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabelCopyright = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabelVersion = new System.Windows.Forms.ToolStripStatusLabel();
      this.groupBoxAdminInfo.SuspendLayout();
      this.groupBoxUserInfo.SuspendLayout();
      this.statusStripVersion.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBoxAdminInfo
      // 
      this.groupBoxAdminInfo.Controls.Add(this.comboBoxConnectionType);
      this.groupBoxAdminInfo.Controls.Add(this.lbl5);
      this.groupBoxAdminInfo.Controls.Add(this.chckDisableCertCheck);
      this.groupBoxAdminInfo.Controls.Add(this.comboBoxPort);
      this.groupBoxAdminInfo.Controls.Add(this.txtAdminUserName);
      this.groupBoxAdminInfo.Controls.Add(this.isAdminConnect);
      this.groupBoxAdminInfo.Controls.Add(this.lbl1);
      this.groupBoxAdminInfo.Controls.Add(this.lbl2);
      this.groupBoxAdminInfo.Controls.Add(this.lbl4);
      this.groupBoxAdminInfo.Controls.Add(this.txtAdminPassword);
      this.groupBoxAdminInfo.Controls.Add(this.txtHost);
      this.groupBoxAdminInfo.Controls.Add(this.lbl3);
      this.groupBoxAdminInfo.Location = new System.Drawing.Point(9, 9);
      this.groupBoxAdminInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.groupBoxAdminInfo.Name = "groupBoxAdminInfo";
      this.groupBoxAdminInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.groupBoxAdminInfo.Size = new System.Drawing.Size(202, 301);
      this.groupBoxAdminInfo.TabIndex = 21;
      this.groupBoxAdminInfo.TabStop = false;
      this.groupBoxAdminInfo.Text = "LDAP Admin Bilgileri";
      // 
      // comboBoxConnectionType
      // 
      this.comboBoxConnectionType.FormattingEnabled = true;
      this.comboBoxConnectionType.Items.AddRange(new object[] {
            "ssl",
            "starttls"});
      this.comboBoxConnectionType.Location = new System.Drawing.Point(5, 215);
      this.comboBoxConnectionType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.comboBoxConnectionType.Name = "comboBoxConnectionType";
      this.comboBoxConnectionType.Size = new System.Drawing.Size(151, 21);
      this.comboBoxConnectionType.TabIndex = 12;
      // 
      // lbl5
      // 
      this.lbl5.AutoSize = true;
      this.lbl5.Location = new System.Drawing.Point(3, 198);
      this.lbl5.Name = "lbl5";
      this.lbl5.Size = new System.Drawing.Size(82, 15);
      this.lbl5.TabIndex = 13;
      this.lbl5.Text = "Bağlantı Şekli";
      // 
      // chckDisableCertCheck
      // 
      this.chckDisableCertCheck.AutoSize = true;
      this.chckDisableCertCheck.Checked = true;
      this.chckDisableCertCheck.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chckDisableCertCheck.Location = new System.Drawing.Point(5, 240);
      this.chckDisableCertCheck.Name = "chckDisableCertCheck";
      this.chckDisableCertCheck.Size = new System.Drawing.Size(163, 19);
      this.chckDisableCertCheck.TabIndex = 20;
      this.chckDisableCertCheck.Text = "Sertika Doğrulamayı Atla";
      this.chckDisableCertCheck.UseVisualStyleBackColor = true;
      // 
      // comboBoxPort
      // 
      this.comboBoxPort.FormattingEnabled = true;
      this.comboBoxPort.Items.AddRange(new object[] {
            "389",
            "636"});
      this.comboBoxPort.Location = new System.Drawing.Point(5, 171);
      this.comboBoxPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.comboBoxPort.Name = "comboBoxPort";
      this.comboBoxPort.Size = new System.Drawing.Size(151, 21);
      this.comboBoxPort.TabIndex = 10;
      // 
      // txtAdminUserName
      // 
      this.txtAdminUserName.Location = new System.Drawing.Point(5, 41);
      this.txtAdminUserName.Name = "txtAdminUserName";
      this.txtAdminUserName.Size = new System.Drawing.Size(151, 20);
      this.txtAdminUserName.TabIndex = 6;
      // 
      // isAdminConnect
      // 
      this.isAdminConnect.BackColor = System.Drawing.Color.Green;
      this.isAdminConnect.ForeColor = System.Drawing.Color.White;
      this.isAdminConnect.Location = new System.Drawing.Point(71, 263);
      this.isAdminConnect.Name = "isAdminConnect";
      this.isAdminConnect.Size = new System.Drawing.Size(126, 30);
      this.isAdminConnect.TabIndex = 15;
      this.isAdminConnect.Text = "LDAP Bağlan";
      this.isAdminConnect.UseVisualStyleBackColor = false;
      this.isAdminConnect.Click += new System.EventHandler(this.isAdminConnect_Click);
      // 
      // lbl1
      // 
      this.lbl1.AutoSize = true;
      this.lbl1.Location = new System.Drawing.Point(2, 24);
      this.lbl1.Name = "lbl1";
      this.lbl1.Size = new System.Drawing.Size(103, 15);
      this.lbl1.TabIndex = 5;
      this.lbl1.Text = "Admin Kullanı Adı";
      // 
      // lbl2
      // 
      this.lbl2.AutoSize = true;
      this.lbl2.Location = new System.Drawing.Point(1, 67);
      this.lbl2.Name = "lbl2";
      this.lbl2.Size = new System.Drawing.Size(70, 15);
      this.lbl2.TabIndex = 7;
      this.lbl2.Text = "Admin Şifre";
      // 
      // lbl4
      // 
      this.lbl4.AutoSize = true;
      this.lbl4.Location = new System.Drawing.Point(3, 155);
      this.lbl4.Name = "lbl4";
      this.lbl4.Size = new System.Drawing.Size(29, 15);
      this.lbl4.TabIndex = 11;
      this.lbl4.Text = "Port";
      // 
      // txtAdminPassword
      // 
      this.txtAdminPassword.Location = new System.Drawing.Point(5, 84);
      this.txtAdminPassword.Name = "txtAdminPassword";
      this.txtAdminPassword.Size = new System.Drawing.Size(151, 20);
      this.txtAdminPassword.TabIndex = 8;
      // 
      // txtHost
      // 
      this.txtHost.Location = new System.Drawing.Point(4, 127);
      this.txtHost.Name = "txtHost";
      this.txtHost.Size = new System.Drawing.Size(151, 20);
      this.txtHost.TabIndex = 10;
      // 
      // lbl3
      // 
      this.lbl3.AutoSize = true;
      this.lbl3.Location = new System.Drawing.Point(2, 110);
      this.lbl3.Name = "lbl3";
      this.lbl3.Size = new System.Drawing.Size(69, 15);
      this.lbl3.TabIndex = 9;
      this.lbl3.Text = "Host Adresi";
      // 
      // groupBoxUserInfo
      // 
      this.groupBoxUserInfo.Controls.Add(this.isUserLogin);
      this.groupBoxUserInfo.Controls.Add(this.lbl8);
      this.groupBoxUserInfo.Controls.Add(this.txtResult);
      this.groupBoxUserInfo.Controls.Add(this.lbl6);
      this.groupBoxUserInfo.Controls.Add(this.txtUserName);
      this.groupBoxUserInfo.Controls.Add(this.lbl7);
      this.groupBoxUserInfo.Controls.Add(this.txtPassword);
      this.groupBoxUserInfo.Controls.Add(this.isThereAUser);
      this.groupBoxUserInfo.Location = new System.Drawing.Point(226, 9);
      this.groupBoxUserInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.groupBoxUserInfo.Name = "groupBoxUserInfo";
      this.groupBoxUserInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.groupBoxUserInfo.Size = new System.Drawing.Size(376, 301);
      this.groupBoxUserInfo.TabIndex = 22;
      this.groupBoxUserInfo.TabStop = false;
      this.groupBoxUserInfo.Text = "Kullanıcı Bilgileri";
      // 
      // isUserLogin
      // 
      this.isUserLogin.BackColor = System.Drawing.Color.RoyalBlue;
      this.isUserLogin.ForeColor = System.Drawing.Color.White;
      this.isUserLogin.Location = new System.Drawing.Point(243, 81);
      this.isUserLogin.Name = "isUserLogin";
      this.isUserLogin.Size = new System.Drawing.Size(126, 30);
      this.isUserLogin.TabIndex = 17;
      this.isUserLogin.Text = "Şifreyle Girişi Doğrula";
      this.isUserLogin.UseVisualStyleBackColor = false;
      this.isUserLogin.Click += new System.EventHandler(this.isUserLogin_Click);
      // 
      // lbl8
      // 
      this.lbl8.AutoSize = true;
      this.lbl8.Location = new System.Drawing.Point(6, 112);
      this.lbl8.Name = "lbl8";
      this.lbl8.Size = new System.Drawing.Size(50, 15);
      this.lbl8.TabIndex = 16;
      this.lbl8.Text = "SONUÇ";
      // 
      // txtResult
      // 
      this.txtResult.Location = new System.Drawing.Point(8, 128);
      this.txtResult.Multiline = true;
      this.txtResult.Name = "txtResult";
      this.txtResult.Size = new System.Drawing.Size(362, 114);
      this.txtResult.TabIndex = 13;
      // 
      // lbl6
      // 
      this.lbl6.AutoSize = true;
      this.lbl6.Location = new System.Drawing.Point(5, 24);
      this.lbl6.Name = "lbl6";
      this.lbl6.Size = new System.Drawing.Size(54, 15);
      this.lbl6.TabIndex = 0;
      this.lbl6.Text = "Kullanıcı";
      // 
      // txtUserName
      // 
      this.txtUserName.Location = new System.Drawing.Point(8, 41);
      this.txtUserName.Name = "txtUserName";
      this.txtUserName.Size = new System.Drawing.Size(151, 20);
      this.txtUserName.TabIndex = 1;
      // 
      // lbl7
      // 
      this.lbl7.AutoSize = true;
      this.lbl7.Location = new System.Drawing.Point(5, 66);
      this.lbl7.Name = "lbl7";
      this.lbl7.Size = new System.Drawing.Size(32, 15);
      this.lbl7.TabIndex = 2;
      this.lbl7.Text = "Şifre";
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(8, 83);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(151, 20);
      this.txtPassword.TabIndex = 3;
      // 
      // isThereAUser
      // 
      this.isThereAUser.BackColor = System.Drawing.Color.DarkOrange;
      this.isThereAUser.ForeColor = System.Drawing.Color.White;
      this.isThereAUser.Location = new System.Drawing.Point(243, 38);
      this.isThereAUser.Name = "isThereAUser";
      this.isThereAUser.Size = new System.Drawing.Size(126, 30);
      this.isThereAUser.TabIndex = 14;
      this.isThereAUser.Text = "Kullanıcı Var Mı";
      this.isThereAUser.UseVisualStyleBackColor = false;
      this.isThereAUser.Click += new System.EventHandler(this.isThereAUser_Click);
      // 
      // statusStripVersion
      // 
      this.statusStripVersion.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.statusStripVersion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCopyright,
            this.toolStripStatusLabelVersion});
      this.statusStripVersion.Location = new System.Drawing.Point(0, 313);
      this.statusStripVersion.Name = "statusStripVersion";
      this.statusStripVersion.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
      this.statusStripVersion.Size = new System.Drawing.Size(614, 26);
      this.statusStripVersion.TabIndex = 23;
      this.statusStripVersion.Tag = "";
      this.statusStripVersion.Text = "statusStrip1asda";
      // 
      // toolStripStatusLabelCopyright
      // 
      this.toolStripStatusLabelCopyright.Name = "toolStripStatusLabelCopyright";
      this.toolStripStatusLabelCopyright.Size = new System.Drawing.Size(92, 20);
      this.toolStripStatusLabelCopyright.Text = "yasinsunmaz";
      // 
      // toolStripStatusLabelVersion
      // 
      this.toolStripStatusLabelVersion.Name = "toolStripStatusLabelVersion";
      this.toolStripStatusLabelVersion.Size = new System.Drawing.Size(35, 20);
      this.toolStripStatusLabelVersion.Text = "v1.0";
      // 
      // DirectoryServicesLDAPForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(614, 339);
      this.Controls.Add(this.statusStripVersion);
      this.Controls.Add(this.groupBoxUserInfo);
      this.Controls.Add(this.groupBoxAdminInfo);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "DirectoryServicesLDAPForm";
      this.Text = "DirectoryServices LDAP Kimlik Doğrulama";
      this.groupBoxAdminInfo.ResumeLayout(false);
      this.groupBoxAdminInfo.PerformLayout();
      this.groupBoxUserInfo.ResumeLayout(false);
      this.groupBoxUserInfo.PerformLayout();
      this.statusStripVersion.ResumeLayout(false);
      this.statusStripVersion.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdminInfo;
        private System.Windows.Forms.TextBox txtAdminUserName;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.GroupBox groupBoxUserInfo;
        private System.Windows.Forms.CheckBox chckDisableCertCheck;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Button isAdminConnect;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button isThereAUser;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.StatusStrip statusStripVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCopyright;
        private System.Windows.Forms.ComboBox comboBoxConnectionType;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Button isUserLogin;
  }
}

