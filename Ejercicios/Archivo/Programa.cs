using System;
using System.Collections.Generic;
using System.IO; 


namespace Archivo{

    class Programa{

        static void EscribirEnArchivo(List<Persona> ListaDePersonas){
        using (StreamWriter file = new StreamWriter(@"C:\Users\tomasc\Desktop\Lagash\Archivo\Nombres-Telefonos.txt",true))
        {
            foreach (Persona persona in ListaDePersonas){
                string linea = string.Format("Nombre: {0} Telefono: {1}", persona.Nombre, persona.Telefono);
                file.WriteLine(linea);
            }
        }
        }

        static void LeerDeArchivo(string path){
            string[] LineasDelArchivo = File.ReadAllLines(path);
            foreach (string linea in LineasDelArchivo){
            Console.WriteLine("\n" + linea);
            }
        }
        
        
        static void Main( ){
        
        Persona persona1 = new Persona ("Tomas Farall ", 113135);
        Persona persona2 = new Persona("pepe", 1138315);
        Persona persona3 = new Persona ("skerry", 48765643);
        Persona persona4 = new Persona ("lebron", 49330987);
        
        
        List <Persona> Personas = new List <Persona>();
        Personas.Add(persona1);
        Personas.Add(persona2);
        Personas.Add(persona3);
        Personas.Add(persona4);

        EscribirEnArchivo(Personas); 
        LeerDeArchivo(@"C:\Users\tomasc\Desktop\Lagash\Archivo\Nombres-Telefonos.txt");
        }
    }
}
