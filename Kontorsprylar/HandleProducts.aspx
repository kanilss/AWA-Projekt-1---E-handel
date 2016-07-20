<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="HandleProducts.aspx.cs" Inherits="Kontorsprylar.HandleProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script type="text/javascript">
        function openModalUpdateProduct() {
            $('#ModalUpdateProduct').modal('show');
        }
    </script>

    <div class="container text-center">
        <h2>Hantera produkter</h2>
    </div>
    <br />

    <button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#ModalNewProduct">Ny produkt</button>
    <br />

    <asp:ListView ID="LVCustomers" runat="server" OnItemCommand="LVCustomers_ItemCommand" OnItemDeleting="LVCustomers_ItemDeleting" OnItemEditing="LVCustomers_ItemEditing">
        <LayoutTemplate>
            <table class="table" border="0">
                <tr style="background-color: #E5E5FE">
                    <th>
                        <asp:LinkButton ID="lnkId" runat="server">Id</asp:LinkButton></th>
                    <th>
                        <asp:LinkButton ID="lnkName" runat="server">Namn</asp:LinkButton></th>
                    <th>
                        <asp:LinkButton ID="lnkPrice" runat="server">Pris</asp:LinkButton></th>
                    <th>
                        <asp:LinkButton ID="lnkDescription" runat="server">Beskrivning</asp:LinkButton></th>
                    <th>
                        <asp:LinkButton ID="lnkPictureLink" runat="server">Bildlänk</asp:LinkButton></th>
                    <th></th>
                </tr>
                <tr id="itemPlaceholder" runat="server"></tr>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <asp:Label ID="lblID" runat="server" Text='<%#Eval("PID") %>' />
                <td>
                    <asp:Label ID="lblName" runat="server" Text='<%#Eval("Name")%>' /></td>
                <td>
                    <asp:Label ID="lblEmail" runat="server" Text='<%#Eval("Price") %>' /></td>
                <td>
                    <asp:Label ID="lblAddress" runat="server" Text='<%#Eval("Description") %>' /></td>
                <td>
                    <asp:Label ID="lblPhone" runat="server" Text='<%#Eval("PictureLink") %>' /></td>
                <td>
                    <asp:LinkButton ID="LinkButtonEdit" runat="server" CommandName="Edit"><span class="glyphicon glyphicon-pencil"></span></asp:LinkButton>
                    <asp:LinkButton ID="LinkButtonDelete" runat="server" CommandName="Delete" OnClientClick="return confirm('Är du säker på att du vill ta bort den här produkten?');"><span class="glyphicon glyphicon-trash"></span></asp:LinkButton>
                </td>
            </tr>
        </ItemTemplate>
        <AlternatingItemTemplate>
            <tr>
                <td>
                    <asp:Label ID="lblID" runat="server" Text='<%#Eval("PID") %>' />
                <td>
                    <asp:Label ID="lblName" runat="server" Text='<%#Eval("Name")%>' /></td>
                <td>
                    <asp:Label ID="lblEmail" runat="server" Text='<%#Eval("Price") %>' /></td>
                <td>
                    <asp:Label ID="lblAddress" runat="server" Text='<%#Eval("Description") %>' /></td>
                <td>
                    <asp:Label ID="lblPhone" runat="server" Text='<%#Eval("PictureLink") %>' /></td>
                <td>
                    <asp:LinkButton ID="LinkButtonEdit" runat="server" CommandName="Edit"><span class="glyphicon glyphicon-pencil"></span></asp:LinkButton>
                    <asp:LinkButton ID="LinkButtonDelete" runat="server" CommandName="Delete" OnClientClick="return confirm('Är du säker på att du vill ta bort den här produkten?');"><span class="glyphicon glyphicon-trash"></span></asp:LinkButton>
                </td>
            </tr>
        </AlternatingItemTemplate>
    </asp:ListView>

    <!-- Modal Update Product-->
    <div id="ModalUpdateProduct" class="modal fade" role="dialog">
        <div class="modal-dialog">

            <!-- Modal content-->
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Uppdatera produkt</h4>
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
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label for="email" class="cols-sm-2 control-label">Pris</label>
                                    <div class="cols-sm-10">
                                        <div class="input-group">
                                            <span class="input-group-addon"><i class="fa fa-envelope fa" aria-hidden="true"></i></span>
                                            <asp:TextBox ID="TextBoxPris" CssClass="form-control" Width="535px" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label for="address" class="cols-sm-2 control-label">Beskrivning</label>
                                    <div class="cols-sm-10">
                                        <div class="input-group">
                                            <span class="input-group-addon"><i class="fa fa-users fa" aria-hidden="true"></i></span>
                                            <asp:TextBox ID="TextBoxDescription" CssClass="form-control" Width="535px" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label for="phone" class="cols-sm-2 control-label">Bildlänk</label>
                                    <div class="cols-sm-10">
                                        <div class="input-group">
                                            <span class="input-group-addon"><i class="fa fa-users fa" aria-hidden="true"></i></span>
                                            <asp:TextBox ID="TextBoxPicLink" CssClass="form-control" Width="535px" runat="server"></asp:TextBox>
                                        </div>
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

    <!-- Modal New Product-->
    <div id="ModalNewProduct" class="modal fade" role="dialog">
        <div class="modal-dialog">

            <!-- Modal content-->
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Uppdatera produkt</h4>
                </div>
                <div class="modal-body">
                    <div class="container">
                        <div class="row main">
                            <div class="main-login main-center">

                                <asp:HiddenField ID="HiddenField1" runat="server" />

                                <div class="form-group">
                                    <label for="name" class="cols-sm-2 control-label">Namn</label>
                                    <div class="cols-sm-10">
                                        <div class="input-group">
                                            <span class="input-group-addon"><i class="fa fa-user fa" aria-hidden="true"></i></span>
                                            <asp:TextBox ID="TextBoxNameNew" CssClass="form-control" Width="535px" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label for="email" class="cols-sm-2 control-label">Pris</label>
                                    <div class="cols-sm-10">
                                        <div class="input-group">
                                            <span class="input-group-addon"><i class="fa fa-envelope fa" aria-hidden="true"></i></span>
                                            <asp:TextBox ID="TextBoxPriceNew" CssClass="form-control" Width="535px" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label for="address" class="cols-sm-2 control-label">Beskrivning</label>
                                    <div class="cols-sm-10">
                                        <div class="input-group">
                                            <span class="input-group-addon"><i class="fa fa-users fa" aria-hidden="true"></i></span>
                                            <asp:TextBox ID="TextBoxDescriptionNew" CssClass="form-control" Width="535px" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label for="phone" class="cols-sm-2 control-label">Bildlänk</label>
                                    <div class="cols-sm-10">
                                        <div class="input-group">
                                            <span class="input-group-addon"><i class="fa fa-users fa" aria-hidden="true"></i></span>
                                            <asp:TextBox ID="TextBoxPicLinkNew" CssClass="form-control" Width="535px" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>

                                <div class="form-group ">
                                    <asp:Button ID="ButtonNewProduct" OnClick="ButtonNewProduct_Click" CssClass="btn btn-primary btn-lg btn-block login-button" Width="535px" runat="server" Text="Spara" />
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

</asp:Content>
