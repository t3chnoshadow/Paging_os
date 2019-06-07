<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Paging_os.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #009900;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1 class="auto-style1">Paging using Second chance</h1>
        <h4>Ram reserved for OS:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </h4>
        <h4>Page Frame size:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </h4>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Start" Width="120px" />
            <asp:Label ID="Label1" runat="server" Text="Amount of frames:"></asp:Label>
        </p>
    
    </div>
        <asp:ListBox ID="ListBox1" runat="server" Height="202px"></asp:ListBox>
        <asp:ListBox ID="ListBox2" runat="server" Height="201px"></asp:ListBox>
        <asp:ListBox ID="ListBox3" runat="server" Height="200px"></asp:ListBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Page faults:"></asp:Label>
        <br />
        <br />
        Add:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </form>
</body>
</html>
