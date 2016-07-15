<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="LoginAdmin.aspx.cs" Inherits="Kontorsprylar.LoginAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<%--    <div class="imgcontainer">
        <img src="img_avatar2.png" alt="Avatar" class="avatar">
    </div>--%>
    <h2>Logga in som administratör</h2>

    <div class="container">
        <label><b>Email</b></label>
        <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RFVEmail" runat="server" ErrorMessage="Fyll i email-adress" ControlToValidate="TextBoxEmail" EnableClientScript="False"></asp:RequiredFieldValidator>
        <br />

        <label><b>Lösenord</b></label>
        <asp:TextBox ID="TextBoxPassword" TextMode="password" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RFVPassword" runat="server" ErrorMessage="Fyll i lösenord" ControlToValidate="TextBoxPassword" EnableClientScript="False"></asp:RequiredFieldValidator>
        <button type="submit">Logga in</button>
    </div>

    <%--<div class="container" style="background-color: #f1f1f1">--%>
        <%--<button type="button" class="cancelbtn">Cancel</button>--%>
        <%--<span class="psw">Forgot <a href="#">password?</a></span>--%>
    </div>
</asp:Content>
