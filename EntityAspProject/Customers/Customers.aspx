<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="EntityAspProject.Customers.Customers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-10 offset-md-1">
                <h2>Müşteriler</h2>
                <table class="table table-bordered">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Müşteri Adı</th>
                            <th>Müşteri Soyadı</th>
                            <th>Sil</th>
                            <th>Güncelle</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><%# Eval("ctm_id") %></td>
                                    <td><%# Eval("ctm_name") %></td>
                                    <td><%# Eval("ctm_surname") %></td>
                                    <td>
                                        <asp:HyperLink ID="DeleteLink" runat="server" CssClass="btn btn-danger" NavigateUrl='<%# "/Customers/CustomerDelete.aspx?Delete=" + Eval("ctm_id") %>'>Sil</asp:HyperLink>
                                    </td>
                                    <td>
                                        <asp:HyperLink ID="UpdateLink" runat="server" CssClass="btn btn-warning" NavigateUrl='<%# "/Customers/CustomerUpdate.aspx?Update=" + Eval("ctm_id") %>'>Güncelle</asp:HyperLink>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>

                <div>
                    <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#Modal1">Yeni Müşteri Ekle</button>

                    <div class="modal" id="Modal1">
                        <div class="modal-dialog">

                            <div class="modal-content">

                                <div class="modal-header">
                                    <h2 class="modal-title">Müşteri Ekleme Paneli</h2>
                                </div>

                                <form runat="server">
                                    <div class="modal-body">
                                        <div class="form-group">
                                            <asp:Label ID="lblCtmName" runat="server" Text="Ad"></asp:Label>
                                            <asp:TextBox ID="txtCtmName" runat="server" CssClass="form-control" placeholder="Müşteri Adı..."></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblCtmSurname" runat="server" Text="Soyad"></asp:Label>
                                            <asp:TextBox ID="txtCtmSurname" runat="server" CssClass="form-control" placeholder="Müşteri Soyadı..."></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="modal-footer">
                                        <asp:Button ID="btnCtmKaydet" runat="server" CssClass="btn btn-info" Text="Kaydet" OnClick="btnCtmKaydet_Click" />
                                        <button type="button" class="btn btn-danger" data-dismiss="modal">Vazgeç</button>
                                    </div>
                                </form>

                            </div>

                        </div>
                    </div>

                </div>

            </div>
        </div>
    </div>

</asp:Content>
