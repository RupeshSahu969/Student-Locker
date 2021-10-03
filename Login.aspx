<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Enroll No"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEnroll" runat="server" Width="196px"></asp:TextBox>
        </p>
        <p style="margin-left: 80px">
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPassword" runat="server" Width="217px" TextMode="Password"></asp:TextBox>
        </p>
        <p style="margin-left: 80px">
            &nbsp;</p>
        <p style="margin-left: 200px">
            <asp:Button ID="Button1" runat="server" style="margin-left: 0px" Text="Login" Width="137px" OnClick="Button1_Click" />
        </p>
    <div>
    
    </div>
    </form>
    <p>
&nbsp;</p>
</body>
</html>
