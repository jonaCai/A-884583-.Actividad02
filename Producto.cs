using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_884583_.Actividad02
{
    public class Producto
    {
        public int codigo_producto { get; set; }
        public int stock_producto { get; set; }
        public string nombre_producto { get; set; }
        
 


        public static Producto ingresarNuevo()
        {

            var producto = new Producto();
            int stock;
            int codigo;

            

            do
            {

                string ingreso = "Ingrese el número del producto: ";
                codigo = ValidarEntero(ingreso);
                if (CatalogoDeProductos.Existe(codigo))
                {
                    Console.WriteLine("El codigo ya fue asignado a un producto");
                    continue;
                }

                    producto.codigo_producto = codigo;
            } while (producto.codigo_producto==0);



            
            do
            {
               
                string ingreso = "Ingrese el stock del producto: ";
                stock = ValidarEntero(ingreso);               
                if (stock<0 )
                {
                    Console.WriteLine("Debe ingresar un número positivo");
                    continue;
                }


                producto.stock_producto = stock;

            } while (producto.stock_producto <0);


       

            do
            {
                Console.Write("Ingrese el nombre del producto: ");
                var ingreso = Console.ReadLine();
                if (string. IsNullOrWhiteSpace(ingreso))
                {

                    Console.WriteLine("Debe ingresar un nombre. ");
                    break;
                }
                producto.nombre_producto = ingreso;

            } while (string.IsNullOrWhiteSpace(producto.nombre_producto));




            return producto;
        }

        public static void entregaSumarStock()
        {
            
            int codigo;
            int pedido;

            do
            {
                

                string ingreso = "Ingrese el numero del producto: ";
                codigo = ValidarEntero(ingreso);
                if (CatalogoDeProductos.Existe(codigo))
                {
                    string texto = "Ingrese la cantidad de la entrega: ";
                    do
                    {
                        pedido = ValidarEntero(texto);

                        if (pedido < 0)
                        {
                            Console.WriteLine("Ingrese un numero positivo.");
                        }

                    } while (pedido<0);

                    CatalogoDeProductos.ModificarStock(pedido,codigo);

                    continue;
                }
                else
                {

                    Console.WriteLine("El numero de producto no esta registrado.");
                }



            } while (codigo == 0 || !(CatalogoDeProductos.Existe(codigo)));
            
           
        }


     


        public static void pedidoRestarStock()
        {

         
            int codigo;
            int entrega;
            

            do
            {
                string ingreso= "Ingrese el numero del producto: ";
                codigo = ValidarEntero(ingreso);
                if (CatalogoDeProductos.Existe(codigo))
                {
                    string texto = "Ingrese la cantidad del pedido: ";
                    do
                    {
                        entrega = ValidarEntero(texto);
                    
                        if (entrega>0)
                        {
                             
                            Console.WriteLine("Ingrese un numero negativo.");
                        }

                    } while (entrega>0);

                    CatalogoDeProductos.ModificarStock(entrega, codigo);

                    continue;
                }
                else
                {

                    Console.WriteLine("El numero de producto no es valido.");
                }


            } while (codigo == 0 || !(CatalogoDeProductos.Existe(codigo)) );


        }

     

        static int ValidarEntero(string texto)
        {
            int resultado;
            string numero;
            bool flag = false;

            do
            {
                Console.Write(texto);
                numero = Console.ReadLine();

                if (!int.TryParse(numero, out resultado))
                {
                    Console.WriteLine("Debe ingresar un número entero.");
                }
                else
                {
                    flag = true;
                };


            } while (flag == false);

            return resultado;
        }
    }
}
