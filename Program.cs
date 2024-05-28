using EspacioTarea;

//FUNCION PARA MOVER TAREA.
void moverTarea(List<Tarea> pendientes);



    int N, opcion;
    Console.WriteLine("\nIngrese la cantidad de tareas pendientes:\n");
    int.TryParse(Console.ReadLine(), out N);

    List<Tarea> tareasPendientes = new List<Tarea>();
    List<Tarea> tareasRealizadas = new List<Tarea>();

    //Creo las N tareas.
    for (int i = 0; i < N; i++)
    {
        Random random = new Random();
        int duracion = random.Next(10, 91), cont = 1;
        Console.WriteLine("\nIngrese una descripcion para la tarea:\n");
        string descripcion = Console.ReadLine();

        Tarea tarea = new Tarea(cont, descripcion, duracion);

        tareasPendientes.Add(tarea);
        cont++;
    }

    do
    {
        int aux1;
        Console.WriteLine("\nIngrese una opcion:\n 1)Mover una tarea \n 2)Buscar tarea por descripcion \n 3)Salir\n");
        int.TryParse(Console.ReadLine(), out opcion);

        switch (opcion)
        {
            case 1:
                Console.WriteLine("\nIngrese el ID de la tarea que desea mover:\n");
                int.TryParse(Console.ReadLine(), out aux1);
            break;

            case 2:
            break;

            case 3:
                //Salgo del programa.
            break;
            
            default:
                Console.WriteLine("\nLa opcion ingresada es invalida.\n");
            break;
        }

    } while (opcion != 3);



