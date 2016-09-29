<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrering.aspx.cs" Inherits="Webshop.SitesLogIn.Registrering" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="width: 188px">Firstname:</td>
            <td style="width: 132px">
                <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
            </td>
            <td style="width: 127px">Username:</td>
            <td>
                <asp:TextBox ID="txtuname" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtuname" ErrorMessage="Username not found" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 188px">Lastname:</td>
            <td style="width: 132px">
                <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
            </td>
            <td style="width: 127px">Password:</td>
            <td>
                <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 188px">Adress:</td>
            <td style="width: 132px">
                <asp:TextBox ID="txtadress" runat="server"></asp:TextBox>
            </td>
            <td style="width: 127px">Confirm Password:</td>
            <td>
                <asp:TextBox ID="txtconpass" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 188px">Zipcode:</td>
            <td style="width: 132px">
                <asp:TextBox ID="txtzip" runat="server"></asp:TextBox>
            </td>
            <td style="width: 127px">Email:</td>
            <td>
                <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 188px">City:</td>
            <td style="width: 132px">
                <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>
            </td>
            <td style="width: 127px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
