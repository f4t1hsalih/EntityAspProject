<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="CategoryAdd.aspx.cs" Inherits="EntityAspProject.CategoryAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-6 offset-md-3">
                <h2>Kategori Ekle</h2>
                <form runat="server" class="form-category">
                    <div class="form-group">
                        <asp:TextBox runat="server" ID="txtCategoryName" CssClass="form-control" placeholder="Kategori Adı"></asp:TextBox>
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:Button runat="server" ID="btnCategoryAdd" CssClass="btn btn-primary" Text="Kategori Ekle" OnClick="btnCategoryAdd_Click"/>
                    </div>
                </form>
            </div>
        </div>
    </div>

</asp:Content>
