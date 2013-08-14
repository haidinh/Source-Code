<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="eProjectSem3Team5.Admins.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 14px;
            color: #BA4C32;
            font-weight: bold;
            text-align: start;
            vertical-align: middle;
            padding-right: 5px;
            height: 16px;
        }
        .auto-style2
        {
            height: 16px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="container">
        <div class="shell">
            <!-- Main -->
            <div id="main">
                <div class="cl">&nbsp;</div>

                <!-- Content -->
                <div id="content">

                    <!-- Box -->
                    <div class="box">
               
                        <asp:Panel ID="pnlShow" runat="server">
                            <!-- Table -->
                            <div class="box-head">
                                <h2 class="left">My Account</h2>
                            </div>
                            <div class="form">
                                <table class="style1">
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label8" runat="server" CssClass="labeltitle" Text="Username:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lbl_Username" runat="server" CssClass="labelshow" Width="150px"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label12" runat="server" CssClass="labeltitle" Text="Full name:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lbl_Name" runat="server" CssClass="labelshow" Width="150px"></asp:Label>
                                        </td>
                                    </tr>                           
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label15" runat="server" CssClass="labeltitle" Text="Email:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lbl_Email" runat="server" CssClass="labelshow" Width="150px"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <!-- Table -->
                        </asp:Panel>

                        <asp:Panel ID="pnlChangePass" runat="server" Width="100%">
                             <div class="box-head">
                                <h2 class="left">Change Password</h2>
                            </div>
                            <div class="form">
                                <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" CssClass="name_fild_row" Text="Username:" Width="150px"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_UsernamePass" runat="server" CssClass="name_fild_row" Width="150px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" CssClass="name_fild_row" Text="Old Password:" Width="150px"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txt_OldPass" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" CssClass="name_fild_row" Text="New Password:" Width="150px"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txt_Password" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" CssClass="name_fild_row" Text="Confirm Password:" Width="150px"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txt_ConfirmPass" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:LinkButton ID="lbn_UpdatePass" runat="server" CssClass="update" OnClick="lbtn_change_Click">Update</asp:LinkButton>

                    </td>
                    <td class="auto-style2">
                        <asp:Label ID="lbl_catchPass" runat="server" Font-Bold="True" Width="200px" ForeColor="#CC0000"></asp:Label>
                    </td>
                </tr>
            </table>
                            </div>
                        </asp:Panel>

                        <asp:Panel ID="pnlUpdate" runat="server" Width="100%">
                             <div class="box-head">
                                <h2 class="left">Update Profile</h2>
                            </div>
                            <div class="form">
                                 <table class="style1">
                <tr>
                    <td>
                        <asp:Label ID="Label14" runat="server" CssClass="name_fild_row" Text="Username:" Width="150px"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_UsernamePro" runat="server" CssClass="name_fild_row" Width="150px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label17" runat="server" CssClass="name_fild_row" Text="My name:" Width="150px"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txt_Name" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label18" runat="server" CssClass="name_fild_row" Text="Email:" Width="150px"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txt_Email" runat="server" Width="200px"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_Email" ErrorMessage="Invalid Email" Font-Bold="True" ForeColor="#CC0000"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label19" runat="server" CssClass="name_fild_row" Text="Password:" Width="150px"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txt_Pass" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:LinkButton ID="lbtn_update" runat="server" CssClass="update" OnClick="lbtn_update_Click">Update</asp:LinkButton>
                    </td>
                    <td class="auto-style2">
                        <asp:Label ID="lbl_catch" runat="server" Font-Bold="True" ForeColor="#CC0000" Width="200px"></asp:Label>
                    </td>
                </tr>

            </table>
                            </div>
                        </asp:Panel>
                    </div>
                    <!-- End Box -->

                </div>
                <!-- End Content -->

                <!-- Sidebar -->
                <div id="sidebar">

                    <!-- Box -->
                    <div class="box">

                     
                        <!-- Box Head -->
                        <div class="box-head">
                            <h2>Management</h2>
                        </div>
                        <!-- End Box Head-->

                        <div class="box-content">
                            <asp:LinkButton ID="lbtn_view" runat="server" OnClick="lbtn_view_Click" CssClass="btnMyAccount">My Account</asp:LinkButton>
                            <br />
                            <br />
                            <asp:LinkButton ID="lbtn_changepassword" runat="server" OnClick="lbtn_changepassword_Click" CssClass="btnChangePass">Change Password</asp:LinkButton>
                            <br />
                            <br />
                            <asp:LinkButton ID="lbtn_updateprofile" runat="server" OnClick="lbtn_updateprofile_Click" CssClass="btnUpdateProfile">Change Profile </asp:LinkButton>
                            <br />
                            <div class="cl">&nbsp;</div>
                            <!-- Sort -->     
                            <!-- End Sort -->

                        </div>
                    </div>
                    <!-- End Box -->
                </div>
                <!-- End Sidebar -->

                <div class="cl">&nbsp;</div>
            </div>
            <!-- Main -->
        </div>
    </div>
</asp:Content>
