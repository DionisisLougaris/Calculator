<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page1.aspx.cs" Inherits="Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Layout.css">
    <title>Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label class="labels" ID="titleLabel" runat="server" Text="Calculator"></asp:Label>
        <br />
        <asp:Label class="labels" ID="firstNumLabel" runat="server" Text="First Number: "></asp:Label>&nbsp;&nbsp; <asp:TextBox ID="firstInput" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="addButton" runat="server" Text="" Height="69px" Width="76px" OnClick="addButton_Click" />&nbsp; <asp:Button ID="subtractButtton" runat="server" Text="" Height="69px" Width="76px" OnClick="subtractButtton_Click" />&nbsp; <asp:Button ID="multiplyButton" runat="server" Text="" Height="69px" Width="76px" OnClick="multiplyButton_Click" />&nbsp; <asp:Button ID="divideButton" runat="server" Text="" Height="69px" Width="76px" OnClick="divideButton_Click" />&nbsp; <asp:Button ID="clearButton" runat="server" Text="" Height="75px" Width="75px" OnClick="clearButton_Click" />&nbsp;
        <br />
        <asp:Label class="labels" ID="secondNumLabel" runat="server" Text="Second Number :"></asp:Label>&nbsp; <asp:TextBox ID="secondInput" runat="server" Width="144px"></asp:TextBox>
        <br />
        <asp:Label class="labels" ID="resultLabel" runat="server" Text="Result:"></asp:Label>&nbsp;<asp:Label class="labels" ID="resultOutputLabel" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
