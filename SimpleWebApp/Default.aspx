<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Form</title>
    <style>
        table {
  border-collapse: collapse;
}
        table, th, td {
  border: 1px solid black;
}
    </style>
</head>
<body>
    <a href="Registration.aspx">Register</a> | <a href="Default.aspx"> List</a> <br /> <br />
    <form id="form1" runat="server">
    <asp:Table ID="myTable" runat="server" Width="100%"> 
        <asp:TableRow>
            <asp:TableCell>Name</asp:TableCell>
            <asp:TableCell>Mobile</asp:TableCell>
            <asp:TableCell>Email</asp:TableCell>
        </asp:TableRow>
    </asp:Table>  
    </form>
</body>
</html>
