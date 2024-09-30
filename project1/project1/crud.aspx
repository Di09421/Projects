<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="project1.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 272px;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            width: 53px;
        }
        .auto-style4 {
            width: 53px;
        }
        .auto-style5 {
            height: 23px;
            width: 208px;
        }
        .auto-style6 {
            width: 208px;
        }
        .auto-style7 {
            height: 23px;
            width: 64px;
        }
        .auto-style8 {
            width: 64px;
        }
        .auto-style9 {
            width: 53px;
            height: 1px;
        }
        .auto-style10 {
            width: 208px;
            height: 1px;
        }
        .auto-style11 {
            width: 64px;
            height: 1px;
        }
        .auto-style12 {
            height: 1px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Name</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style7"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style4">DOB</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style8">Age</td>
                    <td>
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">DOJ</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style8">Mobile</td>
                    <td>
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Address</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">City</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style7"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style4">State</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style8">Country</td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style10"></td>
                    <td class="auto-style11"></td>
                    <td class="auto-style12"></td>
                    <td class="auto-style12"></td>
                    <td class="auto-style12"></td>
                    <td class="auto-style12"></td>
                    <td class="auto-style12"></td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="Button2" runat="server" Text="Edit" OnClick="Button2_Click" />
                        <asp:Button ID="Button3" runat="server" Text="Update" OnClick="Button3_Click" />
                    </td>
                    <td class="auto-style8">
                        <asp:Button ID="Button4" runat="server" Text="Find" OnClick="Button4_Click" />
                    </td>
                    <td>
                        <asp:Button ID="Button5" runat="server" Text="Save" OnClick="Button5_Click" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <p>
    <asp:TextBox ID="TextBox10" runat="server" Width="60px"></asp:TextBox>
    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBox12" runat="server" Width="67px"></asp:TextBox>
    <asp:TextBox ID="TextBox13" runat="server" Width="67px"></asp:TextBox>
    <asp:TextBox ID="TextBox14" runat="server" Width="63px"></asp:TextBox>
</p>
<p>
    <asp:TextBox ID="TextBox15" runat="server" Width="60px"></asp:TextBox>
    <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBox17" runat="server" Width="67px"></asp:TextBox>
    <asp:TextBox ID="TextBox18" runat="server" Width="67px"></asp:TextBox>
    <asp:TextBox ID="TextBox19" runat="server" Width="63px"></asp:TextBox>
</p>
<p>
    <asp:TextBox ID="TextBox20" runat="server" Width="60px"></asp:TextBox>
    <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBox22" runat="server" Width="67px"></asp:TextBox>
    <asp:TextBox ID="TextBox23" runat="server" Width="67px"></asp:TextBox>
    <asp:TextBox ID="TextBox24" runat="server" Width="63px"></asp:TextBox>
</p>
<p>
    <asp:TextBox ID="TextBox25" runat="server" Width="60px"></asp:TextBox>
    <asp:TextBox ID="TextBox26" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBox27" runat="server" Width="67px"></asp:TextBox>
    <asp:TextBox ID="TextBox28" runat="server" Width="67px"></asp:TextBox>
    <asp:TextBox ID="TextBox29" runat="server" Width="67px"></asp:TextBox>
    </p>
        </div>
        
        </form>
    </body>
    </html>

