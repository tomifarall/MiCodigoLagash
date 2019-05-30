using System;


class Factura : DocumentoLegal{

    


    public override void Imprimir(){
        Console.WriteLine("Soy la FC: " + this.GetNumero());
    }

    public Factura(int numero) : base(numero){

    }

    public void Pagar(){
        Console.WriteLine( "Factura.Pagar");


    }

}

class FacturaExportacion: Factura{
    public String Pais { get ; set;}
    public FacturaExportacion(int numero) : base(numero){

    }
    public override void Imprimir(){
        Console.WriteLine("Soy la F-E: " + GetNumero());
    }
}

class Lista <TIPO> where TIPO: DocumentoLegal{
    private TIPO[] lista;
    
    public Lista( TIPO[] milista){
        this.lista = milista;
    }

    public int Total(){
        int total = 0;
        for ( var f = 0; f < lista.Length; f++){
            total+= lista[f].Monto;
        }
        return total;
    }

    }


class ListaDeFacturas{
    private Factura[] lista; 
    public ListaDeFacturas( Factura[] milista){
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


