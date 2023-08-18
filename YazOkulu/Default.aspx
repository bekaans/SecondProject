<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <div class="form-group">

<form id="Form1" runat="server">

 <div>
        <asp:Label ID="txtAd" runat="server" Text="Ogrenci Adi "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
</div>
    <br />
    <div>
        <asp:Label ID="txtSoyad" runat="server" Text="Ogrenci Soyadı "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
</div>
     <br />
    <div>
        <asp:Label ID="txtNumara" runat="server" Text=" Numara "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
</div>
     <br />
    <div>
        <asp:Label ID="txtSifre" runat="server" Text="Sifre  "></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
</div>
     <br />
    <div>
        <asp:Label ID="txtFotograf" runat="server" Text="Fotoğraf "></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
</div>
    
    
    
    
    
    </div>
    
    <asp:Button ID="Button1" runat="server" CssClass="btn-info" Text="Kaydet" OnClick="Button1_Click" />
</form>

</asp:Content>

