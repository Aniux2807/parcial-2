<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Cartelera_de_Cine.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>Mostrar Equipos</h2>
    <p>&nbsp;</p>
    <h3>&nbsp;</h3>
    <address>
        <asp:TextBox ID="TextBoxCiudad" runat="server" OnTextChanged="TextBoxCiudad_TextChanged"></asp:TextBox>
    </address>
    <address>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Mostrar Equipos" CssClass="btn-success" />
        <br />
    </address>
    <address>
        &nbsp;</address>
    <address>
        <asp:GridView ID="GridViewEquipo" runat="server" CssClass="btn-info">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
