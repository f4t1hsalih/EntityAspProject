<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SaleList.aspx.cs" Inherits="EntityAspProject.Sales.SaleList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container">
    <div class="row">
        <div class="col-md-10 offset-md-1">
            <h2>Satışlar</h2>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Ürün</th>
                        <th>Personel</th>
                        <th>Müşteri</th>
                        <th>Fiyat</th>
                        <th>Sil</th>
                        <th>Güncelle</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("sal_id") %></td>
                                <td><%# Eval("prd_name") %></td>
                                <td><%# Eval("stf_name_surname") %></td>
                                <td><%# Eval("customer") %></td>
                                <td><%# Eval("sal_price") %> ₺</td>
                                <td><asp:HyperLink ID="DeleteLink" runat="server" CssClass="btn btn-danger" NavigateUrl='<%# "/Sales/SaleDelete.aspx?Delete=" + Eval("sal_id") %>'>Sil</asp:HyperLink></td>
                                <td><asp:HyperLink ID="UpdateLink" runat="server" CssClass="btn btn-warning" NavigateUrl='<%# "/Sales/SaleUpdate.aspx?Update=" + Eval("sal_id") %>'>Güncelle</asp:HyperLink></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-primary" NavigateUrl="/CategoryAdd.aspx">Yeni Kategori Ekle</asp:HyperLink>
        </div>
    </div>
</div>
</asp:Content>
