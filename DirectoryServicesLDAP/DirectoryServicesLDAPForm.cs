using System;
using System.DirectoryServices.Protocols;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace DirectoryServicesLDAP
{
  public partial class DirectoryServicesLDAPForm : Form
  {
    public DirectoryServicesLDAPForm()
    {
      InitializeComponent();
    }

    private System.DirectoryServices.Protocols.LdapConnection _ldapConnectionAdmin;
    private SearchResponse _ldapSearchResponse;
    private string userName;
    private string userDNInfo;

    //LDAP Admin Bağlanma Yönetimi
    private void isAdminConnect_Click(object sender, EventArgs e)
    {
      bool isAdminLdapConnect = isAdminConnectDAP();
      if (isAdminLdapConnect)
      {
        MessageBox.Show("LDAP Bağlantısı Başarılı!");
      }
      else
      {
        MessageBox.Show("LDAP Bağlantısı Başarısız!");
      }
    }

    //LDAP Admin Bağlanma
    private bool isAdminConnectDAP()
    {
      bool status = false;
      string host = txtHost.Text;
      string portValue = comboBoxPort.Text;
      string adminUser = txtAdminUserName.Text;
      string adminPass = txtAdminPassword.Text;
      string ldapSecurityMethod = comboBoxConnectionType.Text;
      bool isDisableCertCheck = chckDisableCertCheck.Checked;

      try
      {
        //LDAP Parametre validasyon kontrolü
        if (isAdminValidation(host, portValue, adminUser, adminPass, ldapSecurityMethod))
        {
          int port = int.Parse(comboBoxPort.Text);
          _ldapConnectionAdmin = new System.DirectoryServices.Protocols.LdapConnection(host + ":" + port);

          NetworkCredential authAdmin = new System.Net.NetworkCredential(adminUser, adminPass);
          _ldapConnectionAdmin.Credential = authAdmin;
          _ldapConnectionAdmin.AuthType = AuthType.Basic;
          _ldapConnectionAdmin.SessionOptions.ProtocolVersion = 3;
          //Port 636 SSL içindir
          if (port == 636)
          {
            ldapProtocolsSecurityMethod(_ldapConnectionAdmin, ldapSecurityMethod, isDisableCertCheck);
          }
          _ldapConnectionAdmin.Bind();
          status = true;
        }
        else
        {
          MessageBox.Show("Tüm bilgiler girilmelidir!");
        }
        return status;
      }
      catch (Exception ex)
      {
        _ldapConnectionAdmin.Dispose();
        txtResult.Text = "Admin LDAP bağlantısı gerçekleşmedi! Mesaj: " + ex.Message;
        return status;
      }
    }

    //Admin Bilgi Validasyon İşlemleri
    private bool isAdminValidation(string host, string port, string adminUser, string adminPass, string ldapSecurityMethod)
    {
      if (host == "" || port == "" || adminUser == "" || adminPass == "" || ldapSecurityMethod == "")
      {
        return false;
      }
      return true;
    }

    //Kullanıcı Arama
    private void isThereAUser_Click(object sender, EventArgs e)
    {
      bool isThereUser = isThereAUserValid();
      if (isThereUser)
      {
        MessageBox.Show("Kullanıcı bulundu!");
      }
      else
      {
        MessageBox.Show("Kullanıcı bulunamadı!");
      }
    }

    //Kullanıcı Arama
    private bool isThereAUserValid()
    {
      bool status = false;
      try
      {
        if (!string.IsNullOrEmpty(txtUserName.Text))
        {
          userName = txtUserName.Text;
          //LDAP aranacak DN bilgisi
          string dn = "dc=abc";

          //LDAP injection saldırılarını önlemek için LDAP arama filtresinden çıkarma
          userName = EscapeLdapSearchFilter(userName);

          System.DirectoryServices.Protocols.SearchRequest ldapSearchRequest;
          ldapSearchRequest = new SearchRequest(dn, string.Format("(&(objectClass=*)(status=active)(|(identity=" + userName + ")(email=" + userName + ")))"), SearchScope.Subtree, null);
          if (_ldapConnectionAdmin != null)
          {
            _ldapSearchResponse = (SearchResponse)_ldapConnectionAdmin.SendRequest(ldapSearchRequest);
            if (_ldapSearchResponse.Entries.Count > 0)
            {
              userDNInfo = _ldapSearchResponse.Entries[0].DistinguishedName;
              //LDAP kullanıcısının detaylı bilgilerini alma - Kullanıcıya ait email bilgisini çekme
              //var attrValue = rsp.Entries[0].Attributes["email"][0].ToString();
              status = true;
            }
          }
          else
          {
            MessageBox.Show("Öncelikle LDAP Bağlantısı Yapmalısınız!");
          }
        }
        else
        {
          MessageBox.Show("Kullanıcı boş geçilemez!");
        }

        return status;
      }
      catch (Exception ex)
      {
        _ldapConnectionAdmin.Dispose();
        txtResult.Text = "Kullanıcı bulunamadı! Mesaj: " + ex.Message;
        return status;
      }
    }

    //Kullanıcı Girişi Doğrulama
    private void isUserLogin_Click(object sender, EventArgs e)
    {
      bool isUserLogin = isUserLoginAuth();
      if (isUserLogin)
      {
        MessageBox.Show("Kullanıcı giriş doğrulandı!");
      }
      else
      {
        MessageBox.Show("Kullanıcı girişi başarısız!");
      }
    }

    //Kullanıcı Giriş Yönetimi
    private bool isUserLoginAuth()
    {
      bool status = false;

      //Mevcut kullanıcı dn  bilgisi varsa direk giriş doğrulama yapılsın
      if (userDNInfo != null)
      {
        return isUserLoginAuthentication();
      }
      else
      {
        //Kullanıcıya ait dn bilgisi yoksa önce kullanıcı var mı bakılıp dn bilgisinin dolması sağlanır
        if (isThereAUserValid())
        {
          //Kullanıcı bulunduktan sonra dn bilgisi doldurulduğu için giriş doğrulama yapılsın
          return isUserLoginAuthentication();
        }
      }
      return status;
    }

    //Kullanıcı Giriş Doğrulama
    private bool isUserLoginAuthentication()
    {
      bool status = false;
      string host = txtHost.Text;
      string portValue = comboBoxPort.Text;
      string ldapSecurityMethod = comboBoxConnectionType.Text;
      bool isDisableCertCheck = chckDisableCertCheck.Checked;
      string userPassword = txtPassword.Text;
      userName = txtUserName.Text;
      if (isUserValidation(host, portValue, userName, userPassword, ldapSecurityMethod))
      {
        int port = int.Parse(comboBoxPort.Text);
        System.DirectoryServices.Protocols.LdapConnection connUserLogin = new System.DirectoryServices.Protocols.LdapConnection(host + ":" + port);
        try
        {
          NetworkCredential auth2 = new System.Net.NetworkCredential(userDNInfo, userPassword);
          connUserLogin.Credential = auth2;
          connUserLogin.AuthType = AuthType.Basic;

          connUserLogin.SessionOptions.ProtocolVersion = 3;

          if (port == 636)
          {
            ldapProtocolsSecurityMethod(connUserLogin, ldapSecurityMethod, isDisableCertCheck);
          }

          connUserLogin.Bind();
          status = true;
          connUserLogin.Dispose();
        }
        catch (Exception ex)
        {
          txtResult.Text = "Kullanıcı giriş doğrulaması başarısız! Mesaj: " + ex.Message;
          connUserLogin.Dispose();
        }
      }
      else
      {
        MessageBox.Show("Host, port, bağlantı şekli, kullanıcı ve şifre alanları girilmelidir!");
      }
      return status;
    }

    //Kullanıcı Giriş Validasyon İşlemleri
    private bool isUserValidation(string host, string port, string userName, string userPassword, string ldapSecurityMethod)
    {
      if (host == "" || port == "" || userName == "" || userPassword == "" || ldapSecurityMethod == "")
      {
        return false;
      }
      return true;
    }

    //SSL 636 Port Bağlantıları
    private static void ldapProtocolsSecurityMethod(System.DirectoryServices.Protocols.LdapConnection _ldapProtocolsConnection, string ldapSecurityMethod, bool isDisableCertCheck)
    {
      if (ldapSecurityMethod == "ssl")
      {
        //SSL doğrulamayı geç
        if (isDisableCertCheck)
        {
          _ldapProtocolsConnection.SessionOptions.VerifyServerCertificate += delegate { return true; };
        }
        _ldapProtocolsConnection.SessionOptions.SecureSocketLayer = true;
      }
      else if (ldapSecurityMethod == "starttls")
      {
        //SSL doğrulamayı geç
        if (isDisableCertCheck)
        {
          _ldapProtocolsConnection.SessionOptions.VerifyServerCertificate += delegate { return true; };
        }
        _ldapProtocolsConnection.SessionOptions.SecureSocketLayer = false;
        _ldapProtocolsConnection.SessionOptions.StartTransportLayerSecurity(null);
      }
    }

    /// <summary>
    /// Escapes the LDAP search filter to prevent LDAP injection attacks.
    /// </summary>
    /// <param name="searchFilter">The search filter.</param>
    /// <returns>The escaped search filter.</returns>
    private static string EscapeLdapSearchFilter(string searchFilter)
    {
      var escape = new StringBuilder();
      foreach (var current in searchFilter)
      {
        switch (current)
        {
          case '\\':
            escape.Append(@"\5c");
            break;

          case '*':
            escape.Append(@"\2a");
            break;

          case '(':
            escape.Append(@"\28");
            break;

          case ')':
            escape.Append(@"\29");
            break;

          case '\u0000':
            escape.Append(@"\00");
            break;

          case '/':
            escape.Append(@"\2f");
            break;

          default:
            escape.Append(current);
            break;
        }
      }

      return escape.ToString();
    }
  }
}