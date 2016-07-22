<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Kontorsprylar.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .glyphicon {
            margin-right: 5px;
        }

        .thumbnail {
            margin-bottom: 20px;
            padding: 0px;
            -webkit-border-radius: 0px;
            -moz-border-radius: 0px;
            border-radius: 0px;
        }

        .item.list-group-item {
            float: none;
            width: 100%;
            background-color: #fff;
            margin-bottom: 10px;
        }

            .item.list-group-item:nth-of-type(odd):hover, .item.list-group-item:hover {
                background: #428bca;
            }

            .item.list-group-item .list-group-image {
                margin-right: 10px;
            }

            .item.list-group-item .thumbnail {
                margin-bottom: 0px;
            }

            .item.list-group-item .caption {
                padding: 9px 9px 0px 9px;
            }

            .item.list-group-item:nth-of-type(odd) {
                background: #eeeeee;
            }

            .item.list-group-item:before, .item.list-group-item:after {
                display: table;
                content: " ";
            }

            .item.list-group-item img {
                float: left;
            }

            .item.list-group-item:after {
                clear: both;
            }

        .list-group-item-text {
            margin: 0 0 11px;
        }
    </style>

    <script>
        $(document).ready(function () {
            $('#list').click(function (event) { event.preventDefault(); $('#products .item').addClass('list-group-item'); });
            $('#grid').click(function (event) { event.preventDefault(); $('#products .item').removeClass('list-group-item'); $('#products .item').addClass('grid-group-item'); });
        });
    </script>
    <div class="container">
        <div class="well well-sm">
            <strong>Category Title</strong>
            <div class="btn-group">
                <a href="#" id="list" class="btn btn-default btn-sm"><span class="glyphicon glyphicon-th-list"></span>List</a> <a href="#" id="grid" class="btn btn-default btn-sm"><span
                    class="glyphicon glyphicon-th"></span>Grid</a>
            </div>
        </div>
        <div id="products" class="row list-group">
            <asp:Literal ID="LiteralProducts" runat="server"></asp:Literal>
        </div>
    </div>
</asp:Content>
