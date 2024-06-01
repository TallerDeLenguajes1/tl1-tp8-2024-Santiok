namespace EspacioOperacion;
public class Operacion {

    private double resultadoAnterior;
    private double nuevoValor;
    private TipoOperacion operacion;


    public double Resultado{

        get { return resultadoAnterior;}

    }
    public double newValor{

        get { return nuevoValor;}

    }

    public enum TipoOperacion{
                                Suma,
                                Resta,
                                Multiplicacion,
                                Division,
                                Limpiar
                            }


}
