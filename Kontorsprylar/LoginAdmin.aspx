<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="LoginAdmin.aspx.cs" Inherits="Kontorsprylar.LoginAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container text-center">
        <h2>Logga in som administratör</h2>
        <br />
        <div class="container" style="width:auto">
            <div class="form-group">
                <label for="email"><span class="glyphicon glyphicon-user"></span> Email</label>
                <asp:TextBox ID="TextBoxLoginEmail" CssClass="form-control" style="text-align:center" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFVLoginEmail" runat="server" ErrorMessage="Email krävs" ControlToValidate="TextBoxLoginEmail" EnableClientScript="False"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="psw"><span class="glyphicon glyphicon-eye-open"></span> Lösenord</label>
                <asp:TextBox ID="TextBoxLoginPassword" CssClass="form-control" style="text-align:center" TextMode="Password" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFVLoginPassword" runat="server" ErrorMessage="Lösenord krävs" EnableClientScript="False" ControlToValidate="TextBoxLoginPassword"></asp:RequiredFieldValidator>
            </div>
            <button type="submit" class="btn btn-default btn-success btn-block"><span class="glyphicon glyphicon-off"></span> Login</button>
        </div>
    </div>
    <br/>
</asp:Content>
