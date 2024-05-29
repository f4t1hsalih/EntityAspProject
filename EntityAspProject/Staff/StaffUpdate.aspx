<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="StaffUpdate.aspx.cs" Inherits="EntityAspProject.Staff.StaffUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-6 offset-md-3">
                <h2>Personel Güncelle</h2>
                <form runat="server" class="form-category">
                    <div class="form-group">
                        <asp:Label runat="server" Text="Personel Ad-Soyad"></asp:Label>
                        <asp:TextBox runat="server" ID="txtStfNameSurname" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="btnStfUpdate" CssClass="btn btn-primary" Text="Güncelle" OnClick="btnStfUpdate_Click" />
                    </div>
                </form>
            </div>
        </div>
    </div>

</asp:Content>
