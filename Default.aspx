<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cartelera_de_Cine._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ingreso de jugadores equipos</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <div>
                Nombre:
                <asp:TextBox ID="TextBoxNombreEquipo" runat="server" OnTextChanged="TextBoxNombreEquipo_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxNombrePelicula" ErrorMessage="ingrese nombre de equipo"></asp:RequiredFieldValidator>
                <br />
                Ciudad:<asp:TextBox ID="TextBoxCiudad" runat="server"></asp:TextBox>
                <br />
                Año:<asp:TextBox ID="TextBoxAño" runat="server"></asp:TextBox>
                <br />
                <br />
                <br />
                <div>
                    <h4>Ingreso de jugador</h4>
                    <p>
                        Nombre:
                        <asp:TextBox ID="TextBoxNombreJugador" runat="server"></asp:TextBox>
                    &nbsp;ingrese nomber de jugador</p>
                    <p>
                        <asp:Button ID="ButtonIngresarJugador" runat="server" OnClick="ButtonIngresarActor_Click" Text="Ingresar jugador" />
                    </p>
                </div>
            </div>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="ButtonGuardarEquipo" runat="server" OnClick="ButtonGuardarPelicula_Click" Text="Guardar Equipo" />
            </p>
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-4">
            <h2>&nbsp;</h2>
        </div>
    </div>

</asp:Content>
