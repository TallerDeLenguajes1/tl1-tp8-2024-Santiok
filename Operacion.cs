namespace EspacioOperacion;
public class Operacion {

    private double resultadoAnterior;
    private double nuevoValor;
    private TipoOperacion operacion;

    //Costructor.

    public Operacion(double resultadoAnt, double valorNue, TipoOperacion ope)
    {
        this.resultadoAnterior = resultadoAnt;
        this.nuevoValor = valorNue;
        this.operacion = ope;
    }
    public Operacion()
    {

    }


    public double Resultado{

        get { return resultadoAnterior;}

    }
    public double newValor{

        get { return nuevoValor;}

    }
    public TipoOperacion miOperacion{

        get { return operacion; }
    }

    public enum TipoOperacion{
                                Suma,
                                Resta,
                                Multiplicacion,
                                Division,
                                Limpiar
                            }


}
