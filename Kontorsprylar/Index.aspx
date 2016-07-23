<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Kontorsprylar.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    <style>
        .carousel-inner img {
            margin: auto;
        }
    </style>


    <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>

        </ol>

        <!-- Wrapper for slides -->
        <div class="carousel-inner" role="listbox">
            <div class="item active">

                <img src="C:\Users\Administrator\Downloads\2_646x330_toner_o_black.jpg" alt="TonerOBlack">
                <div class="carousel-caption">
                </div>
            </div>

            <div class="item">
                <img src="C:\Users\Administrator\Downloads\1_646x330_kopieringspapper.jpg" alt="RattPapper">
                <div class="carousel-caption">
                </div>
            </div>

            <div class="item">
                <img src="C:\Users\Administrator\Downloads\3_646x330_ePacker.jpg" alt="EPacker">
                <div class="carousel-caption">
                </div>
            </div>

        </div>

        <!-- Left and right controls -->
        <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>
</asp:Content>
