<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="challengeSimpleDarts.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2 class="auto-style1">Simple Dart Game</h2>
        <br />
        Enter Player Names<br />
        Player1:
        <asp:TextBox ID="player1NameTextBox" runat="server"></asp:TextBox>
        <br />
        Player2:
        <asp:TextBox ID="player2NameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="throwButton" runat="server" OnClick="throwButton_Click" Text="Throw!" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
