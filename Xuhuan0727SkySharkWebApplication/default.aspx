<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Xuhuan0727SkySharkWebApplication._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    HOME
    <style type="text/css">
        .auto-style1 {
            height: 27px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Welcome to Shyshark Airline Home Page</h1>
    <asp:Image ID="Image1" runat="server" ImageUrl="~/skyShark.png" Width="850px" Height="260px"/>
    <p>Launched in 1999, SkyShark Airlines is a United States-based airline that has rapidly grown in the past years.</p>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red" Font-Bold="True"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style1">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" EnableViewState="False" ErrorMessage="Please specify a valid user name."></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Please specify a valid password"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
            </table>
        </div>
    </form>
</asp:Content>
