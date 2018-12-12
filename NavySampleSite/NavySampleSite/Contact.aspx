<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="NavySampleSite.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address id ="navyAddress" runat="server">
        
    </address>

    <address>
        <strong>Support:</strong>   <a id="lnkEmail" runat="server" href=""></a><br />
        <b>TEST</b>
    </address>
</asp:Content>
