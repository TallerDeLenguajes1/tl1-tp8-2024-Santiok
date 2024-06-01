namespace EspacioCalculadora;
using EspacioOperacion;

public class Calculadora
{
    private double dato;

    //Metodo para sumar.
    public void Sumar(double termino){
        dato += termino;
    }

    //Metodo para restar.
    public void Restar(double termino){
        dato -= termino;
    }

    //Metodo para multiplicar.
    public void Multiplicar(double termino){
        dato *= termino;
    }

    //Metodo para dividir.
    public void Dividir(double termino){
        if (termino != 0)
        {
            dato /= termino;
        } else
        {
            Console.WriteLine("\nNo se puede dividir en cero");
        }
    }

    //Metodo para limpiar.
    public void Limpiar(){
        dato = 0;
    }


    //Propiedad para ver el resultado.
    public double Resultado
    {
        get { return dato; }
    }

}