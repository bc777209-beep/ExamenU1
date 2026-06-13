
namespace Examen1U1.Examen
{
    public class Ejercicio2
    {
        public Ejercicio2()
        {
         decimal saldo;
            string categoria ;
             

             Console.WriteLine("--Bienvenido a BancoCopán--");
             Console.WriteLine("Ingrese el saldo disponible en su tarjeta de ahorro: ");
             saldo = decimal.Parse (Console.ReadLine());

             
            Console.WriteLine($"saldo: {saldo}");
              
              if(saldo<= 1000)
            {

                Console.WriteLine("Categoria: Básico");
                Console.WriteLine("Abra un CDT para mejorar su categoría.");
            }else if ( saldo > 1000 && saldo<=4999  )
            {
               
                 Console.WriteLine("Categoria:Plata");
                 Console.WriteLine("Tiene acceso a tarjeta de débito sin comisión.");
            } else if (saldo >=500 && saldo<= 19999)
            {
               
                 Console.WriteLine("Categoria:Oro");
                Console.WriteLine("¡Felicidades! Accede a tasas preferenciales");
            }else if (saldo>= 20000)
            {
              
                Console.WriteLine("Categoria: Platino");
                Console.WriteLine("¡Cliente VIP! Accede a todos los beneficios del banco.");
            }

           
           



        } 
        
    }
}