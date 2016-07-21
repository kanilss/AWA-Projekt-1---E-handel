<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="CustomerHandleAccount.aspx.cs" Inherits="Kontorsprylar.CustomerHandleAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        function openmodalUpdatePassword() {
            $('#modalUpdatePassword').modal('show');
        }
    </script>
    <div style="float: left; width: 40%; margin-left: 10px">
        <div class="container" style="width: auto">
            <div class="row main">
                <div class="main-login main-center">

                    <asp:HiddenField ID="HiddenFieldID" runat="server" />

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
                        <label for="password" class="cols-sm-2 control-label">Ange ditt lösenord</label>
                        <div class="cols-sm-10">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
                                <asp:TextBox ID="TextBoxPassword" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                            <asp:RequiredFieldValidator ID="RFVPassword" runat="server" ErrorMessage="Lösenord krävs" EnableClientScript="False" ControlToValidate="TextBoxPassword"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <div class="form-group ">
                        <asp:Button ID="ButtonUpdate" OnClick="ButtonUpdate_Click" CssClass="btn btn-primary btn-lg btn-block login-button" runat="server" Text="Uppdatera" />
                        <asp:Button ID="ButtonUpdatePassword" OnClick="ButtonUpdatePassword_Click" CssClass="btn btn-primary btn-lg btn-block login-button" runat="server" Text="Byt lösenord" />
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div style="float: left; width: 50%">
        <div class="container text-center" style="width: auto">
            <h2>Orderhistorik</h2>
            <asp:Literal ID="LiteralOrderHistory" runat="server"></asp:Literal>
        </div>
    </div>

    <!-- Modal För att uppdatera lösenord-->
    <!-- Modal -->
    <div class="modal fade" id="modalUpdatePassword" role="dialog">
        <div class="modal-dialog">

            <!-- Modal content-->
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 style="color: red;"><span class="glyphicon glyphicon-lock"></span>Logga in</h4>
                </div>
                <div class="modal-body">
                    <div class="form-group">
                        <label for="oldPswd"><span class="glyphicon glyphicon-eye-open"></span>Gammalt lösenord</label>
                        <asp:TextBox ID="TextBoxOldPswd" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="newPswd"><span class="glyphicon glyphicon-eye-open"></span>Nytt lösenord</label>
                        <asp:TextBox ID="TextBoxNewPswd" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="newPswd"><span class="glyphicon glyphicon-eye-open"></span>Bekräfta nytt lösenord</label>
                        <asp:TextBox ID="TextBoxConfirmNewPswd" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <asp:LinkButton ID="LBUpdatePsw" OnClick="LBUpdatePsw_Click" CssClass="btn btn-default btn-success btn-block" runat="server"><span class="glyphicon glyphicon-off"></span>Uppdatera lösenord</asp:LinkButton>
                </div>
                <div class="modal-footer">
                    <button type="submit" class="btn btn-default btn-default pull-left" data-dismiss="modal"><span class="glyphicon glyphicon-remove"></span>Cancel</button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
