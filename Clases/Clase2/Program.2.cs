using System;

namespace Clase2
{
    class Programa
    {
        static int division( int numerador, int denominador){
            int resultado=1;
            int total=denominador;
            while (numerador> (total*denominador)){
                total *=denominador;
                resultado+=1;
            }
            return resultado;
        }
        
        
        
        static int HacesrAlgo( int a , int b , out int capricho){
            capricho = 0; 
            return 0;
        }
        static void ImprsimirPersona(Persona p ){
            Console.WriteLine("Nombre: " + p.Nombre + " Apellido: " + p.Apellido + " Sueldo: " + p.Sueldo);
        }
    }
}
