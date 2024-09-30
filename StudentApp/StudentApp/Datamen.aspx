<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Datamen.aspx.cs" Inherits="StudentApp.Datamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Data Form</title>
    <style type="text/css">
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f9;
            margin: 0;
            padding: 0;
        }
        .form-container {
            width: 70%;
            margin: 50px auto;
            padding: 20px;
            background-color: #ffffff;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            border-radius: 10px;
        }
        table {
            width: 100%;
            border-collapse: collapse;
        }
        td {
            padding: 10px;
            text-align: left;
        }
        .auto-style1 {
            width: 100%;
        }
        .button-container td {
            padding: 10px;
            text-align: center;
        }
        .button-container {
            text-align: center;
        }
        .button-container td {
            width: auto;
        }
        .auto-style2, .auto-style3, .auto-style4, .auto-style5 {
            text-align: right;
            width: 25%;
            color: #333333;
        }
        input[type="text"] {
            width: 100%;
            padding: 5px;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-sizing: border-box;
        }
        .form-label {
            color: #333;
            font-weight: bold;
        }
        .form-section-title {
            text-align: center;
            color: #444;
            margin-top: 20px;
            margin-bottom: 20px;
            font-size: 1.2em;
        }
        .auto-style6 {
            height: 30px;
        }
        .form-button {
            background-color: #007bff;
            color: white;
            border: none;
            padding: 10px 20px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            border-radius: 5px;
            cursor: pointer;
        }
        .form-button:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <div class="form-container">
        <form id="form1" runat="server">
            <div class="button-container">
                <table>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" CssClass="form-button" />
                        </td>
                        <td>
                            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Edit" CssClass="form-button" />
                        </td>
                        <td>
                            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" CssClass="form-button" />
                        </td>
                        <td>
                            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Find" CssClass="form-button" />
                        </td>
                        <td>
                            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Save" CssClass="form-button" />
                        </td>
                    </tr>
                </table>
            </div>
            <div class="form-section-title">Student Information</div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2 form-label">Name</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4 form-label">Age</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2 form-label">Date Of Birth</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                    </td>
                    <td class="auto-style4 form-label">Mobile</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2 form-label">Date Of Joining</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style2 form-label">Address</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style2 form-label">City</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style5 form-label">Country</td>
                    <td>
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2 form-label">State</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style2 form-label">Class</td>
                    <td class="auto-style3 form-label">College</td>
                    <td class="auto-style4 form-label">Obt1</td>
                    <td class="auto-style5 form-label">Obt2</td>
                    <td class="form-label">Percentage</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                </tr>
            </table>
        </form>
    </div>
</body>
</html>
