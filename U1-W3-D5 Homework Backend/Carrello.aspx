<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="U1_W3_D5_Homework_Backend.Carrello" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container my-5" id="ContenitoreGriglia" runat="server" visible="false">
        <asp:GridView ID="GrigliaCarrello" runat="server" AutoGenerateColumns="false" ItemType="U1_W3_D5_Homework_Backend.Articolo" CssClass="table table-striped">
            <Columns>
                <asp:TemplateField HeaderText="Nome Articolo">
                    <ItemTemplate>
                        <asp:Label ID="NomeArticolo" runat="server" Text="<%# Item.Nome %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Prezzo">
                    <ItemTemplate>
                        <asp:Label ID="PrezzoArticolo" runat="server" Text=""><%# Item.Prezzo.ToString("c2") %></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <div class="d-flex justify-content-end align-items-center my-5">
            <asp:Label ID="SommaArticoli" runat="server" Text="" CssClass="mx-5" Font-Bold="true"></asp:Label><asp:Button ID="BottoneCancella" runat="server" Text="CancellaAcquisti" CssClass="btn ms-5 me-1 CancellaCarrello" OnClick="SvuotaCarrello" />
        </div>
    </div>
    <div class="my-5 d-flex justify-content-center">
    <asp:Label ID="MessaggioCarrelloVuoto" runat="server" Text="" Visible="true" CssClass="my-5 mx-5" Font-Size="XX-Large" Font-Bold="true"></asp:Label>
        </div>
</asp:Content>
