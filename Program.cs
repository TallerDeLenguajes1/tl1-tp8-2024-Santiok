using EspacioTarea;

int N;



Console.WriteLine("\nIngrese la cantidad de tareas pendientes:\n");
int.TryParse(Console.ReadLine(), out N);

List<Tarea> listaTareas = new List<Tarea>();

for (int i = 0; i < N; i++)
{
    Random random = new Random();
    int duracion = random.Next(10, 91), cont = 1;
    Console.WriteLine("\nIngrese una descripcion para la tarea:\n");
    string descripcion = Console.ReadLine();

    Tarea tarea = new Tarea(cont, descripcion, duracion);

    listaTareas.Add(tarea);
    cont++;
}
