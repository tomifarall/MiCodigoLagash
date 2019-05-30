using System;

namespace programa {
    class program {
        static void Main2(String[] args){
            int[] array= new int[10] {1,2,3,4,5,6,7,8,9,10};
            int total=0;
            for ( int i=0; i<10; i++){
                total += i;
            }
            if ((total % 3) == 0) {
                Console.WriteLine("El numero: " + total + " es divisible por 3");
            }
            else{
                Console.WriteLine( "El numero: " + total + " no es divisible por 3");
            }
        }
    }
    
}