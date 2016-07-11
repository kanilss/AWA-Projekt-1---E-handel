<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="RegisterCustomer.aspx.cs" Inherits="Kontorsprylar.RegisterCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row main">
            <div class="main-login main-center">
                <form class="form-horizontal" method="post" action="#">

                    <div class="form-group">
                        <label for="name" class="cols-sm-2 control-label">Ditt namn</label>
                        <div class="cols-sm-10">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-user fa" aria-hidden="true"></i></span>
                                <input type="text" class="form-control" name="name" id="name" placeholder="Fyll i namn" />
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="email" class="cols-sm-2 control-label">Din email</label>
                        <div class="cols-sm-10">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-envelope fa" aria-hidden="true"></i></span>
                                <input type="text" class="form-control" name="email" id="email" placeholder="Fyll i mailadress" />
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="address" class="cols-sm-2 control-label">Address</label>
                        <div class="cols-sm-10">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-users fa" aria-hidden="true"></i></span>
                                <input type="text" class="form-control" name="address" id="address" placeholder="Fyll i adress" />
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="phone" class="cols-sm-2 control-label">Telefonnummer</label>
                        <div class="cols-sm-10">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-users fa" aria-hidden="true"></i></span>
                                <input type="text" class="form-control" name="phone" id="phone" placeholder="Fyll i telefonnummer" />
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="orgnr" class="cols-sm-2 control-label">Organisationsnummer</label>
                        <div class="cols-sm-10">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
                                <input type="text" class="form-control" name="orgnr" id="orgnr" placeholder="Fyll i organisationsnummer" />
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="password" class="cols-sm-2 control-label">Lösenord</label>
                        <div class="cols-sm-10">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
                                <input type="password" class="form-control" name="password" id="password" placeholder="Fyll i lösenord" />
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="confirm" class="cols-sm-2 control-label">Bekräfta lösenord</label>
                        <div class="cols-sm-10">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
                                <input type="password" class="form-control" name="confirm" id="confirm" placeholder="Bekräfta lösenord" />
                            </div>
                        </div>
                    </div>

                    <div class="form-group ">
                        <button type="button" class="btn btn-primary btn-lg btn-block login-button">Registrera</button>
                    </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
