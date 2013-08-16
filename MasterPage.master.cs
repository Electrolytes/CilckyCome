using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MenuItem temp;

        MnPrincipal.Items.Clear();

        temp = new MenuItem("Inicio", "Inicio");
        temp.NavigateUrl = "~/Default.aspx";
        MnPrincipal.Items.Add(temp);

        temp = new MenuItem("Ingreso", "Ingreso");
        temp.NavigateUrl = "~/Ingreso.aspx";
        MnPrincipal.Items.Add(temp);

        temp = new MenuItem("Alta Usuarios", "Alta Usuarios");
        temp.NavigateUrl = "~/AltaRestaurantes.aspx";
        MnPrincipal.Items.Add(temp);

        if (Session["idUsuario"] != null)
        {
            int idUsuario = (int)Session["idUsuario"];
            int returnVal = 0;

            DSClientes ds = DataAccsesClientes.buscarClientePorClave(idUsuario, out returnVal);

            int tipoUsuario = ds.Clientes[0].Tipo_Usuarios;

            switch (tipoUsuario)
            {
                case 1:
                    temp = new MenuItem("Pedidios", "Pedidos");
                    temp.NavigateUrl = "~/Calculadora2.aspx";
                    break;

                case 2:
                    temp = new MenuItem("Ingresar Platillos", "Ingresar Platillos");
                    temp.NavigateUrl = "~/Restaurante.aspx";
                    break;
            }

            MnPrincipal.Items.Add(temp);
        }
    }
}
