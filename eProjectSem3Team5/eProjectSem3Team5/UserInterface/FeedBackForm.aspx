<%@ Page Title="" Language="C#" MasterPageFile="~/UserInterface/UserUI.Master" AutoEventWireup="true" CodeBehind="FeedBackForm.aspx.cs" Inherits="eProjectSem3Team5.UserInterface.FeedBackForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="css/freecontactform.css" rel="stylesheet" />
    <form id="feedBackForm" runat="server" >
        <table width="400px" class="freecontactform">
            <tr>
                <td colspan="2">

                    <div class="freecontactformheader">FeedBack Form</div>

                   
                </td>
            </tr>
            <tr>
                <td valign="top" style="width: 111px">
                    <label for="Full_Name" class="required">Full Name<span class="required_star"> * </span></label>
                </td>
                <td valign="top">
                    <input type="text" name="Full_Name" id="txtFullName" runat="server" maxlength="80" style="width: 230px" /><br />
                    <asp:RequiredFieldValidator ID="rfvFullName" runat="server" ErrorMessage="the field Full Name must be filled" ControlToValidate="txtFullName" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td valign="top" style="width: 111px">
                    <label for="Email_Address" class="required">Email Address<span class="required_star"> * </span></label>
                </td>
                <td valign="top">
                    <input type="text" name="Email_Address" id="txtEmail" runat="server" maxlength="100" style="width: 230px" /><br />
                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="the field Email must be filled" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td valign="top" style="width: 111px">
                    <label for="Telephone_Number" class="not-required">Company Name </label>
                </td>
                <td valign="top">
                    <input type="text" name="Telephone_Number" id="txtCompanyName" maxlength="100" style="width: 230px" />
                </td>
            </tr>
            <tr>
                <td valign="top" style="width: 111px">
                    <label for="Telephone_Number" class="not-required">Address </label>
                </td>
                <td valign="top">
                    <input type="text" name="Telephone_Number" id="txtAddress" runat="server" maxlength="100" style="width: 230px" />
                </td>
            </tr>
            <tr>
                <td valign="top" style="width: 111px">
                    <label for="Telephone_Number" class="not-required"> City </label>
                </td>
                <td valign="top">
                    <input type="text" name="Telephone_Number" id="txtCity" runat="server" maxlength="100" style="width: 230px" />
                </td>
            </tr>
            <tr>
                <td valign="top" style="width: 111px">
                    <label for="Telephone_Number" class="not-required"> Nation </label>
                </td>
                <td valign="top">
                    <input type="text" name="Telephone_Number" id="txtNation" runat="server" maxlength="100" style="width: 230px" />
                </td>
            </tr>
            <tr>
                <td valign="top" style="width: 111px">
                    <label for="Telephone_Number" class="not-required">Phone Number</label>
                </td>
                <td valign="top">
                    <input type="text" name="Telephone_Number" id="txtPhoneNumber" runat="server" maxlength="100" style="width: 230px" />
                </td>
            </tr>
            <tr>
                <td valign="top" style="width: 111px">
                    <label for="Telephone_Number" class="not-required">Postal Code</label>
                </td>
                <td valign="top">
                    <input type="text" name="Telephone_Number" id="txtPostalCode" maxlength="100" style="width: 230px" />
                </td>
            </tr>
             <tr>
                <td valign="top" style="width: 111px">
                    <label for="Full_Name" class="required"> Subject <span class="required_star"> * </span></label>
                </td>
                <td valign="top">
                    <input type="text" name="Full_Name" id="txtSubject" runat="server" maxlength="80" style="width: 230px" /><br />
                    <asp:RequiredFieldValidator ID="rfvSubject" runat="server" ControlToValidate="txtSubject" ErrorMessage="the field Subject must be filled" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td valign="top" style="width: 111px">
                    <label for="Your_Message" class="required">Your Message<span class="required_star"> * </span></label>
                </td>
                <td valign="top">
                    <textarea style="width: 230px; height: 160px" name="Your_Message" id="txtAreaMessage" runat="server" cols="5" rows="10" ></textarea><br />
                    <asp:RequiredFieldValidator ID="rfvMessage" runat="server" ControlToValidate="txtAreaMessage" ErrorMessage="the field Message must be filled" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <%--<div class="antispammessage">
                        To help prevent automated spam, please answer this question
	  <br />
                        <br />
                        <div class="antispamquestion">
                            <span class="required_star">* </span>
                            Using only numbers, what is 10 plus 15? &nbsp; 
		   <input type="text" name="AntiSpam" id="AntiSpam" maxlength="100" style="width: 30px">
                        </div>
                    </div>--%>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">                   
                    
                    <input type="button" value="Submit Form" class="feed_back" id="btnSubmit" runat="server" />
                </td>
            </tr>
        </table>
    </form>
</asp:Content>
