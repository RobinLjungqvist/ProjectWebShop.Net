<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrering.aspx.cs" Inherits="Webshop.SitesLogIn.Registrering" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="width: 159px; text-align: right">Firstname:</td>
            <td style="width: 233px">
                <asp:TextBox ID="txtfirstname" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td style="width: 142px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Firstname requierd" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td style="width: 157px; text-align: right">Username:</td>
            <td style="width: 156px">
                <asp:TextBox ID="txtusername" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td style="width: 11px">
                <asp:Label ID="Label6" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Username requierd" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px; text-align: right">Lastname:</td>
            <td style="width: 233px">
                <asp:TextBox ID="txtlastname" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td style="width: 142px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Lastname requierd" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td style="width: 157px; text-align: right">Password:</td>
            <td style="width: 156px">
                <asp:TextBox ID="txtpass" runat="server" TextMode="Password" Width="150px"></asp:TextBox>
            </td>
            <td style="width: 11px">
                <asp:Label ID="Label7" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" EnableTheming="True" ErrorMessage="Password requierd" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px; text-align: right">Zipcode:</td>
            <td style="width: 233px">
                <asp:TextBox ID="txtzip" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td style="width: 142px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Zipcode requierd" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td style="width: 157px; text-align: right">Confirm Password:</td>
            <td style="width: 156px">
                <asp:TextBox ID="txtconpass" runat="server" TextMode="Password" Width="150px"></asp:TextBox>
            </td>
            <td style="width: 11px">
                <asp:Label ID="Label8" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Confirmation of the password is requierd" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px; text-align: right">Adress:</td>
            <td style="width: 233px">
                <asp:TextBox ID="txtadre" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td style="width: 142px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Adress requierd" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td style="width: 157px; text-align: right">Email:</td>
            <td style="width: 156px">
                <asp:TextBox ID="txtemail" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td style="width: 11px">
                <asp:Label ID="Label9" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email Requierd" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px; text-align: right">City:</td>
            <td style="width: 233px">
                <asp:DropDownList ID="DropDownListcity" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label5" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td style="width: 142px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="City requierd" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td style="width: 157px">&nbsp;</td>
            <td style="width: 156px">&nbsp;</td>
            <td style="width: 11px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px">&nbsp;</td>
            <td style="width: 233px">&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 142px">&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 157px">&nbsp;</td>
            <td style="width: 156px">
                <asp:Button ID="btnReg" runat="server" Height="25px" Text="Register" Width="158px" />
            </td>
            <td style="width: 11px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
