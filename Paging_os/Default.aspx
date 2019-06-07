<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Paging_os._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <h1 style="color: #009900">
                Run a process</h1>
            <h2>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Run Process" />
                </h2>
        </div>
        <div class="col-md-4">
            <p>
                <asp:TextBox ID="TextBox2" runat="server" Width="1191px" BorderStyle="Groove" ReadOnly="True"></asp:TextBox>
            </p>
            <p>
                <asp:TextBox ID="TextBox3" runat="server" Width="1191px" BorderStyle="Groove" ReadOnly="True"></asp:TextBox>
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Label ID="Label1" runat="server" Text="State:"></asp:Label>
            </p>
        </div>
        <div class="col-md-4">
            <p>
                &nbsp;</p>
        </div>
    </div>

</asp:Content>
