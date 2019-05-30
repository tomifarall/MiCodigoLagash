using System;
using System.Collections.Generic ;
using System.Linq;

namespace Clase2
{
    enum TipoEmpleado{
        Empleado, LU, Contratado
    }
    struct Persona{
        
        public string Nombre;

        public string Apellido;
        public long Sueldo;
        
        public TipoEmpleado Tipo;
    }
    class Program
    {
        static int  Suma(params int[] a){
            int suma= 0;
            for( int x = 0; x < a.Length; x++){
                suma += a[x];
            }
            return suma;
        }
        
        static int sumatoria(int numero){
            return (numero == 0) ? 0 : numero + sumatoria(numero-1);
        }

        static int HacerAlgo( int a , int b , out int capricho){
            capricho = 0; 
            return 0;
        }

        static void ImprimirPersona(Persona p ){
            Console.WriteLine("Nombre: " + p.Nombre + " Apellido: " + p.Apellido + " Sueldo: " + p.Sueldo);
        }
        static void Main(string[] args)
        {
            
            Persona persona = new Persona();
            persona.Nombre= "Diego";
            persona.Apellido= "Gonzalez";
            persona.Sueldo = 100;
            persona.Tipo = TipoEmpleado.Empleado;

           /* var otraPersona = new Persona{
                Nombre = "Diego";
                Apellido = "Gonzalez";
                Sueldo = 100;
                Tipo= TipoEmpleado.LU;

            };*/

            ImprimirPersona(persona);

            int cap;
            var r = HacerAlgo( 1,2, out cap);

            var fc = new Factura(1); 
            var nc = new NotaDeCredito(1);
            var nc2 = new NotaDeCredito(2);
            
            
            int d = nc.Edad;

            nc.Edad = 44;

            nc.Imprimir();
            nc2.Imprimir();
            
            var algo = (DocumentoLegal) fc;
            algo = nc;

            var facturas= new Factura[3];
            facturas[1] = new Factura(2);
            facturas[0] = new Factura(1);
            facturas[2] = new Factura(3);


            ListaDeFacturas listaF = new  ListaDeFacturas(facturas);
            listaF.Total();
            var lista = new  Lista <DocumentoLegal>(null);

            var list= new List <DocumentoLegal>();
            list.Sort( new ComparadorDL());
            
            var dic = new Dictionary <string, Factura> ();
            dic.Add("lagash", new Factura(1));
            var fact = dic["lagash"];

            list.Add(facturas[0]);


            HacerAlgoConDocumentos(nc);
            HacerAlgoConDocumentos(fc);

            Func <int, int> f =  delegate(int i ){
                return i+1; 
            }; 

            Func <int, int, int> f1 =  delegate(int i, int j  ){
                return i+1; 
            }; 

            Func <int> f2 =  delegate( ){
                return 1; 
            }; 
            Func<DocumentoLegal, bool> siEsPar = delegate (DocumentoLegal dl){
                return ((dl.Monto % 2 ) == 0) ;
            };

            list.Where(delegate(DocumentoLegal dl){
                return ( dl.Monto % 2) == 0 ;
            }); 

            siEsPar =(DocumentoLegal dl) => ((dl.Monto % 2 ) == 0) ;
    

            list.Where(siEsPar);

            var nnc = NotaDeCredito.LeerDeBaseDeDatos();
            NotaDeCredito onc= null;

            try{
            onc.Imprimir();  
            } 
            catch {
                Console.WriteLine("reporteError"); 
            }

            List <string> nombres = new List <string>();
            nombres.Add("Diego");
            nombres.Add("Diego");
            nombres.Add("Diego");

            foreach (var nom in nombres.Where((nn) => nn[0] == 'D')){
                Console.WriteLine(nom); 
            }

        }

        static void HacerAlgoConDocumentos(DocumentoLegal dl){
            dl.Imprimir();

        }
    }

}

class ComparadorDL : IComparer<DocumentoLegal> {
    public int Compare( DocumentoLegal x , DocumentoLegal y)
    {
        if (x.Monto > y.Monto) return -1; 
        else if ( x.Monto < y.Monto) return 1;
        return 0; 
    }
}

class NoHayPapelException : Exception{
    public string Impresora { get; set;}

}


//Programa que escriba en un archivo de texto un listado de personas y telefonos
// El programa tiene que tambine poder leer el archivo y cargarlo en una coleccion
// si modifico el archivo tengo que poder leerlo nuevamente 