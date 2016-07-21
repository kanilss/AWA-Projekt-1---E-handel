<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="Kontorsprylar.ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container text-center">
        <h2>Kontakta oss</h2>
    </div>
    <div class="container">
        <div class="row">
            <div class="form-group">
                <label>Förnamn</label>
                <div class="input-group">
                    <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                    <asp:TextBox ID="TextBoxName" CssClass="form-control" runat="server"></asp:TextBox>
                </div>

                <label>Emailadress</label>
                <div class="input-group">
                    <span class="input-group-addon"><i class="glyphicon glyphicon-envelope"></i></span>
                    <asp:TextBox ID="TextBoxEmail" CssClass="form-control" runat="server"></asp:TextBox>
                </div>

                <label>Ämne</label>
                <select id="subject" name="subject" class="form-control">
                    <option value="na" selected="">Välj ett</option>
                    <option value="service">Kundservice</option>
                    <option value="suggestions">Förslag</option>
                    <option value="product">Produktsupport</option>
                </select>
            </div>
            <label>Meddelande</label>
            <div class="input-group">
                <span class="input-group-addon"><i class="glyphicon glyphicon-pencil"></i></span>
                <asp:TextBox ID="TextBoxMessage" TextMode="MultiLine" Rows="5" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <br />
        <asp:Button ID="submit" runat="server" CssClass="btn btn-primary pull-right" Text="Skicka" OnClick="submit_Click" />
        <br />
    </div>
</asp:Content>
