<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ProductUpdate.aspx.cs" Inherits="EntityAspProject.Products.ProductUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-6 offset-md-3">
                <h2>Kategori Güncelle</h2>
                <form runat="server" class="form-category">
                    <div class="form-group">
                        <asp:Label ID="lblPrdID" runat="server" CssClass="form-group" Text="Ürün ID"></asp:Label>
                        <asp:TextBox runat="server" ID="txtPrdID" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblPrdName" runat="server" CssClass="form-group" Text="Ürün Adı"></asp:Label>
                        <asp:TextBox runat="server" ID="txtPrdName" CssClass="form-control" placeholder="Ürün Adı"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblPrdBrand" runat="server" CssClass="form-group" Text="Ürün Markası"></asp:Label>
                        <asp:TextBox runat="server" ID="txtPrdBrand" CssClass="form-control" placeholder="Ürün Markası"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblPrdCategory" runat="server" CssClass="form-group" Text="Ürün Kategorisi"></asp:Label>
                        <asp:DropDownList ID="ddlPrdCategory" runat="server" CssClass="form-control" placeholder="Ürün Kategorisi"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblPrdPrice" runat="server" CssClass="form-group" Text="Ürün Fiyatı"></asp:Label>
                        <asp:TextBox runat="server" ID="txtPrdPrice" CssClass="form-control" placeholder="Ürün Fiyatı"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblPrdStock" runat="server" CssClass="form-group" Text="Ürün Stoğu"></asp:Label>
                        <asp:TextBox runat="server" ID="txtPrdStock" CssClass="form-control" placeholder="Ürün Stoğu"></asp:TextBox>
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:Button runat="server" ID="btnPrdUpdate" CssClass="btn btn-primary" Text="Ürün Güncelle" OnClick="btnPrdUpdate_Click"/>
                    </div>
                </form>
            </div>
        </div>
    </div>

</asp:Content>
