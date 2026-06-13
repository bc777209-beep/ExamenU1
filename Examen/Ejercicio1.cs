
namespace Examen1U1.Examen
{
    public class Ejercicio1
    {
       public Ejercicio1()
        {
           Console.WriteLine("TIENDA AGROCOPÁN");
           double subtotal,descuento;
           double totalfinal;
           double descuentoporcentaje =0.10;
        
            string nombreProducto = "Fertilizante NPK";
            double PrecioKG= 35.75;
            int cantidad = 12;
            double descuentoPorcentaje;

           subtotal= PrecioKG * cantidad;
           descuento=subtotal * descuentoporcentaje/100;
           totalfinal= subtotal - descuento;

         

           
           Console.WriteLine("-----FACTURA AGROCOPÁN----- ");

           Console.WriteLine($"Producto : {nombreProducto}");
           Console.WriteLine($"Cantidad: {cantidad}");
           Console.WriteLine($"Precio/Kg : L{PrecioKG}");
           Console.WriteLine($"Subtotal : L{subtotal}");
           Console.WriteLine($"Descuento : L{descuento}");
           Console.WriteLine($"Total : {totalfinal}");





        }
    }
}