<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaPagos.aspx.cs" Inherits="WebApplication1.AltaPagos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-cookie/1.4.1/jquery.cookie.min.js"></script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>

<body>

    <form id="form1" runat="server">

        <asp:TextBox ID="txtId" Visible="false" CssClass="form-control" runat="server"></asp:TextBox>


        <div class="row form-group">
            <div class="jumbotron text-center">
                <h1>Lista De Pagos</h1>
                <p>Poza Rica Ver.</p>

            </div>
            <div class="col-md-3">
                <label>Nombre Participante</label>
                <asp:DropDownList ID="ddlNombre" CssClass="form-control" runat="server" TextMode="Number">
                </asp:DropDownList>
            </div>

            <div class="row">
                <div class="col-md-4">
                    <label>Monto:</label>
                    <asp:TextBox ID="txtMonto" TextMode="Number" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-3">
                <asp:Label Text="Fecha" runat="server" />
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </div>
        </div>

        <div class="row form-group">
            <div class="jumbotron text-center">
                <asp:Button runat="server" Text="Guardar" ID="btnGuardar" OnClick="btnGuardar_Click" CssClass="btn btn-primary" />
                <button class="btn btn-success">CANCELAR</button>
            </div>
        </div>
    </form>




</body>
</html>
