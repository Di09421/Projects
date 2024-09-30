<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataManProject.aspx.cs" Inherits="DatamenProject.DataManProject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style6 {
            width: 76px;
        }
        .auto-style7 {
            width: 78px;
        }
        .auto-style8 {
            width: 81px;
        }
        .auto-style9 {
            width: 50px;
        }
        .auto-style11 {
            width: 50px;
            height: 23px;
        }
        .auto-style13 {
            width: 78px;
            height: 23px;
        }
        .auto-style14 {
            width: 81px;
            height: 23px;
        }
        .auto-style15 {
            width: 76px;
            height: 23px;
        }
        .auto-style16 {
            height: 23px;
        }
        .auto-style17 {
            width: 36px;
        }
        .auto-style18 {
            width: 36px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style17">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
                </td>
                <td class="auto-style7">
                    <asp:Button ID="Button2" runat="server" Text="Edit" OnClick="Button2_Click" />
                </td>
                <td class="auto-style7">
                    <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Button4" runat="server" Text="Find" OnClick="Button4_Click" />
                </td>
                <td class="auto-style6">
                    <asp:Button ID="Button5" runat="server" Text="Save" OnClick="Button5_Click" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">Name</td>
                <td class="auto-style17">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">Age</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">Dateofbirth</td>
                <td class="auto-style17">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">Dateofjoining</td>
                <td class="auto-style17">
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Date"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">Address</td>
                <td class="auto-style17">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">Mobile</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">City</td>
                <td class="auto-style17">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>--Select City--</asp:ListItem>
                        <asp:ListItem>Kanpur</asp:ListItem>
                        <asp:ListItem>Lucknow</asp:ListItem>
                        <asp:ListItem>Delhi</asp:ListItem>
                        <asp:ListItem>Mumbai</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">State</td>
                <td class="auto-style17">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">Country</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">Class</td>
                <td class="auto-style18">College&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style13">Obtaining</td>
                <td class="auto-style13">Obtained</td>
                <td class="auto-style14">Percentage</td>
                <td class="auto-style15"></td>
                <td class="auto-style16"></td>
                <td class="auto-style16"></td>
                <td class="auto-style16"></td>
                <td class="auto-style16"></td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style17">
                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox11" runat="server" Width="62px"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox12" runat="server" Width="61px"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox13" runat="server" Width="121px"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style17">
                    <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox16" runat="server" Width="57px"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox17" runat="server" Width="59px"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox18" runat="server" Width="120px"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style17">
                    <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox21" runat="server" Width="63px"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox22" runat="server" Width="62px"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox23" runat="server" Width="116px"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">Overall&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style17">
                  <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true">
        </asp:GridView>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
