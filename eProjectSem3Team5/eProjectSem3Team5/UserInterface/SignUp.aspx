<%@ Page Title="" Language="C#" MasterPageFile="~/UserInterface/UserUI.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="eProjectSem3Team5.UserInterface.SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="css%20SignUp/demo.css" rel="stylesheet" />
    <link href="css%20SignUp/style.css" rel="stylesheet" />

    <div class="center_content" id="divCenterContent" runat="server">        
        <div class="form">
            <form id="contactform" runat="server">

                <p class="contact">
                    <label for="email">Email</label></p>
                <input id="txtEmail" name="email" runat="server" placeholder="example@domain.com" required="" type="email">

                <p class="contact">
                    <label for="password">Create a password</label></p>
                <input type="password" id="txtPassword" runat="server" name="password" required="">
                <p class="contact">
                    <label for="repassword">Confirm your password</label></p>
                <input type="password" id="txtRePassword" runat="server" name="repassword" required="">
                <p class="contact">
                    <label for="name">User Name</label></p>
                <input id="txtName" runat="server" name="name" placeholder="First and last name" required="" tabindex="1" type="text">                             
                <br>
                <input class="buttom" name="submit" id="btnSignUp" runat="server" tabindex="5" value="Sign me up!" type="button">
                <label id="lblSignUpError" runat="server" style="color:red" visible="false"> this Email has already been registered  </label> 
            </form>
        </div>

    </div>
</asp:Content>
