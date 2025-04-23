<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CaracteristicasPlantas.aspx.cs" Inherits="PlantasUH.CapVista.CaracteristicasPlantas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tipo de Plantas</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Registro de tipo de plantas</h1>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br />
            <br />
            <asp:Label Text="Nombre" runat="server" />
            <br />
            <asp:TextBox ID="tnombre" runat="server" />
            <br />
            <asp:Label Text="Tipo" runat="server" />
            <br />
            <asp:TextBox ID="ttipo" runat="server" />
            <br />
            <asp:Label Text="PlantaID" runat="server" />
            <br />
            <asp:TextBox ID="tplantaid" runat="server" />
            <br />
            <br />
            <asp:Button Text="text" ID="bagrear" runat="server" />
        </div>
    </form>
</body>
</html>
