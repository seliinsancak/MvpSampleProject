<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserView.aspx.cs" Inherits="MVPSampleProject.Views.UserView" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>User Management</h2>

        <!-- ASP.NET TextBox kullan, placeholder kaldırıldı -->
        <asp:TextBox ID="txtName" runat="server" Text=""></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" Text=""></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" Text="Add User" OnClick="btnAdd_Click" />
        <br /><br />

        <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>
        <br /><br />

        <asp:GridView ID="gvUsers" runat="server" AutoGenerateColumns="False" OnRowCommand="gvUsers_RowCommand" DataKeyNames="Id">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="True" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnDelete" runat="server" Text="Delete"
                                    CommandName="DeleteUser"
                                    CommandArgument='<%# Eval("Id") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
