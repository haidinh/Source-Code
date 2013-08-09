<%@ Page Title="" Language="C#" MasterPageFile="~/UserInterface/UserUI.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="eProjectSem3Team5.UserInterface.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="center_title_bar" id="title" runat="server"> </div>
    <div style="float:left;height:400px;width:300px;"> 
        <div style="height:180px; width:230px; margin:10px 10px 10px 10px;"> <asp:Image ID="imgProduct" runat="server" Width="230px" Height="180px"/></div>
        <div style="height:60px; width:200px; margin:0px 0px 10px 10px;text-align:center;font-size:13px;color:red;" id="divDetailPrice" runat="server"> </div>
    </div>
    <div style="float:left;height:400px;width:300px; padding-top:10px;"> 
        <asp:GridView ID="gvDetailProduct" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="96%" style="margin-bottom: 0px" Font-Size="Larger">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </div>

    </form>

</asp:Content>
