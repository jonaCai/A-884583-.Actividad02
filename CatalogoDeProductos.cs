using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_884583_.Actividad02
{
    static class CatalogoDeProductos
    {

        static  Dictionary<int, Producto> entrada = new Dictionary<int, Producto>();



        public static bool Existe(int codigo)
        {
            return entrada.ContainsKey(codigo);

        }

        public static void mostrarProductos()
        {
            foreach (var a in entrada)
            {
                Console.WriteLine("Los productos y su stock son: ");
                Console.WriteLine($"Numero de producto: {a.Value.codigo_producto} -Nombre de producto: {a.Value.nombre_producto} -Stock de producto: {a.Value.stock_producto}");


            }
        }

        public static void ModificarStock(int cantidad, int codigo)
        {
           
           
            if ( entrada[codigo].stock_producto + cantidad>=0)
            {
                entrada[codigo].stock_producto = entrada[codigo].stock_producto + cantidad;

            }else
            {
                Console.WriteLine("El stock no puede ser menor a cero");

            }
        }

        internal static void Agregar(Producto producto)
        {

            entrada.Add(producto.codigo_producto, producto);

        }
    }
}
