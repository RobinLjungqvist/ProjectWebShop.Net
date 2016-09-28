<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Webshop.SitesLogIn.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="width: 142px; text-align: right">Username:</td>
            <td style="width: 154px">
                <asp:TextBox ID="txtusername" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td style="width: 216px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ErrorMessage="Username requierd" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 142px; text-align: right">Password</td>
            <td style="width: 154px">
                <asp:TextBox ID="txtpassword" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td style="width: 216px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password requierd" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 142px; height: 30px"></td>
            <td style="width: 154px; height: 30px">
                <asp:Button ID="btnlog" runat="server" Text="Login" Width="100px" />
                <asp:Button ID="btnreg" runat="server" OnClientClick="Responed.redirect(&quot;~/Registrering.aspx&quot;);" Text="Register" Width="100px" />
            </td>
            <td style="width: 216px; height: 30px">
                <asp:Label ID="lblWronginput" runat="server" ForeColor="Red" Text="Username or password is incorrect"></asp:Label>
            </td>
            <td style="height: 30px"></td>
            <td style="height: 30px"></td>
            <td style="height: 30px"></td>
        </tr>
        <tr>
            <td style="width: 142px">&nbsp;</td>
            <td style="width: 154px">&nbsp;</td>
            <td style="width: 216px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 142px">&nbsp;</td>
            <td style="width: 154px">&nbsp;</td>
            <td style="width: 216px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
