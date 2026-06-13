      
namespace  Examen1U1.Examen
{
    public class Ejercicio3
    {
       public Ejercicio3()
        {
            int numero,tabla;
            int contador;
            int limite;
            Console.WriteLine("Ingrese el numero de la tabla que desea:");
            numero=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el limite:");
            limite=int.Parse(Console.ReadLine());
             

             if (numero <= 0)
                {
                    Console.WriteLine("El numero debe ser mayor a 0");
            }else{
                 Console.WriteLine($"La tabla de multiplicar  del: {numero}  ");

            for (contador=1;contador<= limite; contador++){

                tabla= numero * contador;
               
                Console.WriteLine($"{numero} x {contador} = {tabla}");
                 
                }

            }
         
            
        }
    }
} 

        
    
