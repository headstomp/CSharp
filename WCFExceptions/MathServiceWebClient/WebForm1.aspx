<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MathServiceWebClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBoxNum1" runat="server"></asp:TextBox>
            <br />
            <asp:DropDownList ID="DropDownListOperator" runat="server">
                <asp:ListItem>Add</asp:ListItem>
                <asp:ListItem Value="Subtract"></asp:ListItem>
                <asp:ListItem>Multiply</asp:ListItem>
                <asp:ListItem>Divide</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:TextBox ID="TextBoxNum2" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="ButtonCalculate" runat="server" Text="Calculate" OnClick="ButtonCalculate_Click" />
            <br /><br />
            <asp:TextBox ID="TextBoxResult" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="LabelMessages" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
