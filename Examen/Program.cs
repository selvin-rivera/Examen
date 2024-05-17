using Examen;


try
{
    string? strN1, strN2, strN3;
    // Crear un objeto con los datos ingresados
    Asignatura asignatura = new Asignatura();
    //pedir al usuario que ingrese los datos necesarios para mostrar los resultados
     Console.WriteLine("Ingrese nombre del estudiante: ");
     asignatura.NombreAlumno = Console.ReadLine();
     Console.WriteLine("Ingrese número de cuenta: ");
     asignatura.NumeroCuenta = Console.ReadLine();
     Console.WriteLine("Ingrese correo electrónico: ");
     asignatura.Email = Console.ReadLine();
     Console.WriteLine("Ingrese nombre de la clase: ");
     asignatura.NombreAsignatura = Console.ReadLine();
     Console.WriteLine("Ingrese horario de la clase: ");
     asignatura.Horario = Console.ReadLine();
     Console.WriteLine("Ingrese nombre del docente: ");
     asignatura.NombreDocente = Console.ReadLine();
     Console.WriteLine();
     int n1, n2, n3;
     bool valida;
     Console.WriteLine("Ingrese primera nota del parcial: ");
     strN1 = Console.ReadLine();
     Console.WriteLine("Ingrese segunda nota del parcial: ");
     strN2 = Console.ReadLine();
     Console.WriteLine("Ingrese segunda nota del parcial: ");
     strN3 = Console.ReadLine();


    // Validar el formato correcto
    bool validN1, validN2, validN3;

    validN1 = int.TryParse(strN1, out asignatura.N1);
    validN2 = int.TryParse(strN2, out asignatura.N2);
    validN3 = int.TryParse(strN3, out asignatura.N3);
    while (true)
    {
        if (!validN1)
        {

            Console.WriteLine("Una de las notas ingresadas no tiene el formato válido");


        }
        else if (!validN2)
        {

            Console.WriteLine("Una de las notas ingresadas no tiene el formato válido");

        }
        else if (!validN3)
        {
            Console.WriteLine("Una de las notas ingresadas no tiene el formato válido");
            
        }
        else
        {
            break;
        }
        return;
    }

    // Validación del primer o segundo parcial que sobrepasa el 30%
    while (true)
    {
        if (asignatura.N1 > 30 || asignatura.N2 > 30)
        {
            Console.WriteLine("La nota del primero o segundo parcial sobrepasa del 30%");
        }
        else
        {
            break;
        }
            return;
    }

    while (true)
    {
        //Validación del tercer parcial que sobrepasa el 40%
        if (asignatura.N3 > 40)
        {
            Console.WriteLine("La nota del tercer parcial sobrepasa del 40%");
        }
        else
        {
            break;
        }
            return;
    }
    asignatura.Imprimir();
}
catch (Exception e) 
{
  Console.WriteLine(e.ToString());
}