<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SaleUpdate.aspx.cs" Inherits="EntityAspProject.Sales.SaleUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-6 offset-md-3">
                <h2>Satış Güncelle</h2>
                <form runat="server" class="form-category">
                    <div class="form-group">
                        <asp:Label ID="lblPrdName" runat="server" CssClass="form-group" Text="Ürün"></asp:Label>
                        <asp:DropDownList ID="ddlPrdName" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblStfName" runat="server" CssClass="form-group" Text="Personel"></asp:Label>
                        <asp:DropDownList ID="ddlStfName" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblCtmName" runat="server" CssClass="form-group" Text="Müşteri"></asp:Label>
                        <asp:DropDownList ID="ddlCtmName" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblPrice" runat="server" CssClass="form-group" Text="Fiyat"></asp:Label>
                        <asp:TextBox runat="server" ID="txtPrice" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="btnSalUpdate" CssClass="btn btn-primary" Text="Satış Güncelle" OnClick="btnSalUpdate_Click" />
                    </div>
                </form>
            </div>
        </div>
    </div>

</asp:Content>
