<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="YourNamespace.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dynamic Navigation Menu</title>
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <ul id="hmenu">
            <asp:Repeater ID="MenuRepeater" runat="server">
                <ItemTemplate>
                    <li class='<%# IsCurrentPage(Container.DataItem) ? "Aktif" : "" %>'>
                        <a href='<%# Eval("Url") %>'><%# Eval("Text") %></a>
                        <asp:Repeater ID="SubMenuRepeater" runat="server" DataSource='<%# Eval("SubItems") %>'>
                            <ItemTemplate>
                                <ul id="sub-menu">
                                    <li><a href='<%# Eval("Url") %>'><%# Eval("Text") %></a></li>
                                </ul>
                            </ItemTemplate>
                        </asp:Repeater>
                    </li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </form>
</body>
</html>