<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Conversion.aspx.cs" Inherits="WSConvertnumber.CSU.Conversion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Numero</div>
        <asp:TextBox ID="TxtNumero" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Btnletras" runat="server" OnClick="Btnletras_Click" Text="Letras" style="margin-top: 0px" />
            <asp:Button ID="BtnDolares" runat="server" OnClick="BtnDolares_Click" Text="Dolares" />
        </p>
        <p>
            Resultado</p>
        <asp:TextBox ID="TxtResultado" runat="server" Height="25px"></asp:TextBox>
    </form>
</body>
</html>
