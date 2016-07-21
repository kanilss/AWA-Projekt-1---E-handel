<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="LoginAdmin.aspx.cs" Inherits="Kontorsprylar.LoginAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container text-center">
        <h2>Logga in som administratör</h2>
    </div>
    <br />
        <div class="container">
            <table style="margin-left:auto; margin-right:auto; column-gap:2px" >
                <tr>
                    <td>
                        <label><b>Email</b></label>
                    </td>
                    <td>&nbsp</td>
                    <td>
                        <asp:textbox id="TextBoxEmail" textmode="email" runat="server"></asp:textbox>
                        <asp:requiredfieldvalidator id="RFVEmail" runat="server" errormessage="Fyll i email-adress" controltovalidate="TextBoxEmail" enableclientscript="False"></asp:requiredfieldvalidator>
                    </td>
                </tr>
                <tr><td>&nbsp</td><td>&nbsp</td><td>&nbsp</td></tr>
                <tr>
                    <td>
                        <label><b>Lösenord</b></label>
                    </td>
                    <td>&nbsp</td>
                    <td>
                        <asp:textbox id="TextBoxPassword" textmode="password" runat="server"></asp:textbox>
                        <asp:requiredfieldvalidator id="RFVPassword" runat="server" errormessage="Fyll i lösenord" controltovalidate="TextBoxPassword" enableclientscript="False"></asp:requiredfieldvalidator>
                    </td>
                </tr>
                <tr><td>&nbsp</td><td>&nbsp</td><td>&nbsp</td></tr>
                <tr>
                    <td>&nbsp</td>
                   <td>&nbsp</td>
                    <td style="float:right"><button type="submit">Logga in</button></td>
                </tr>
            </table>
        </div>

</asp:Content>
