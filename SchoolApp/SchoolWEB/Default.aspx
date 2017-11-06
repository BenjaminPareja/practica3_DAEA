<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SchoolWEB._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="gvListado" runat="server" Width="485px" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvListado_SelectedIndexChanged"></asp:GridView>

    <asp:LinkButton ID="lnkNuevo" runat="server" OnClick="lnkNuevo_Click">LinkButton</asp:LinkButton>

</asp:Content>
