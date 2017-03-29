<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
<!-- <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/> -->
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <meta name="description" content=""/>
    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <!-- Custom styles for this template -->
    <link href="css/signin.css" rel="stylesheet"/>
    <title></title>
</head>
<body>
    <div class="container">
    <form id="form1" runat="server" class="form-signin">
   
        <h2 class="form-signin-heading">Gerencial</h2>

            
            <label for="txtValor1">Gastos</label> <br />
            <asp:TextBox Text="" runat="server" class="form-control" ReadOnly="true" ID="txtValor1"/>

            <label for="txtValor2">Entrada</label> <br />
            <asp:TextBox Text="" runat="server" class="form-control" ReadOnly="true" ID="txtValor2"/> 

            <label for="txtValor3">Lucro</label> <br />
            <asp:TextBox Text="" runat="server" class="form-control" ReadOnly="true" ID="txtValor3"/>
        
        <br/>
  
        
        <asp:Button class="btn btn-lg btn-primary btn-block" Text="Consulta Geral" runat ="server" ID="btnGeral" Onclick="btnBotao_Click" /> <br />
     

        <label for="txtComanda">Comanda</label>
            <asp:TextBox Text="" runat="server" class="form-control" ReadOnly="false" ID="txtComanda"/>
            <label for="txtValorComanda">Valor Comanda</label> <br />
            <asp:TextBox Text="" runat="server" class="form-control" ReadOnly="true" ID="txtValorComanda"/>

            <br />

            <asp:Button class="btn btn-lg btn-primary btn-block" Text="Consulta Comanda" ID="btnComanda" runat="server" OnClick="btnComanda_Click" />

        </form>
     </div>

    
</body>
</html>
