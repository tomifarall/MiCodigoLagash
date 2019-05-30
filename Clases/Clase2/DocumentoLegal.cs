using System;
using System.Collections.Generic;

interface Imprimible{
    void Imprimir();
}

interface Grabable{
    void Grabar();
}
class MalaOnda{
    private MalaOnda(){  //nadie puede inicializar la clase sirve para tener todos metodos static 

    }
}

abstract class MiClaseBase{
    public abstract void Imprimir();
}
abstract class DocumentoLegal: MiClaseBase, Imprimible, Grabable{

    protected int Numero;
    private int codEnBaseDeDatos; 
    protected int fechaAlta; 

    public int Monto { get; set; } 

   // public override void Imprimir(){}

    void Imprimible.Imprimir(){
        try{
        Grabar();
        }
        catch{
            Console.WriteLine( "no puedo grabar");

        }
        if ( true /*No hay papel */){
            throw new NoHayPapelException{ Impresora = "Imp#1"};
        }
        else if ( true /*No hay tinta */){
            throw new Exception();
        }
        else if ( true /*impresora apagada */){
            throw new Exception();
        }
    }
    public void Grabar(){
        throw new Exception(); 

    }

    virtual public void Imprimir2(){
        Console.WriteLine("Soy un DL: " + GetNumero());
    }
    public DateTime Fecha{
        get{
            return Fecha;
        }
        protected set{
            Fecha = value;
        }
    }

    public int Edad{
        get;
        set;
    }
    public int GetNumero(){
        return Numero;
    }

    protected void SetNumero(int numero){
        this.Numero= numero;
    }
    protected static void Hacer(){

    }

    public DocumentoLegal(int numero){  //Constructor se llama igual que la clase 
        this.Numero = numero; 
    }
    public void Enviar(){
        Console.WriteLine( "DocumentoLegal.Enviar");

    }
    private void GuardarEnBaseDeDatos(){
        Console.WriteLine( "DocumentoLegal.GuardarEnBaseDeDatos ");

    }
}

class ListaDeDocumentoLegal{
    private DocumentoLegal[] lista; 
    public ListaDeDocumentoLegal( DocumentoLegal[] milista){
        this.lista= milista;
    }
    public int Total(){
        int total = 0;
        for ( var f = 0; f < lista.Length; f++){
            total+= lista[f].Monto;
        }
        return total;
    }
}
