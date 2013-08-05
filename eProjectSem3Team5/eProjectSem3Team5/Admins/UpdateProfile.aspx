<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="eProjectSem3Team5.Admins.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="pnlUpdate" runat="server" Width="100%">
        <table class="style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" CssClass="name_fild_row" Text="Username:" Width="150px"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbl_Username" runat="server" CssClass="name_fild_row" Width="150px"></asp:Label>
                </td>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" CssClass="name_fild_row" Text="My name:" Width="150px"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txt_Name" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" CssClass="name_fild_row" Text="Email:" width="150px"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txt_Email" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_Email" ErrorMessage="Invalid Email" Font-Bold="True" ForeColor="#CC0000"></asp:RegularExpressionValidator>
                    </td>
                </tr>    
                 <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" CssClass="name_fild_row" Text="Old Password:" Width="150px"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_Pass" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                </td>              
                </tr>
                <tr>
                    <td class="name_fild_row">
                        <asp:LinkButton ID="lbtn_update" runat="server" CssClass="update" onclick="lbtn_update_Click">Update</asp:LinkButton>
                        <asp:LinkButton ID="lbtn_Back" runat="server" CssClass="back" onclick="lbtn_Back_Click">Return</asp:LinkButton>
                    </td>
                    <td>
                        <asp:Label ID="lbl_catch" runat="server" Font-Bold="True" ForeColor="#CC0000" Width="200px"></asp:Label>
                    </td>
                </tr>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="pnlalart" runat="server" Height="24px" Width="100%">
        <asp:Label ID="lbl_alart" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#0066CC" Text="Successfully updated profile"></asp:Label>
    </asp:Panel>

</asp:Content>
