using System;

class Persona
    {
        public string Nombre{ get; private set;}
        public int Telefono { get; private set;}

        public Persona( string nombre, int telefono){
            this.Nombre= nombre;
            this.Telefono = telefono;
        }


     
    }