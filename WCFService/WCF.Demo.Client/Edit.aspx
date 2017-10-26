<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="WCF.Demo.Client.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            修改页面：<br />
            用户名：<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox><br />
            描述：<asp:TextBox ID="txtDiscribe" runat="server" TextMode="MultiLine" Height="119px" Width="239px"></asp:TextBox><br />
            <asp:Button ID="btnSubmit" Text="提交" runat="server" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
