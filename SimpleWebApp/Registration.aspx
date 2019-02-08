<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <a href="Registration.aspx">Register</a> | <a href="Default.aspx"> List</a><br /> <br />

     <form id="form1" runat="server">
        <div>
            <p>First Name</p>
            <asp:TextBox ID="txtFirstName" runat="server" />
            <p>Mobile Number</p>
            <asp:TextBox ID="txtMobile" runat="server" />            
            <p>Email</p>
            <asp:TextBox ID="txtEmail" runat="server" /> <br /> <br />
            <asp:Button ID="registerButton" Text="Submit" runat="server" OnClick="RegisterUser" />
        </div>
    </form>
</body>
</html>
