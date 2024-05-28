<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="CustomerUpdate.aspx.cs" Inherits="EntityAspProject.Customers.CustomerUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-6 offset-md-3">
                <h2>Müşteri Güncelle</h2>
                <form runat="server" class="form-category">
                    <div class="form-group">
                        <asp:Label ID="lblCtmID" runat="server" CssClass="form-group" Text="Müşteri ID"></asp:Label>
                        <asp:TextBox runat="server" ID="txtCtmID" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblCtmName" runat="server" CssClass="form-group" Text="Müşteri Adı"></asp:Label>
                        <asp:TextBox runat="server" ID="txtCtmName" CssClass="form-control" placeholder="Müşteri Adı..."></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblCtmSurname" runat="server" CssClass="form-group" Text="Müşteri Soyadı"></asp:Label>
                        <asp:TextBox runat="server" ID="txtCtmSurname" CssClass="form-control" placeholder="Müşteri Soyadı..."></asp:TextBox>
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:Button runat="server" ID="btnCtmUpdate" CssClass="btn btn-primary" Text="Güncelle" OnClick="btnCtmUpdate_Click" />
                    </div>
                </form>
            </div>
        </div>
    </div>

</asp:Content>
