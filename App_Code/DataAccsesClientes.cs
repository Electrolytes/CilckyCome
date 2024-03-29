﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

using Taclientes = DSClientesTableAdapters.ClientesTableAdapter;
using TARestaurantes = DSRestaurantesTableAdapters.RestauranteTableAdapter;
using TAPlatillos = DSPlatillosTableAdapters.PlatillosTableAdapter;
public class DataAccsesClientes
{

    public DataAccsesClientes()
    {

    }
    //esto es del DataSet Clientes
    public static DSClientes buscarClientePorClave(int Clave, out int returnVal)
    {
        Taclientes ta = new Taclientes();
        DSClientes ds = new DSClientes();

        try
        {
            //Aqui se adquirira la informcion de la base de datos y la cantidad
            returnVal = ta.FillByporClave(ds.Clientes, Clave);
        }
        catch (Exception exp)
        {
            //Esto se hace cuando la conexion truena.
            returnVal = -1;
            String mensajeError = exp.Message;
        }

        return ds;
    }

    public static int AltaClientes(string NombreCliente, string Telefono, string Domicilio, string Contraseña, int TipoUsuariso)
    {
        Taclientes ta = new Taclientes();
        DSClientes ds = new DSClientes();
        int returnVal;
        try
        {
            //Aqui se adquirira la informcion de la base de datos y la cantidad
            returnVal = ta.AltaClientes(NombreCliente, Telefono, Domicilio, Contraseña,TipoUsuariso);
        }
        catch (Exception exp)
        {
            //Esto se hace cuando la conexion truena.
            returnVal = -1;
            String mensajeError = exp.Message;
        }

        return returnVal;
    }

    public static DSClientes buscarClientePorNombre(String Nombre, out int returnVal)
    {
        Taclientes ta = new Taclientes();
        DSClientes ds = new DSClientes();

        try
        {

            returnVal = ta.FillByPorNombre(ds.Clientes, Nombre);
        }
        catch (Exception exp)
        {

            returnVal = -1;
            String mensajeError = exp.Message;
        }

        return ds;
    }
    //aqui termina lo del cliente

    //y empiezan los Restaruantes
    public static int AltaRestaurantes(string NombreRestaurante, string Telefono, string Domicilio,string Contraseña, int TipoUsuario)
    {
        TARestaurantes ta = new TARestaurantes();
        DSRestaurantes ds = new DSRestaurantes();
        int returnVal;
        try
        {
            //Aqui se adquirira la informcion de la base de datos y la cantidad
            returnVal = ta.AltaRestaurantes(NombreRestaurante, Telefono, Domicilio,Contraseña, TipoUsuario);
        }
        catch (Exception exp)
        {
            //Esto se hace cuando la conexion truena.
            returnVal = -1;
            String mensajeError = exp.Message;
        }

        return returnVal;
    }
    public static DSRestaurantes BusquedaPorClave(int Clave, out int returnVal)
    {
        TARestaurantes ta = new TARestaurantes();
        DSRestaurantes ds = new DSRestaurantes();
        try
        {
            //Aqui se adquirira la informcion de la base de datos y la cantidad
            returnVal = ta.FillByClave(ds.Restaurante, Clave);
        }
        catch (Exception exp)
        {
            //Esto se hace cuando la conexion truena.
            returnVal = -1;
            String mensajeError = exp.Message;
        }

        return ds;
    }
    public static DSRestaurantes BusquedaPorNombre(String Nombre, out int returnVal)
    {
        TARestaurantes ta = new TARestaurantes();
        DSRestaurantes ds = new DSRestaurantes();
        try
        {
            returnVal = ta.FillByNombre(ds.Restaurante, Nombre);
        }
        catch (Exception exp)
        {
            returnVal = -1;
            String mensajeError = exp.Message;
        }

        return ds;
    }
    //platillos
    public static int AltaPlatillo(int ClaveRestaurante,string NombrePlatillo, string Descripcion, int Precio)
    {
        TAPlatillos ta = new TAPlatillos();
        DSPlatillos ds = new DSPlatillos();
        int returnVal;
        try
        {
            //Aqui se adquirira la informcion de la base de datos y la cantidad
            returnVal = ta.AltaPlatillo(ClaveRestaurante, NombrePlatillo, Descripcion, Precio);
        }
        catch (Exception exp)
        {
            //Esto se hace cuando la conexion truena.
            returnVal = -1;
            String mensajeError = exp.Message;
        }

        return returnVal;
    }
    public static int borrarPlatillo (string NombrePlatillo)
    {
        TAPlatillos ta = new TAPlatillos();
        DSPlatillos ds = new DSPlatillos();
        int returnValida;
        try
        {
            //Aqui se adquirira la informcion de la base de datos y la cantidad
            returnValida = ta.BorrarPlatillo(NombrePlatillo);
        }
        catch (Exception exp)
        {
            //Esto se hace cuando la conexion truena.
            returnValida = -1;
            String mensajeError = exp.Message;
        }

        return returnValida;
    }

    public static DSPlatillos Consultanombre(String nombre, out int ReturnVal)
    {
        DSPlatillos Dsc = new DSPlatillos();
        TAPlatillos Tac = new TAPlatillos();
        try
        {
            DSPlatillos.PlatillosDataTable Cdt = Tac.GetDataByNombrePlatillo(nombre);
            Dsc.Merge(Cdt);
            ReturnVal = Cdt.Rows.Count;
        }
        catch
        {
            ReturnVal = -1;
        }

        return Dsc;
    }    
}

 

