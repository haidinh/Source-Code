<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Site1.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="eProjectSem3Team5.Admins.Category" %>

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
                        <!-- Box Head -->
                        <div class="box-head">
                            <h2 class="left">Careerer&nbsp; manager</h2>
                        </div>
                        <!-- End Box Head -->
                        <asp:Panel ID="pnlShow" runat="server">
                            <!-- Table -->
                            <table class="table">
                                <tr>
                                    <td >
                                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="3"
                                            OnPageIndexChanging="GridView1_PageIndexChanging"
                                            OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting"
                                            OnRowEditing="GridView1_RowEditing" CellSpacing="5" AllowPaging="True" OnSelectedIndexChanged="lbtn_Back_Click">
                                            <Columns>
                                                <asp:BoundField DataField="CategoryID" HeaderText="Category Id" />
                                                <asp:BoundField DataField="CategoryName" HeaderText="Category Name" />
                                                <asp:TemplateField HeaderText="Option">
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="lbtn_Update" runat="server"
                                                            CommandArgument='<%# DataBinder.Eval(Container.DataItem,"CategoryID") %>'
                                                            CommandName="edit" CssClass="edit" ToolTip="Edit"></asp:LinkButton>
                                                        <asp:LinkButton ID="lbtn_Delete" runat="server"
                                                            CommandArgument='<%# DataBinder.Eval(Container.DataItem,"CategoryID") %>'
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
                                <label>View Detail Category</label>
                                <div class="cl">&nbsp;</div>
                                <table>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label1" runat="server" CssClass="name_fild_row" Text="Category ID:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lbl_CateId" runat="server" CssClass="name_fild_row" Width="150px"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label5" runat="server" CssClass="name_fild_row" Text="Category Name:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txt_CateName" runat="server" Width="200px"></asp:TextBox>
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
                                <label>Search by </label>
                                <br />
                                <asp:DropDownList ID="ddl_Search" runat="server" Height="20px" Width="160px"></asp:DropDownList>

                                <br />
                                <br />
                                <asp:TextBox ID="txt_Search" runat="server" Width="160px" Height="16px"></asp:TextBox>
                                <asp:LinkButton ID="btnS" runat="server" CssClass="btnsearch" OnClick="lbtn_Search_Click"></asp:LinkButton>
                            </div>
                            <div class="cl">&nbsp;</div>
                            <div class="sort">
                                <label>Sort by</label>
                                <br />
                                <asp:DropDownList ID="ddl_Sort" runat="server" Height="20px" Width="160px"></asp:DropDownList>
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
