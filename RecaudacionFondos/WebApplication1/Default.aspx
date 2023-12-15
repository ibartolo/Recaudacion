<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="table">
                <%
                    foreach (var i in ParticipantesList)
                    {%>
                <tr>
                    <td><%:i.Id%></td>
                    <td><%:i.NombreParticipante%></td>
                </tr>
                <%}
                %>
            </table>

            <table>
                <%
                    foreach (var i in PagosParticipantesList)
                    {%>
                <tr>
                    <td></td>
                    <td></td>
                </tr>
                <%}

                %>
            </table>


        </div>
    </form>
</body>
</html>
