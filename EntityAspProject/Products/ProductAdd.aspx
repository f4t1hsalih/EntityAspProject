<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ProductAdd.aspx.cs" Inherits="EntityAspProject.Products.ProductAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-6 offset-md-3">
                <h2>Kategori Ekle</h2>
                <form runat="server" class="form-category">
                    <div class="form-group">
                        <asp:TextBox runat="server" ID="txtPrdName" CssClass="form-control" placeholder="Ürün Adı"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox runat="server" ID="txtPrdBrand" CssClass="form-control" placeholder="Ürün Markası"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox runat="server" ID="txtPrdCategory" CssClass="form-control" placeholder="Ürün Kategorisi"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox runat="server" ID="txtPrdPrice" CssClass="form-control" placeholder="Ürün Fiyatı"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox runat="server" ID="txtPrdStock" CssClass="form-control" placeholder="Ürün Stoğu"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="btnPrdAdd" CssClass="btn btn-primary" Text="Ürün Ekle" OnClick="btnPrdAdd_Click" />
                    </div>
                </form>
            </div>
        </div>
    </div>

</asp:Content>
