﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>A3 Classic ADO</h1>
        <table>
            <tr>
                <td> Email: </td>
                <td><asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password:</td>
                <td>
                    <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" /></td>
                <td>
                    <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
