<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="proyecto12.CapaVista.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../CSS/Login.css" rel="stylesheet" />
    <title></title>
</head>
<body>
         <section class="container">
        <div class="login-container">
            <div class="circle circle-one"></div>
            <div class="form-container">
                <img src="https://raw.githubusercontent.com/hicodersofficial/glassmorphism-login-form/master/assets/illustration.png" alt="illustration" class="illustration" />
                <h1 class="opacity">LOGIN</h1>
                <form id="form1" runat="server">

                    <asp:TextBox ID="TUsuario" placeholder ="Usuario" runat="server"></asp:TextBox>
                    <asp:TextBox ID="TClave" placeholder = "Clave" runat="server"></asp:TextBox>

                    <asp:Button ID="BIngresar" class="opacity" runat="server" Text="LOGIN" OnClick="BIngresar_Click" />
                   
                </form>
                <div class="register-forget opacity">
                    <a href="">REGISTER</a>
                    <a href="">FORGOT PASSWORD</a>
                </div>
            </div>
            <div class="circle circle-two"></div>
        </div>
        <div class="theme-btn-container"></div>
    </section>
</body>
</html>
