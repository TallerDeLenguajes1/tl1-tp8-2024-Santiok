namespace EspacioTarea;
public class Tarea
{
    private int tareaID;
    private string descripcion;
    private int duracion;

    public Tarea()
    {
        
    }

    //Metodo constructor.
    public Tarea(int miId, string miDescripcion, int auxDuracion)
    {
        this.tareaID = miId;
        this.descripcion = miDescripcion;
        this.duracion = auxDuracion;
    }

    //Metodo para acceder a los campos de la clase.
    public int idTarea
    {
        get { return tareaID; }
    }
    public string descripcionTarea
    {
        get { return descripcion ;}
    }
    public int duracionTarea
    {
        get { return duracion; }
    }

}