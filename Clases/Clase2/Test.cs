using System;

namespace Clase2
{
    
    class Test
    {
        static int division( int numerador, int denominador){
            int resultado=0;
            int total=0;
            while (numerador >= (total+denominador)){
                total +=denominador;
                resultado+=1;
            }
            return resultado;
        }

        static int division2(int numerador, int divisor){
            int contador=0;
            int num= numerador;
            while (num-divisor >=0){
                contador+=1;
                num-=divisor;

            }
            return contador;
        }

        static int divisionRecu( int numerador, int divisor){
            if (numerador < divisor ){
                return 0; 
                }
            return 1 + divisionRecu(numerador-divisor, divisor);
        }


       

        static void Main2(string[] args)
        {
            int resultado = division(6,2);
            
            int resultado2 = division(5,2);
            
            int resultado3 = division(9,9);

            int resultado4 = division2(9, 8);
            
            int resultado5 = division2(8, 9);
            int resultado6 = division2(100,10);
            
            int resultador = divisionRecu(6,2);
            
            int resultador2 = divisionRecu(5,2);
            
            int resultador3 = divisionRecu(9,9);

            int resultador4 = divisionRecu(9, 8);
            
            int resultador5 = divisionRecu(8, 9);

            int resultador6 = division(100, 10);
            
            /*Division normal */
           
            Console.WriteLine( "resultadodiv: " + resultado );
            Console.WriteLine( "resultadodiv: " + resultado2 );
            Console.WriteLine( "resultadodiv: " + resultado3 );
            Console.WriteLine( "resultadodiv2: " + resultado4 );
            Console.WriteLine( "resultadodiv2: " + resultado5 );
            Console.WriteLine( "resultadodiv2: " + resultado6 );
            
            Console.WriteLine( "resultadoRecu: " + resultador );
            Console.WriteLine( "resultadoRecu: " + resultador2 );
            Console.WriteLine( "resultadoRecu: " + resultador3 );
            Console.WriteLine( "resultadoRecu: " + resultador4 );
            Console.WriteLine( "resultadoRecu: " + resultador5 );
            Console.WriteLine( "resultadoRecu: " + resultador6 );


            
        }
    }
}
