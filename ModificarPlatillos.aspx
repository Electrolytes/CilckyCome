<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ModificarPlatillos.aspx.cs" Inherits="ModificarPlatillos" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table> 
        <tr class="AltaRestaurantes">
            <td colspan="10">
             <asp:Label ID="LblNombreModificado" runat="server" Text="Nombre Del Platillo"></asp:Label>
            </td>
            <td>
             <asp:TextBox ID="TbNombreModificado" runat="server"></asp:TextBox>
            </td>
        </tr>
            <tr class="AltaRestaurantes">
            <td colspan="10">
             <asp:Label ID="LblDescipcionesModificadas" runat="server" Text="Descripciones "></asp:Label>
            </td>
            <td>
             <asp:TextBox ID="TbDescipcionesModificada" TextMode="MultiLine" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr class="AltaRestaurantes">
            <td colspan="10">
             <asp:Label ID="LblPrecioModificado" runat="server" Text="Precio"></asp:Label>
            </td>
            <td>
             <asp:TextBox ID="TbPrecioModificaco" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr class="AltaRestaurantes">                        
             <td colspan="10" style="border:double">  
            <asp:Button ID="BtnModificar" runat="server" Text="Modificar Platillo " Width="112px" OnClick="BtnModificar_Click"  />
            </td>
             <td colspan="10" style="text-align:center">
             <asp:Label ID="Lblmodificado" runat="server" Text="" ForeColor="Red"></asp:Label>
            </td>
        </tr>
  </table>
</asp:Content>

