<%@ Page Title="" Language="C#" MasterPageFile="~/UserInterface/UserUI.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="eProjectSem3Team5.UserInterface.SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<link href="css%20SignUp/demo.css" rel="stylesheet" />--%>
    <link href="css%20SignUp/style.css" rel="stylesheet" />

    <div class="center_content" id="divCenterContent" runat="server">
        <div class="form">
            <form id="contactform" runat="server" style="height:auto;">

                <p class="contact">
                    <label for="email">Email</label>
                </p>
                <input id="txtEmail" name="email" runat="server" placeholder="example@domain.com" type="email" />
                <p class="contact">
                    <label for="password">Choose a password</label>
                </p>
                <input type="password" id="txtPassword" runat="server" name="password" />
                <br /><asp:RequiredFieldValidator ID="rqfPassword" runat="server" ErrorMessage="Password is empty" ForeColor="Red" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                <p class="contact">
                    <label for="repassword">Confirm your password</label>
                </p>
                <input type="password" id="txtRePassword" runat="server" name="repassword" required="" controltovalidate="txtRePassword" />
                <br /><asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="The password is NOT the same" ControlToCompare="txtPassword" ControlToValidate="txtRePassword" ForeColor="Red"></asp:CompareValidator>
                <p class="contact">
                    <label for="name">User Name</label>
                </p>
                <input id="txtName" runat="server" name="name" placeholder="First and last name"  tabindex="1" type="text" />
                <br /><asp:RequiredFieldValidator ID="rqfUserName" runat="server" ErrorMessage="UserName is empty" ControlToValidate="txtName" ForeColor="Red"></asp:RequiredFieldValidator>
                <br /><br /><br />
                <input class="buttom" name="submit" id="btnSignUp" runat="server" tabindex="5" value="Sign me up!" type="button" />
                <label id="lblSignUpError" runat="server" style="color: red" visible="false">this Email has already been registered  </label>
            </form>
        </div>

    </div>
</asp:Content>
