<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDown.aspx.cs" Inherits="Assignment_1.DropDown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Text="All" Value="All"></asp:ListItem>
                <asp:ListItem Text="Apple" Value="Apple"></asp:ListItem>
                <asp:ListItem Text="Banana" Value="Banana"></asp:ListItem>
                <asp:ListItem Text="Orange" Value="Orange"></asp:ListItem>
                <asp:ListItem Text="Grapes" Value="Grapes"></asp:ListItem>
                
            </asp:DropDownList>

             <br />
             <br />
            <asp:GridView ID="GridView1" runat="server">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Getdetails" />
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" />
            <br />
            <br />
            Product Price : 
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        </div>
    </form>
</body>
</html>