<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Site1.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="eProjectSem3Team5.Admins.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                        <div class="box-head">
                            <h2 class="left">Products&nbsp; manager</h2>
                        </div>
                        <!-- End Box Head -->
                        <asp:Panel ID="pnlShow" runat="server">
                            <!-- Table -->
                            <table class="table">
                                <tr>
                                    <td>

                                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
                                            Width="100%" CellPadding="0"
                                            OnPageIndexChanging="GridView1_PageIndexChanging"
                                            OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting"
                                            OnRowEditing="GridView1_RowEditing" CellSpacing="4" AllowPaging="True">
                                            <Columns>
                                                <asp:BoundField DataField="ProductID" HeaderText="Product ID" />
                                                <asp:BoundField DataField="CategoryID" HeaderText="Category" />
                                                <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                                                <asp:BoundField DataField="Output" HeaderText="Output" />
                                                <asp:BoundField DataField="MadeGoodsSize" HeaderText="Made Goods Size" />
                                                <asp:BoundField DataField="MachineSize" HeaderText="Machine Size" />
                                                <asp:TemplateField>
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="lbtn_Update" runat="server" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"ProductID") %>' CommandName="edit" CssClass="edit" ToolTip="Edit"></asp:LinkButton>
                                                        <asp:LinkButton ID="lbtn_Delete" runat="server"
                                                            CommandArgument='<%# DataBinder.Eval(Container.DataItem,"ProductID") %>'
                                                            CommandName="delete" CssClass="delete" ToolTip="Delete" OnClientClick="return confirm=('Do you want to delete this item ?')"></asp:LinkButton>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                            <AlternatingRowStyle BackColor="White" />
                                            <PagerStyle BackColor="#CCCCCC" Font-Bold="true" HorizontalAlign="Center" />
                                            <PagerSettings Mode="Numeric" Position="Bottom" PageButtonCount="10" />
                                        </asp:GridView>

                                    </td>
                                </tr>
                            </table>
                            <!-- Table -->
                        </asp:Panel>
                        <asp:Panel ID="pnlUpdate" runat="server" Width="100%">
                            <div class="form">
                                <label>Update Item</label>
                                <div class="cl">&nbsp;</div>
                                <table class="auto-style3">
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label1" runat="server" CssClass="name_fild_row" Text="Category ID:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lbl_ProductId" runat="server" CssClass="name_fild_row" Width="150px"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label5" runat="server" CssClass="name_fild_row" Text="Category :" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="ddl_Category" runat="server" Width="150px">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label2" runat="server" CssClass="name_fild_row" Text="Product Name:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txt_ProductName" runat="server" Width="200px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label4" runat="server" CssClass="name_fild_row" Text="Output:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txt_Output" runat="server" Width="200px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label3" runat="server" CssClass="name_fild_row" Text="Made Goods Size:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txt_MadeGoods" runat="server" Width="200px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label6" runat="server" CssClass="name_fild_row" Text="Machine Size:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txt_MachineSize" runat="server" Width="200px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label7" runat="server" CssClass="name_fild_row" Text="Weight:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txt_Weight" runat="server" Width="200px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label8" runat="server" CssClass="name_fild_row" Text="Picture:" Width="150px"></asp:Label>
                                        </td>
                                        <td>                                   
                                            <asp:Image ID="img_upload" runat="server" Height="120px" Width="120px" />
                                            <br />
                                            <asp:FileUpload ID="Upload" runat="server" />                                           
                                            <br />
                                            <asp:Button ID="btnUpload" runat="server" CssClass="btnUpload" Font-Bold="True" Font-Size="XX-Small" ForeColor="#CC3300" Height="23px" Text="  Upload picture" Width="113px" OnClick="btnUpload_Click" />
                                            <br />
                                            <asp:Label ID="lbl_checkupload" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label9" runat="server" CssClass="name_fild_row" Text="UnitPrice:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txt_UnitPrice" runat="server" Width="200px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label10" runat="server" CssClass="name_fild_row" Text="AddedDate:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lbl_AddedDate" runat="server" CssClass="name_fild_row"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label12" runat="server" CssClass="name_fild_row" Text="FrequentlyViewed:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lbl_FrequentlyViewed" runat="server" CssClass="name_fild_row"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label11" runat="server" CssClass="name_fild_row" Text="ExtraDescription:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txt_ExtraDescription" runat="server" Width="200px" Rows="4" TextMode="MultiLine"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="name_fild_row">
                                            <asp:LinkButton ID="lbtn_update" runat="server" CssClass="update" OnClick="lbtn_update_Click">Update</asp:LinkButton>
                                            <asp:LinkButton ID="lbtn_Back" runat="server" CssClass="back" OnClick="lbtn_Back_Click">Return</asp:LinkButton>
                                        </td>
                                        <td>
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
                            <asp:LinkButton ID="lbtn_Add" CssClass="btnAdd" runat="server" OnClick="btnAdd_Click">Add new</asp:LinkButton>
                            <br />
                            <br />
                            <asp:LinkButton ID="lbtn_Refresh" CssClass="btnRefresh" runat="server" OnClick="lbtn_Refresh_Click">Refresh</asp:LinkButton>
                            <div class="cl">&nbsp;</div>
                            <!-- Sort -->
                            <div class="sort">
                                <label>Search by</label>
                                <br />
                                <asp:DropDownList ID="ddl_search" runat="server" Height="20px" Width="160px"></asp:DropDownList>

                                <br />
                                <br />
                                <asp:TextBox ID="txt_Search" runat="server" Width="160px" Height="16px"></asp:TextBox>
                                <asp:LinkButton ID="btnS" runat="server" CssClass="btnsearch"></asp:LinkButton>
                            </div>
                            <div class="cl">&nbsp;</div>
                            <div class="sort">
                                <label>Sort by</label>
                                <br />
                                <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="160px"></asp:DropDownList>
                            </div>
                            <div class="cl">&nbsp;</div>
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
