<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WCF.Demo.Client.List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div><a href="ADD.aspx">添加</a></div>
            <asp:Repeater ID="repUsers" runat="server">
                <ItemTemplate>
                    编号：<%#Eval("UserID") %>，用户名：<%#Eval("UserName") %>，密码：<%#Eval("Password") %>，描述：<%#Eval("Discribe") %>提交时间：<%#Eval("SubmitTime") %>----<a href="Edit.aspx?UserID=<%#Eval("UserID") %>">修改</a>
                    <a href="Remove.aspx?UserID=<%#Eval("UserID") %>" onclick="return confirm('确定删除吗?');">删除</a>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
        </div>
    </form>
</body>
</html>
