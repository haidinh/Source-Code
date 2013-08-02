<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadPhotos.aspx.cs" Inherits="eProjectSem3Team5.UserInterface.UploadPhotos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 100%;
        }
        .auto-style2
        {
            width: 248px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Photo Name"></asp:Label>
&nbsp;
                    <asp:TextBox ID="txtPhotoName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Image ID="Image1" runat="server" />
                </td>
                <td>
                    <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click1" Text="Save" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
