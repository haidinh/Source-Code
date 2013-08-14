<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MyWeb.Admins.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
  <title>Login Form</title>
  <link rel="stylesheet" href="../App_Themes/Admin/css/stylelogin.css"/>
  <!--[if lt IE 9]><script src="//html5shim.googlecode.com/svn/trunk/html5.js"></script><![endif]-->
</head>
<body runat="server">
  <section class="container">
    <div class="login">
      <h1>Login to Adminstrator</h1>
      <form method="post"  runat="server">
        <p><asp:TextBox ID="txt_Username" runat="server" ></asp:TextBox></p>
        <p><asp:TextBox ID="txt_Passoword" runat="server" TextMode="Password"></asp:TextBox></p>
        <p class="remember_me">
        </p>
        <p class="submit"><asp:Button ID="btn_Login" runat="server" Text="Login" OnClick="btnLogon_Click"></asp:Button></p>
      </form>
    </div>

  </section>

  <section class="about">
    <p class="about-author">
      &copy; 2012&ndash;2013 <a href="http://thibaut.me" target="_blank">Thibaut Courouble</a> -
      <a href="http://www.cssflow.com/mit-license" target="_blank">MIT License</a><br/>
      Original PSD by <a href="http://www.premiumpixels.com/freebies/clean-simple-login-form-psd/" target="_blank">Orman Clark</a>
  </section>
</body>
</html>
