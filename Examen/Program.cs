using Examen;

try
{
    // Crear una instancia de Asignatura con los datos ingresados
    Asignatura asignatura = new Asignatura();
    //pedir al usuario que ingrese los datos necesarios para mostrar los resultados
    Console.WriteLine("Ingrese nombre del estudiante : ");
    asignatura.NombreAlumno= Console.ReadLine();
    Console.WriteLine("Ingrese número de cuenta : ");
    asignatura.NumeroCuenta = Console.ReadLine();
    Console.WriteLine("Ingrese correo electrónico : ");
    asignatura.Email = Console.ReadLine();
    Console.WriteLine("Ingrese nombre de la clase: ");
    asignatura.NombreAsignatura = Console.ReadLine();
    Console.WriteLine("Ingrese horario de la clase: ");
    asignatura.Horario = Console.ReadLine();
    Console.WriteLine("Ingrese nombre del docente: ");
    asignatura.NombreDocente = Console.ReadLine();
    int n1 = 0;
    int n2 = 0;
    int n3 = 0;
   
    // Captura y validación de N1
    while (true)
    {
        Console.WriteLine("Ingrese la nota del primer parcial : ");
        if (int.TryParse(Console.ReadLine(), out n1) && n1 >= 0 && n1 <= 30)
        {
            break;
        }
        else
        {
            Console.WriteLine("La nota del primero o segundo parcial sobrepasa del 30%");
        }
    }

    // Captura y validación de N2
    while (true)
    {
        Console.WriteLine("Ingrese la nota del segundo parcial : ");
        if (int.TryParse(Console.ReadLine(), out n2) && n2 >= 0 && n2 <= 30)
        {
            break;
        }
        else
        {
            Console.WriteLine("La nota del primero o segundo parcial sobrepasa del 30%");
        }
    }

    // Captura y validación de N3
    while (true)
    {
        Console.WriteLine("Ingrese la nota del tercer parcial : ");
        if (int.TryParse(Console.ReadLine(), out n3) && n3 >= 0 && n3 <= 40)
        {
            break;
        }
        else
        {
            Console.WriteLine("La nota del tercer parcial sobrepasa del 40%.");
        }
    }

    

    // Imprimir los datos de la asignatura y la nota final
    asignatura.Imprimir();
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}