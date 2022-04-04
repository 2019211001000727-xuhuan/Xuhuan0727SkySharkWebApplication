<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Logoff.aspx.cs" Inherits="Xuhuan0727SkySharkWebApplication.Logoff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    HOME
    <style type="text/css">
        #TextArea1 {
            height: 227px;
            width: 863px;
        }
    </style>
    <style type="text/css">
        #TextArea1 {
            height: 300px;
            width: 868px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div>
    <textarea id="TextArea1">
        Thank you for using SkyShark Airline.
        Looking forward for serving you again.
    </textarea><br />
&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/default.aspx">Click Here to Login</asp:HyperLink>
    </div>
    </form>
</asp:Content>
