<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="EntityAspProject.Products.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <div class="container">
    <div class="row">
        <div class="col-md-10 offset-md-1">
            <h2>Ürünler</h2>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Ürün Adı</th>
                        <th>Ürün Markası</th>
                        <th>Ürün Kategorisi</th>
                        <th>Ürün Fiyatı</th>
                        <th>Ürün Stoğu</th>
                        <th>Sil</th>
                        <th>Güncelle</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("prd_id") %></td>
                                <td><%# Eval("prd_name") %></td>
                                <td><%# Eval("prd_brand") %></td>
                                <td><%# Eval("prd_ctg") %></td>
                                <td><%# Eval("prd_price") %> ₺</td>
                                <td><%# Eval("prd_stock") %></td>
                                <td><asp:HyperLink ID="DeleteLink" runat="server" CssClass="btn btn-danger" NavigateUrl='<%# "/Products/ProductDelete.aspx?Delete=" + Eval("prd_id") %>'>Sil</asp:HyperLink></td>
                                <td><asp:HyperLink ID="UpdateLink" runat="server" CssClass="btn btn-warning" NavigateUrl='<%# "/Products/ProductUpdate.aspx?Update=" + Eval("prd_id") %>'>Güncelle</asp:HyperLink></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-primary" NavigateUrl="/Products/ProductAdd.aspx">Yeni Ürün Ekle</asp:HyperLink>
        </div>
    </div>
</div>

</asp:Content>
