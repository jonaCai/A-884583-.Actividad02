using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_884583_.Actividad02
{
    class Program
    {
        static void Main(string[] args)
        {
            string eleccion;
            Console.WriteLine("Bienvenido al sistema de control de Stock FarmaCAI, que desea hacer?:");
            Console.WriteLine("A) Ingresar catálogo de productos.");
            Console.WriteLine("B) Ingresar pedidos/entregas.");
            Console.WriteLine("C) Finalizar y mostrar stock final de los productos.");
            do
            {
                Console.WriteLine();
                Console.Write("Seleccion: ");

                eleccion = Console.ReadLine();
                eleccion = eleccion.ToUpper();
                switch (eleccion)
                {
                    case "A":
                        var producto= Producto.ingresarNuevo();
                        CatalogoDeProductos.Agregar(producto);

                        ; break;
                    case "B":
                        Console.WriteLine("1- para Pedidos:");
                        Console.WriteLine("2- para Entregas:");
                        
                        do
                        {
                            Console.WriteLine();
                            Console.Write("Seleccion: ");
                            eleccion = Console.ReadLine();
                            switch (eleccion)
                            {
                                case "1":
                                    Producto.pedidoRestarStock();

                                    ; break;
                                case "2":
                                    Producto.entregaSumarStock();

                                    ; break;
                                default:
                                    Console.WriteLine("Debe ingresar 1 o 2.");
                                  
                                    ; break;

                            }
                        } while (eleccion !="1" && eleccion !="2");
                        
                        ; break;
                       
                    case "C":

                        CatalogoDeProductos.mostrarProductos();


                        Console.WriteLine("Adios, presione una tecla para terminar.");
                        ; break;
                    default: Console.WriteLine("Debe ingresar: 'A', 'B' o 'C'"); break;

                }
            } while (eleccion != "C");


            Console.ReadKey();
        }
        
    }



}
