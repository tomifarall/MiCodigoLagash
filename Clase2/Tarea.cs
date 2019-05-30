using System;

namespace Clase2
{
    class Tarea
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

        int resultado = division(6,2);
        int resultado2 = division(5,2);

        int resultado3 = division(9,9);

        int resultado4 = division(9, 8);
        int resultado5 = division(8, 9);   
    }

}