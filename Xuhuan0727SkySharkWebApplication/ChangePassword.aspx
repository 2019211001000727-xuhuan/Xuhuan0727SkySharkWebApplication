<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="Xuhuan0727SkySharkWebApplication.Change" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    HOME
    <style type="text/css">
        .auto-style1 {
            height: 27px;
        }
        .auto-style2 {
            width: 505px;
        }
        .auto-style3 {
            height: 27px;
            width: 505px;
        }
        .auto-style4 {
            width: 226px;
        }
        .auto-style5 {
            height: 27px;
            width: 226px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="txtUser" runat="server" Text="Changing Password for:"></asp:Label>
                    </td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Specify a valid Password" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label2" runat="server" Text="Comfirm Password"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtConfPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Specify a valid ConfPassword " ControlToValidate="txtConfPassword"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfPassword" ErrorMessage="The passwords
 specified by you do not match.
Please try again.
"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    </td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td></td>
                    <td class="auto-style2"></td>
                </tr>

            </table>
        </div>
    </form>
</asp:Content>
