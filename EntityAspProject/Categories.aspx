<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="EntityAspProject.Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-10 offset-md-1">
                <h2>Kategoriler</h2>
                <table class="table table-bordered">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Kategori Adı</th>
                            <th>Sil</th>
                            <th>Güncelle</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><%# Eval("ctg_id") %></td>
                                    <td><%# Eval("ctg_name") %></td>
                                    <td><asp:HyperLink ID="DeleteLink" runat="server" CssClass="btn btn-danger" NavigateUrl='<%# "CategoryDelete.aspx?Delete=" + Eval("ctg_id") %>'>Sil</asp:HyperLink></td>
                                    <td><asp:HyperLink ID="UpdateLink" runat="server" CssClass="btn btn-warning" NavigateUrl='<%# "CategoryUpdate.aspx?Update=" + Eval("ctg_id") %>'>Güncelle</asp:HyperLink></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-primary" NavigateUrl="CategoryAdd.aspx">Yeni Kategori Ekle</asp:HyperLink>
            </div>
        </div>
    </div>
</asp:Content>
