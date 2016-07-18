<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="RegisterCustomer.aspx.cs" Inherits="Kontorsprylar.RegisterCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row main">
            <div class="main-login main-center">

                <div class="form-group">
                    <label for="name" class="cols-sm-2 control-label">Ditt namn</label>
                    <div class="cols-sm-10">
                        <div class="input-group">
                            <span class="input-group-addon"><i class="fa fa-user fa" aria-hidden="true"></i></span>
                            <asp:TextBox ID="TextBoxName" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <asp:RequiredFieldValidator ID="RFVName" runat="server" ErrorMessage="Namn krävs" EnableClientScript="False" ControlToValidate="TextBoxName"></asp:RequiredFieldValidator>
                    </div>
                </div>

                <div class="form-group">
                    <label for="email" class="cols-sm-2 control-label">Din email</label>
                    <div class="cols-sm-10">
                        <div class="input-group">
                            <span class="input-group-addon"><i class="fa fa-envelope fa" aria-hidden="true"></i></span>
                            <asp:TextBox ID="TextBoxEmail" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <asp:RequiredFieldValidator ID="RFVEmail" runat="server" ErrorMessage="Email krävs" EnableClientScript="False" ControlToValidate="TextBoxEmail"></asp:RequiredFieldValidator>
                    </div>
                </div>

                <div class="form-group">
                    <label for="address" class="cols-sm-2 control-label">Address</label>
                    <div class="cols-sm-10">
                        <div class="input-group">
                            <span class="input-group-addon"><i class="fa fa-users fa" aria-hidden="true"></i></span>
                            <asp:TextBox ID="TextBoxAddress" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <asp:RequiredFieldValidator ID="RFVAddress" runat="server" ErrorMessage="Address krävs" EnableClientScript="False" ControlToValidate="TextBoxAddress"></asp:RequiredFieldValidator>
                    </div>
                </div>

                <div class="form-group">
                    <label for="phone" class="cols-sm-2 control-label">Telefonnummer</label>
                    <div class="cols-sm-10">
                        <div class="input-group">
                            <span class="input-group-addon"><i class="fa fa-users fa" aria-hidden="true"></i></span>
                            <asp:TextBox ID="TextBoxPhone" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <asp:RequiredFieldValidator ID="RFVPhone" runat="server" ErrorMessage="Telefonnummer krävs" EnableClientScript="False" ControlToValidate="TextBoxPhone"></asp:RequiredFieldValidator>
                    </div>
                </div>

                <div class="form-group">
                    <label for="orgnr" class="cols-sm-2 control-label">Organisationsnummer</label>
                    <div class="cols-sm-10">
                        <div class="input-group">
                            <span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
                            <asp:TextBox ID="TextBoxOrgNr" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <asp:RequiredFieldValidator ID="RFVOrgNr" runat="server" ErrorMessage="Organisationsnummer krävs" EnableClientScript="False" ControlToValidate="TextBoxOrgNr"></asp:RequiredFieldValidator>
                    </div>
                </div>

                <div class="form-group">
                    <label for="password" class="cols-sm-2 control-label">Lösenord</label>
                    <div class="cols-sm-10">
                        <div class="input-group">
                            <span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
                            <asp:TextBox ID="TextBoxPassword" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <asp:RequiredFieldValidator ID="RFVPassword" runat="server" ErrorMessage="Lösenord krävs" EnableClientScript="False" ControlToValidate="TextBoxPassword"></asp:RequiredFieldValidator>
                    </div>
                </div>

                <div class="form-group">
                    <label for="confirm" class="cols-sm-2 control-label">Bekräfta lösenord</label>
                    <div class="cols-sm-10">
                        <div class="input-group">
                            <span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
                            <asp:TextBox ID="TextBoxConfirm" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <asp:CompareValidator ID="CVConfirm" runat="server" ErrorMessage="Lösenord matchar inte" EnableClientScript="False" ControlToCompare="TextBoxPassword" ControlToValidate="TextBoxConfirm"></asp:CompareValidator>
                    </div>
                </div>

                <div class="form-group ">
                    <asp:Button ID="Button1" CssClass="btn btn-primary btn-lg btn-block login-button" runat="server" Text="Registrera" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
