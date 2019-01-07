<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PicoYPlaca.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css" integrity="sha384-GJzZqFGwb1QTTN6wy59ffF1BuGJpLSa9DkKMp0DgiMDm4iYMj70gZWKYbI706tWS" crossorigin="anonymous" />
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js" integrity="sha384-B0UglyR+jN6CkvvICOB2joaf5I4l3gm9GU6Hc1og6Ls7i6U/mkkaduKaBhlAXv9k" crossorigin="anonymous"></script>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js" integrity="sha384-wHAiFfRlMFy6i5SRaxvfOCifBUQy1xHdJ/yoi7FRNXMRBu5WHdZYu1hA6ZOblgut" crossorigin="anonymous"></script>
    <script src="Scripts/bootstrap.bundle.min.js"></script>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark static-top">
        <div class="container">
            <a class="navbar-brand" href="#">Consulta Pico y Placa</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive"
                aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
        </div>
    </nav>
    <form id="form1" runat="server">
        <div class="container text-center" style="width: 50%; margin: 0 auto;">
            <div>
                <asp:Label runat="server" Text="Placa: " />
                <asp:TextBox ID="txtplaca" runat="server" CssClass="form-control" placeholder="PBC-0123"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label runat="server" Text="Fecha: " />
                <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" placeholder="dd/mm/aaaa"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label runat="server" Text="Hora: " />
                <div class="row">
                    <div class="col-6">
                        <asp:DropDownList ID="DDHora" runat="server" CssClass="form-control" />
                    </div>
                    <div class="col-6">
                        <asp:DropDownList ID="DDMinutos" runat="server" CssClass="form-control" />
                    </div>
                </div>
            </div>
            <br />
            <asp:Button CssClass="btn btn-primary" ID="btnConsultar" runat="server" Text="Consultar" OnClientClick="onClick_btnConsultar" />
            &nbsp;
            <input class="btn btn-secondary" type="reset" value="Borrar" />
            <br />
            <asp:Label runat="server" ID="lblRespuesta"></asp:Label>
        </div>
    </form>
</body>
</html>
