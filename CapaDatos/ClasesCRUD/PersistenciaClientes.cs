using System;
using System.Collections.Generic;
using System.Linq;
using CapaDatos.Modelos;

namespace CapaDatos.ClasesCRUD
{
    public static class PersistenciaClientes
    {
        public static List<Cliente> ListaClientes { get; set; }

        //CRUD
        //CREATE
        public static void GuardarCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
        }

        //UPDATE
        public static void ModificarCliente(string cedula, string nombres, string apellidos, int edad)
        {
            Cliente cliente = ListaClientes.Find(x => x.Cedula == cedula);
            cliente.Nombres = nombres;
            cliente.Apellidos = apellidos;
            cliente.Edad = edad;
        }


        //DELETE
        public static void EliminarCliente(string cedula)
        {
            ListaClientes.RemoveAll(cliente => cliente.Cedula == cedula);
        }

        //READ
        //UN OBJETO
        public static Cliente BuscarCliente(string cedula)
        {

            return ListaClientes.Find(cliente => cliente.Cedula == cedula);
        }

        //LISTADO DE OBJETOS FORMATEADOS SEGÚN REQUERIMIENTO
      public static string RetornarClientesEnString()
        {

            // Literal 1
            //Logrado en la Clase Gestion cliente.cs de la capa de CaNegocios
            /*List<string> client = (from data in ListaClientes
                                   orderby data.Nombres ascending
                                   select data.Nombres + " " + data.Apellidos).ToList();
            return string.Join("\n", client);*/

            //Literal 2
            /*var Mayor18 = ListaClientes.OrderByDescending(mostrar => mostrar.Edad).Select(nomb => new { nomb.Nombres, nomb.Apellidos, nomb.Edad });
            return string.Join("\n", Mayor18);*/


            //litearl 4
            /*var MayorEdad = ListaClientes.OrderByDescending(p => p.Edad).First();
            return (string.Join(" ", MayorEdad.Nombres, " ", MayorEdad.Apellidos, " ","Con", MayorEdad.Edad, "Años ","\n"));*/

            // literal 5
            var Promed = ListaClientes.Average(j => j.Edad);
            return (string.Join("\n", Promed));


        }




        // literal 3  Buscar Apellido de Cliente
        /*public static string BuscarApellido(string apelli)
        {
            var add = ListaClientes.Where(i => i.Apellidos == apelli).Aggregate(" ", (center, datos) => center += $"-{datos.Apellidos}{datos.Nombres}\n").Select(i => i);
            return (string.Join("", apelli));
        }*/



    }
}
