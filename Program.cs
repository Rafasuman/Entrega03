using System;
using Entidad;

namespace Tienda
{
    class Program
    {
        static void Main(string[] args)
        {
            Articulo articulo = new Articulo(10, "aceite", 1200);
            int cantidad = 5;
            Articulo articulo2 = new Articulo(10, "yuca", 4000);
            int cantidad2 = 4;


            Factura factura = new Factura();
            factura.AddDetalle(articulo, cantidad);
            factura.AddDetalle(articulo2, cantidad2);

            foreach (var item in factura.Detalles)
            {
                Console.WriteLine(item.ToString());

            }
            Console.WriteLine(factura.ToString());
        }
    }
}
