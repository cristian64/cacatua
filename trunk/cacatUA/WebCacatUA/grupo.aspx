﻿<%@ Page Language="C#" MasterPageFile="~/PaginaMaestraUsuario.Master" AutoEventWireup="true" CodeBehind="grupo.aspx.cs" Inherits="grupo" Title="CacatUA" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder_headUsuario" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_tituloUsuario" runat="server">
    <p>
        Grupo
        <asp:Label ID="Label_nombre" runat="server"></asp:Label>
    </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder_contenidoUsuario" runat="server">
    <p>
        &nbsp;</p>
    <p>
        Descripción:
        <asp:Label ID="Label_Desc" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
<div id="miembros"> 
    <div id="miembrosTitulo">Miembros:</div>    
    <asp:Panel ID="Panel_miembros" runat="server"><br /></asp:Panel>
</div>   
</asp:Content>