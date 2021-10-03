<%@ Page Language="C#" AutoEventWireup="true" CodeFile="upload_document.aspx.cs" Inherits="upload_document" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p style="margin-left: 360px">
            <asp:TextBox ID="txtEnroll" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Aadhar Number"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="295px"></asp:TextBox>
        </p>
        <p style="margin-left: 200px">
            <asp:Label ID="Label2" runat="server" Text="Aadhar Image"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:FileUpload ID="FileUpload1" runat="server" Width="320px" />
        </p>
        <p style="margin-left: 200px">
            10th Marksheet&nbsp;&nbsp;&nbsp;
            <asp:FileUpload ID="FileUpload2" runat="server" Width="329px" />
        </p>
        <p style="margin-left: 200px">
&nbsp;12th Marksheet&nbsp;&nbsp;&nbsp;
            <asp:FileUpload ID="FileUpload3" runat="server" Width="339px" />
        </p>
        <p style="margin-left: 200px">
            &nbsp;</p>
        <p style="margin-left: 360px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload File" Width="152px" />
        </p>
        <p>
&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>
