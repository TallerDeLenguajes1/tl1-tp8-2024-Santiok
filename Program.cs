using EspacioTarea;
using EspacioCalculadora;
using EspacioOperacion;

//EJERCICIO 1.

    int N, opcion;
    Console.WriteLine("\nIngrese la cantidad de tareas pendientes:\n");
    int.TryParse(Console.ReadLine(), out N);

    List<Tarea> tareasPendientes = new List<Tarea>();
    List<Tarea> tareasRealizadas = new List<Tarea>();

    //Creo las N tareas.
    for (int i = 0; i < N; i++)
    {
        Random random = new Random();
        int duracion = random.Next(10, 91);
        Console.WriteLine("\nIngrese una descripcion para la tarea:\n");
        string descripcion = Console.ReadLine();

        Tarea tarea = new Tarea(i+1, descripcion, duracion);

        tareasPendientes.Add(tarea);
   
    }

    //Menu de opciones.

    do
    {
        int aux1;
        Console.WriteLine("\nIngrese una opcion:\n 1)Mover una tarea \n 2)Buscar tarea por descripcion \n 3)Salir\n");
        int.TryParse(Console.ReadLine(), out opcion);

        switch (opcion)
        {
            case 1:
                Tarea tareaAux = new Tarea();

                Console.WriteLine("\nIngrese el ID de la tarea que desea mover:\n");
                int.TryParse(Console.ReadLine(), out aux1);

                tareaAux = moverTarea(tareasPendientes, aux1);

                tareasRealizadas.Add(tareaAux);
                tareasPendientes.Remove(tareaAux);

                Console.WriteLine("\n--------------------Tareas Pendientes--------------------\n");
                mostrarTarea(tareasPendientes);
                Console.WriteLine("\n--------------------Tareas Realizadas--------------------\n");
                mostrarTarea(tareasRealizadas);

            break;

            case 2:
                Tarea tareaAux2 = new Tarea();
                bool contiene;

                Console.WriteLine("\nIngrese una palabra clave:\n");
                string buscar = Console.ReadLine();

                foreach (var tarea in tareasPendientes)
                {
                    contiene = tarea.descripcionTarea.Contains(buscar);

                    if (contiene)
                    {
                        tareaAux2 = tarea;
                    }
                }

                Console.WriteLine("\nEl ID de la tarea es: " + tareaAux2.idTarea + "\n");
                Console.WriteLine("\nDescripcion de la tarea: " + tareaAux2.descripcionTarea + "\n");
                Console.WriteLine("\nLa duracion de la tarea es: " + tareaAux2.duracionTarea + "\n");

            break;

            case 3:
                //Salgo del programa.
            break;
            
            default:
                Console.WriteLine("\nLa opcion ingresada es invalida.\n");
            break;
        }

    } while (opcion != 3);


//FUNCION PARA MOVER TAREA.
Tarea moverTarea(List<Tarea> pendientes, int id)
{
    Tarea tareaAux = new Tarea();
    foreach (var tarea in pendientes)
    {
        if (tarea.idTarea == id)
        {
            tareaAux = tarea;
        }
    }
    return tareaAux;
}

//FUNCION PARA MOSTRAR LAS TAREAS.
void mostrarTarea(List<Tarea> misTarea)
{
    foreach (var tarea in misTarea)
    {
        Console.WriteLine("\nEl ID de la tarea es: " + tarea.idTarea + "\n");
        Console.WriteLine("\nDescripcion de la tarea: " + tarea.descripcionTarea + "\n");
        Console.WriteLine("\nLa duracion de la tarea es: " + tarea.duracionTarea + "\n");
    }
}

//EJERCICIO 2.


