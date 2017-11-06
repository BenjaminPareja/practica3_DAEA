<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdatePerson.aspx.cs" Inherits="SchoolWEB.UpdatePerson" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label2" runat="server" Text="Person ID"></asp:Label>
    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label>
    <asp:TextBox ID="txtLast" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
    <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Hire Date"></asp:Label>
    <asp:TextBox ID="txtHire" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Enrollment Date"></asp:Label>
    <asp:TextBox ID="txtEnrollment" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
    <asp:Button ID="btnRegresar" runat="server" OnClick="btnRegresar_Click" Text="Regresar" />
    <br />
</asp:Content>
