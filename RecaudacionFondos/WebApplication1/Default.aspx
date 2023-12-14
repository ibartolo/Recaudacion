<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <%
                    foreach (var i in ParticipantesList)
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
