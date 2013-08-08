<%@ Page Title="" Language="C#" MasterPageFile="~/UserInterface/UserUI.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="eProjectSem3Team5.UserInterface.Login" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<link href="css/animate.css" rel="stylesheet" />--%>
    <%--<link href="css/reset.css" rel="stylesheet" />--%>
    <link href="css/styles.css" rel="stylesheet" />

    <div id="divCenterContent" runat="server" style="height: 380px;">
        <div id="container">
            <form id="frmLogin" runat="server">

                <label for="name">Email:</label>

                <input type="name" id="txtEmail" runat="server"/><label for="username">Password:</label>

                <p>
                    <a href="#">Forgot your password?</a>
                </p>

                <input type="password" id="txtPassword" runat="server" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="rqfPassword" runat="server" ErrorMessage="Password is empty" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>  <br />      
                <label id="lblError" runat="server" style="color:red" visible="false"> Your Email or Password is Incorrect </label>       
                <div id="lower">

                    <input type="checkbox" /><label class="check" for="checkbox">Keep me logged in</label>

                    <input type="button" value="Login" id="btnLogin" runat="server" />
                </div>
            </form>

        </div>


        <!-- End Page Content -->
    </div>
</asp:Content>
