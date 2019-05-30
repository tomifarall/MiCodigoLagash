using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int sueldo = 101;
            int empleados = 3;
            int transferencia;
            int[] sueldos = new int[5];
        
            sueldos[0] = 100;
            sueldos[1] = 200;
            transferencia = empleados * sueldo;
            if ( (transferencia % 2 ) == 0){
                Console.WriteLine("par");
            } 
            else{
                Console.WriteLine("Impar");

            }
            Console.WriteLine("monto: " + transferencia);
        }
    }
}
