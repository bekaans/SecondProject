<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciListesi.aspx.cs" Inherits="OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci ID </th>
            <th>Öğrenci AD </th>
            <th>Öğrenci SOYAD </th>
            <th>Öğrenci NUMARA </th>
            <th>Öğrenci ŞİFRE </th>
            <th>Öğrenci FOTOĞRAF </th>
        </tr><tbody>
            <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                
                <td><%#Eval("ID") %></td>
                <td>><%#Eval("AD") %></td>
                <td>><%#Eval("SOYAD") %></td>
                <td>><%#Eval("NUMARA") %></td>
                <td>><%#Eval("SİFRE") %></td>
                <td>><%#Eval("FOTOĞRAF") %></td>
                <asp:HyperLink ID="HyperLink1" CssClass ="btn btn-danger" runat="server">Sil</asp:HyperLink>
                <asp:HyperLink ID="HyperLink2" CssClass ="btn btn-succes" runat="server">Güncelle</asp:HyperLink>
            </tr>
            </ItemTemplate>
            </asp:Repeater>
             </tbody>
    </table>
</asp:Content>

