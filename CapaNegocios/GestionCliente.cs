using System;
using System.Collections.Generic;
using CapaDatos;
using CapaDatos.ClasesCRUD;
using CapaDatos.Modelos;

namespace CapaNegocios
{
    public class GestionCliente
    {
        public GestionCliente()
        {
            PersistenciaClientes.ListaClientes = new List<Cliente>();
            
        }

        public void GuardarCliente(string cedula, string nombres, string apellidos, string usuario, string contrasenia, int edad)
        {
            PersistenciaClientes.GuardarCliente(new Cliente(cedula, nombres, apellidos, usuario, contrasenia,edad));

            
        }

        public string ListarUsuarios()
        {
            return "" + PersistenciaClientes.RetornarClientesEnString();
        }

        /*public string Ingresoapellido(string apellido)
        {
            PersistenciaClientes.BuscarApellido(apellido);
            return "" + PersistenciaClientes.BuscarApellido(apellido);
        }*/
    }
}
