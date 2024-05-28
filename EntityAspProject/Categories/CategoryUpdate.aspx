<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="CategoryUpdate.aspx.cs" Inherits="EntityAspProject.Categories.CategoryUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-6 offset-md-3">
                <h2>Kategori Güncelle</h2>
                <form runat="server" class="form-category">
                    <div class="form-group">
                        <asp:Label ID="lblCtgID" runat="server" CssClass="form-group" Text="ID"></asp:Label>
                        <asp:TextBox runat="server" ID="txtCategoryID" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblCtgName" runat="server" CssClass="form-group" Text="Kategori Adı"></asp:Label>
                        <asp:TextBox runat="server" ID="txtCategoryName" CssClass="form-control" placeholder="Kategori Adı..."></asp:TextBox>
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:Button runat="server" ID="btnCategoryUpdate" CssClass="btn btn-primary" Text="Kategori Güncelle" OnClick="btnCategoryUpdate_Click" />
                    </div>
                </form>
            </div>
        </div>
    </div>

</asp:Content>
