<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="HandleCustomers.aspx.cs" Inherits="Kontorsprylar.HandelCustomers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function openModalUpdateCustomer() {
            $('#ModalUpdateCustomer').modal('show');
        }
        function openModalOrderHistory() {
            $('#ModalOrderHistory').modal('show');
        }
    </script>
    <asp:ListView ID="LVCustomers" runat="server" OnItemCommand="LVCustomers_ItemCommand" OnItemDeleting="LVCustomers_ItemDeleting" OnItemEditing="LVCustomers_ItemEditing">
        <LayoutTemplate>
            <table class="table" border="0">
                <tr style="background-color: #E5E5FE">
                    <th>
                        <asp:LinkButton ID="lnkId" runat="server">Id</asp:LinkButton></th>
                    <th>
                        <asp:LinkButton ID="lnkName" runat="server">Namn</asp:LinkButton></th>
                    <th>
                        <asp:LinkButton ID="lnkEmail" runat="server">Email</asp:LinkButton></th>
                    <th>
                        <asp:LinkButton ID="lnkAddress" runat="server">Adress</asp:LinkButton></th>
                    <th>
                        <asp:LinkButton ID="lnkPhone" runat="server">Telefon</asp:LinkButton></th>
                    <th>
                        <asp:LinkButton ID="lnkOrgNr" runat="server">Organisationsnr</asp:LinkButton></th>
                    <th></th>
                </tr>
                <tr id="itemPlaceholder" runat="server"></tr>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <asp:Label ID="lblID" runat="server" Text='<%#Eval("ID") %>' />
                <td>
                    <asp:Label ID="lblName" runat="server" Text='<%#Eval("Name")%>' /></td>
                <td>
                    <asp:Label ID="lblEmail" runat="server" Text='<%#Eval("Email") %>' /></td>
                <td>
                    <asp:Label ID="lblAddress" runat="server" Text='<%#Eval("Address") %>' /></td>
                <td>
                    <asp:Label ID="lblPhone" runat="server" Text='<%#Eval("Phone") %>' /></td>
                <td>
                    <asp:Label ID="lblOrgNr" runat="server" Text='<%#Eval("OrgNr") %>' /></td>
                <td>
                    <asp:LinkButton ID="LinkButtonEdit" runat="server" CommandName="Edit"><span class="glyphicon glyphicon-pencil"></span></asp:LinkButton>
                    <asp:LinkButton ID="LinkButtonDelete" runat="server" CommandName="Delete" OnClientClick="return confirm('Are you sure you want to delete this user?');"><span class="glyphicon glyphicon-trash"></span></asp:LinkButton>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="OrderHistory">Se orderhistorik</asp:LinkButton>
                </td>
            </tr>
        </ItemTemplate>
        <AlternatingItemTemplate>
            <tr style="background-color: #EFEFEF">
                <td>
                    <asp:Label ID="lblID" runat="server" Text='<%#Eval("ID") %>' />
                <td>
                    <asp:Label ID="lblName" runat="server" Text='<%#Eval("Name")%>' /></td>
                <td>
                    <asp:Label ID="lblEmail" runat="server" Text='<%#Eval("Email") %>' /></td>
                <td>
                    <asp:Label ID="lblAddress" runat="server" Text='<%#Eval("Address") %>' /></td>
                <td>
                    <asp:Label ID="lblPhone" runat="server" Text='<%#Eval("Phone") %>' /></td>
                <td>
                    <asp:Label ID="lblOrgNr" runat="server" Text='<%#Eval("OrgNr") %>' /></td>
                <td>
                    <asp:LinkButton ID="LinkButtonEdit" runat="server" CommandName="Edit"><span class="glyphicon glyphicon-pencil"></span></asp:LinkButton>
                    <asp:LinkButton ID="LinkButtonDelete" runat="server" CommandName="Delete" OnClientClick="return confirm('Are you sure you want to delete this user?');"><span class="glyphicon glyphicon-trash"></span></asp:LinkButton>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="OrderHistory">Se orderhistorik</asp:LinkButton>
                </td>

            </tr>
        </AlternatingItemTemplate>

    </asp:ListView>

    <!-- Modal Update Customer-->
    <div id="ModalUpdateCustomer" class="modal fade" role="dialog">
        <div class="modal-dialog">

            <!-- Modal content-->
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Uppdatera kund</h4>
                </div>
                <div class="modal-body">
                    <div class="container">
                        <div class="row main">
                            <div class="main-login main-center">

                                <asp:HiddenField ID="HiddenFieldID" runat="server" />

                                <div class="form-group">
                                    <label for="name" class="cols-sm-2 control-label">Namn</label>
                                    <div class="cols-sm-10">
                                        <div class="input-group">
                                            <span class="input-group-addon"><i class="fa fa-user fa" aria-hidden="true"></i></span>
                                            <asp:TextBox ID="TextBoxName" CssClass="form-control" Width="535px" runat="server"></asp:TextBox>
                                        </div>
                                        <asp:RequiredFieldValidator ID="RFVName" runat="server" ErrorMessage="Namn krävs" EnableClientScript="False" ControlToValidate="TextBoxName"></asp:RequiredFieldValidator>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label for="email" class="cols-sm-2 control-label">Email</label>
                                    <div class="cols-sm-10">
                                        <div class="input-group">
                                            <span class="input-group-addon"><i class="fa fa-envelope fa" aria-hidden="true"></i></span>
                                            <asp:TextBox ID="TextBoxEmail" CssClass="form-control" Width="535px" runat="server"></asp:TextBox>
                                        </div>
                                        <asp:RequiredFieldValidator ID="RFVEmail" runat="server" ErrorMessage="Email krävs" EnableClientScript="False" ControlToValidate="TextBoxEmail"></asp:RequiredFieldValidator>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label for="address" class="cols-sm-2 control-label">Address</label>
                                    <div class="cols-sm-10">
                                        <div class="input-group">
                                            <span class="input-group-addon"><i class="fa fa-users fa" aria-hidden="true"></i></span>
                                            <asp:TextBox ID="TextBoxAddress" CssClass="form-control" Width="535px" runat="server"></asp:TextBox>
                                        </div>
                                        <asp:RequiredFieldValidator ID="RFVAddress" runat="server" ErrorMessage="Address krävs" EnableClientScript="False" ControlToValidate="TextBoxAddress"></asp:RequiredFieldValidator>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label for="phone" class="cols-sm-2 control-label">Telefonnummer</label>
                                    <div class="cols-sm-10">
                                        <div class="input-group">
                                            <span class="input-group-addon"><i class="fa fa-users fa" aria-hidden="true"></i></span>
                                            <asp:TextBox ID="TextBoxPhone" CssClass="form-control" Width="535px" runat="server"></asp:TextBox>
                                        </div>
                                        <asp:RequiredFieldValidator ID="RFVPhone" runat="server" ErrorMessage="Telefonnummer krävs" EnableClientScript="False" ControlToValidate="TextBoxPhone"></asp:RequiredFieldValidator>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label for="orgnr" class="cols-sm-2 control-label">Organisationsnummer</label>
                                    <div class="cols-sm-10">
                                        <div class="input-group">
                                            <span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
                                            <asp:TextBox ID="TextBoxOrgNr" CssClass="form-control" Width="535px" runat="server"></asp:TextBox>
                                        </div>
                                        <asp:RequiredFieldValidator ID="RFVOrgNr" runat="server" ErrorMessage="Organisationsnummer krävs" EnableClientScript="False" ControlToValidate="TextBoxOrgNr"></asp:RequiredFieldValidator>
                                    </div>
                                </div>

                                <div class="form-group ">
                                    <asp:Button ID="ButtonSave" OnClick="ButtonSave_Click" CssClass="btn btn-primary btn-lg btn-block login-button" Width="535px" runat="server" Text="Spara" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>


    <!-- Modal Order History-->
    <div id="ModalOrderHistory" class="modal fade" role="dialog">
        <div class="modal-dialog">

            <!-- Modal content-->
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Orderhistorik</h4>
                </div>
                <div class="modal-body">
                    <p>Här tänker jag att vi visar upp en lista med orderhistorik</p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                </div>
            </div>

        </div>
    </div>

</asp:Content>
