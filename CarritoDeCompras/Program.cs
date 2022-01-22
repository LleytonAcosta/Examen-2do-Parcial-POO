using System;
using System.Linq;
using CapaNegocios;
using System.Collections.Generic;




namespace CarritoDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionCliente cliente = new GestionCliente();                                                          
            cliente.GuardarCliente("1112223334", "Michael Jackson", "Zambrano Zambrano", "michael@email.ec", "123",20);
                                                                                                      
            cliente.GuardarCliente("2223334445", "Juana Maria", "Pueblo Zambrano", "juan@mail.com", "123",19);

            //Console.WriteLine(" 1) Los clientes ordenados alfabeticamente de A a Z. (1 Puntos)");

            //Console.WriteLine("2) Los clientes mayores de 18 años ordenados alfabeticamente de Z a A. (2 Puntos)");

            //Console.WriteLine("3) El cliente cuyo apellido sea un parametro ingresado por el usuario a traves del teclado. (2 Puntos)");

            //Console.WriteLine(" Ingresar Apellido");
            //string ingresar = Console.ReadLine();

            //Console.WriteLine("Cliente encontrado :  \n"+ cliente.Ingresoapellido(ingresar));
            //Console.WriteLine("4) El cliente de mayor edad. (2 Puntos)");
            Console.WriteLine("5) El promedio de edad de los clientes. (1 Puntos)");
            Console.WriteLine(cliente.ListarUsuarios());
            Console.ReadKey();




            // Muestra lo relacionado con Productos
            /*GestionProductos producto = new GestionProductos();
            Console.WriteLine(producto.ListarProductos());*/
            

            
        }
        
           /*
            4) El cliente de mayor edad. (2 Puntos)
            5) El promedio de edad de los clientes. (1 Puntos)
         */


    }
}
