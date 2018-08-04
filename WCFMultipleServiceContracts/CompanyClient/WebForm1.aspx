<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CompanyClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Get Public Info"
                onclick="Button1_Click" Width="200px"/>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label1"></asp:Label>
            <br /><br /><br />
            <asp:Button ID="Button2" runat="server" Text="Get Confidential Info" 
                onclick="Button2_Click" Width="200px"/>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label2"></asp:Label>
        </div>
    </form>
</body>
</html>
