<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Site1.Master" AutoEventWireup="true" CodeBehind="GuestFeedBack.aspx.cs" Inherits="eProjectSem3Team5.Admins.GuestFeedBack" %>

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
                            <h2 class="left">Feedback&nbsp; manager</h2>
                        </div>
                        <!-- End Box Head -->
                        <asp:Panel ID="pnlShow" runat="server">
                            <!-- Table -->
                            <table class="table">
                                <tr>
                                    <td>
                                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="3" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCommand="GridView1_RowCommand" AllowPaging="True" CellSpacing="5">
                                            <AlternatingRowStyle BackColor="White" />

                                            <Columns>
                                                <asp:BoundField DataField="FeedBackID" HeaderText="FeedBackID" />
                                                <asp:BoundField DataField="Email" HeaderText="Email" />
                                                <asp:BoundField DataField="FullName" HeaderText="Full Name" />
                                                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" />
                                                <asp:BoundField DataField="Address" HeaderText="Address" />
                                                <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" />
                                                <asp:TemplateField>
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="lbtn_View" runat="server" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"CareererID")%>' CommandName="view" CssClass="btnview" ToolTip="View detail"></asp:LinkButton>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                            <PagerStyle BackColor="#CCCCCC" Font-Bold="true" HorizontalAlign="Center" />
                                            <PagerSettings Mode="Numeric" PageButtonCount="10" Position="Bottom" />
                                        </asp:GridView>
                                    </td>
                                </tr>
                            </table>
                            <!-- Table -->
                        </asp:Panel>
                        <asp:Panel ID="pnlUpdate" runat="server" Width="100%">
                            <div class="form">
                                <label>View Detail Feedback</label>
                                <div class="cl">&nbsp;</div>
                                <table class="style1">
                                    <tr>
                                        <td class="auto-style1">
                                            <asp:Label ID="Label1" runat="server" CssClass="name_fild_row" Text="FeedBack Id:" Width="150px"></asp:Label>
                                        </td>
                                        <td class="auto-style1">
                                            <asp:Label ID="lbl_FeedBackId" runat="server" CssClass="name_fild_row" Width="150px"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label2" runat="server" CssClass="name_fild_row" Text="Email Adress:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lbl_EmailAdress" runat="server" CssClass="name_fild_row" Width="150px"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label4" runat="server" CssClass="name_fild_row" Text="Full Name:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lbl_Fullname" runat="server" CssClass="name_fild_row" Width="150px"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label6" runat="server" CssClass="name_fild_row" Text="Company name:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lbl_CompanyName" runat="server" CssClass="name_fild_row" Width="150px"></asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <asp:Label ID="Label3" runat="server" CssClass="name_fild_row" Text="Address:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lbl_Address" runat="server" CssClass="name_fild_row" Width="150px"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label5" runat="server" CssClass="name_fild_row" Text="City:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lbl_City" runat="server" CssClass="name_fild_row" Width="150px"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label10" runat="server" CssClass="name_fild_row" Text="Nation:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lbl_Nation" runat="server" CssClass="name_fild_row" Width="150px"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label9" runat="server" CssClass="name_fild_row" Text="PhoneNumber:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lbl_PhoneNumber" runat="server" CssClass="name_fild_row" Width="150px"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label7" runat="server" CssClass="name_fild_row" Text="Postal Code:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lbl_PostalCode" runat="server" CssClass="name_fild_row" Width="150px"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label11" runat="server" CssClass="name_fild_row" Text="Subject:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lbl_Subject" runat="server" CssClass="name_fild_row" Width="150px"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label13" runat="server" CssClass="name_fild_row" Text="Comment:" Width="150px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txt_Comment" runat="server" ReadOnly="True" Rows="4" TextMode="MultiLine" Width="300px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style1">
                                            <asp:LinkButton ID="lbtn_Back" runat="server" CssClass="back" OnClick="lbtn_Back_Click">Return</asp:LinkButton>

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
