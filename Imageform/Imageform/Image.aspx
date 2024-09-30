<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Image.aspx.cs" Inherits="Imageform.Image" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Image Upload</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 76px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            width: 76px;
            height: 26px;
        }
        .auto-style5 {
            height: 30px;
        }
        .auto-style6 {
            width: 76px;
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4">Name</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6">Image</td>
                    <td class="auto-style5">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">Signature</td>
                    <td>
                        <asp:FileUpload ID="FileUpload2" runat="server" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Image ID="Image1" runat="server" Width="200px" Height="200px" />
                        <asp:Image ID="Image2" runat="server" Width="200px" Height="200px"  />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>