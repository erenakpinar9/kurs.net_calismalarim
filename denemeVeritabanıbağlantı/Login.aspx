<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="denemeVeritabanıbağlantı.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
               <asp:Label ID="lblAd" runat="server" Text="Kullanıcı Adı:"></asp:Label><asp:TextBox ID="txtKullanici" runat="server"></asp:TextBox> <br />
               <asp:Label ID="lblSoyad" runat="server" Text="Sifre:"></asp:Label><asp:TextBox ID="txtSifre" runat="server"></asp:TextBox> <br />
               <asp:Button ID="btnGiris" runat="server" Text="Giriş" OnClick="btnGiris_Click" /> <br />
               <asp:Label ID="lblGirisUyari" runat="server" Text="---"></asp:Label>
        </div>
    </form>
</body>
</html>
