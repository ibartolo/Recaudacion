<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>Bootstrap Example</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>
<body>

    <div class="jumbotron text-center">
        <h1>Mantenimiento a la calle Habana</h1>
        <p></p>
    </div>

    <div class="container">
        <div class="row">
            <div class="col-sm-12 table-responsive">
                <table class="table table-bordered">
                    <tr>
                        <td></td>
                        <%  foreach (var i in Fechas)
                            {%>
                        <td><%:i%></td>
                        <%}
                        %>
                        <td></td>
                    </tr>
                    <%
                        foreach (var i in ParticipantesList)
                        {%>
                    <tr>
                        <td style="display: none;"><%:i.Id%></td>
                        <td><%:i.NombreParticipante%></td>
                       
                    </tr>
                    <%}
                    %>
                </table>
            </div>
        </div>
    </div>
</body>
</html>
