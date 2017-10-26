<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test_WCFConsole.aspx.cs" Inherits="WCFClient.Test_WCFConsole" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtName" runat="server" style="height: 19px"></asp:TextBox><br />
            <asp:Button runat="server" Text="测试WCF控制台宿主服务" OnClick="Unnamed1_Click" /><br />
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
