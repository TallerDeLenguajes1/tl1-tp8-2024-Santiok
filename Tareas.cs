namespace EspacioTarea;
public class Tarea
{
    private int tareaID;
    private string descripcion;
    private int duracion;

    public Tarea(int miId, string miDescripcion, int auxDuracion)
    {
        this.tareaID = miId;
        this.descripcion = miDescripcion;
        this.duracion = auxDuracion;
    }
}