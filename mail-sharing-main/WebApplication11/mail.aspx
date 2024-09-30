<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mail.aspx.cs" Inherits="WebApplication11.mail" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Email Form</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        td {
            padding: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>From</td>
                <td><asp:TextBox ID="txt_from" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password</td>
                <td><asp:TextBox ID="txt_pwd" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr class="auto-style2"></tr>
            <tr>
                <td>To</td>
                <td><asp:TextBox ID="txt_to" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Subject</td>
                <td><asp:TextBox ID="txt_subject" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Body</td>
                <td><asp:TextBox ID="txt_body" runat="server" TextMode="MultiLine" Rows="5"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btn_submit_email" runat="server" OnClick="btn_submit_email_Click" Text="Send Email" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
