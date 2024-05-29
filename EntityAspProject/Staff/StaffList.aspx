<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="StaffList.aspx.cs" Inherits="EntityAspProject.Staff.StaffList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

        <div class="container">
    <div class="row">
        <div class="col-md-10 offset-md-1">
            <h2>Çalışanlar</h2>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Çalışan Ad Soyad</th>
                        <th>Sil</th>
                        <th>Güncelle</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("stf_id") %></td>
                                <td><%# Eval("stf_name_surname") %></td>
                                <td><asp:HyperLink ID="DeleteLink" runat="server" CssClass="btn btn-danger" NavigateUrl='<%# "/Staff/StaffDelete.aspx?Delete=" + Eval("stf_id") %>'>Sil</asp:HyperLink></td>
                                <td><asp:HyperLink ID="UpdateLink" runat="server" CssClass="btn btn-warning" NavigateUrl='<%# "/Staff/StaffUpdate.aspx?Update=" + Eval("stf_id") %>'>Güncelle</asp:HyperLink></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-primary" NavigateUrl="/Staff/StaffAdd.aspx">Çalışan Ekle</asp:HyperLink>
        </div>
    </div>
</div>

</asp:Content>
