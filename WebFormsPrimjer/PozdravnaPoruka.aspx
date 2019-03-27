<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PozdravnaPoruka.aspx.cs" Inherits="WebFormsPrimjer.PozdravnaPoruka" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ovo je pozdravna poruka <br />
            <asp:Label ID="Label1" runat="server" Text="Ime:"></asp:Label><br />
            <asp:TextBox ID="txtIme" runat="server"></asp:TextBox><br />
            <br />
            <asp:Button ID="btnObradi" runat="server" Text="Button" BackColor="Blue" BorderColor="Black" ForeColor="#FFCC00" Height="62px" OnClick="btnObradi_Click" Width="210px" Font-Bold="True" Font-Italic="False" Font-Size="XX-Large" /><br />
            <br />
            <asp:Label ID="lblRezultat" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
