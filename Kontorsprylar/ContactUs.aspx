<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="Kontorsprylar.ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
            <div class="row">
                <div class="span3">
                    <label>Förnamn</label>
                    <input type="text" class="span3" placeholder="Your First Name">
                    <label>Efternamn</label>
                    <input type="text" class="span3" placeholder="Your Last Name">
                    <label>Emailadress</label>
                    <input type="text" class="span3" placeholder="Your email address">
                    <label>
                        Ämne
			<select id="subject" name="subject" class="span3">
                <option value="na" selected="">Välj en</option>
                <option value="service">General Customer Service</option>
                <option value="suggestions">Suggestions</option>
                <option value="product">Product Support</option>
            </select>
                    </label>
                </div>
                <div class="span5">
                    <label>Meddelande</label>
                    <textarea name="message" id="message" class="input-xlarge span5" rows="10"></textarea>
                </div>
                <button type="submit" class="btn btn-primary pull-right">Send</button>
            </div>
    </div>
</asp:Content>
