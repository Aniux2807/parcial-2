<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Cartelera_de_Cine.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>Editar Equipo</h2>
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <div>
        Nombre<asp:TextBox ID="TextBoxNombreE" runat="server" OnTextChanged="TextBoxNombreE_TextChanged"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonEditar" runat="server" OnClick="ButtonEditar_Click" Text="Editar Equipo" />
        <br />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="339px">
            Nombre:<asp:TextBox ID="TextBoxNombreEquipo" runat="server"></asp:TextBox>
            <br />
            Ciudad:<asp:TextBox ID="TextBoxCiudad" runat="server"></asp:TextBox>
            <br />
            Año:<asp:TextBox ID="TextBoxAño" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:GridView ID="GridViewJugadores" runat="server" OnSelectedIndexChanged="GridViewActores_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <br />
            Nombre:<asp:TextBox ID="TextBoxJugador" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ButtoneditarNombre" runat="server" OnClick="ButtonEditarNombre_Click" Text="editarn nombre" />
            <br />
        </asp:Panel>
        <br />
        <asp:Button ID="Buttonactualizar" runat="server" Text="Actualizacion de Datos" OnClick="Buttonactualizar_Click" />
    </div>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
</asp:Content>
