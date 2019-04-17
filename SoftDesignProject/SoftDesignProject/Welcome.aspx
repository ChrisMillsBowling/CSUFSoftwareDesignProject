<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="SoftDesignProject.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 67px;
            height: 76px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Content/companylogo.png" />
            <asp:Panel ID="Panel1" runat="server" Height="30px">
                <asp:Button ID="ClassButton" runat="server" Text="Class List" Height="30px" OnClick="ClassButton_Click" />
                <asp:Label ID="Label1" runat="server" Text="This is your account class list. It will show all classes our system currently has you listed as a part of."></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server">
                <asp:Button ID="BookButton" runat="server" Height="30px" Text="Book List" OnClick="BookButton_Click" />
                <asp:Label ID="Label2" runat="server" Text="This will show a list of all books currently added to your account."></asp:Label>
            </asp:Panel>
        </div>
        <asp:Panel ID="Panel3" runat="server" Height="102px">
            <asp:Label ID="WelcomeLabel" runat="server" Text="Welcome, Text"></asp:Label>
            <br />
            <img alt="User Icon" class="auto-style1" longdesc="This is the user's icon!" src="Content/usericon.jpg" />
        </asp:Panel>
        <asp:ListBox ID="ItemListBox" runat="server" Height="101px" OnLoad="ItemListBox_Load" OnSelectedIndexChanged="ItemListBox_SelectedIndexChanged" Width="175px">
            <asp:ListItem></asp:ListItem>
        </asp:ListBox>
        <p>
            <asp:Label ID="InfoLabel" runat="server" Text="Information:"></asp:Label>
        </p>
    </form>
</body>
</html>
