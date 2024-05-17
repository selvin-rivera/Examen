
namespace Examen
{
    public class Asignatura : Alumno, IAsignatura
    {
        /// <summary>
        /// Primer número a ingresar
        /// </summary>
        public int N1;

        /// <summary>
        /// Segundo número a ingresar
        /// </summary>
        public int N2;

        /// <summary>
        /// Tercer número a ingresar
        /// </summary>
        public int N3;

        public Asignatura(int n1, int n2, int n3, string? nombreAsignatura, string? horario, string? nombreDocente, string? nombreAsignatura1)
        {
            N1 = n1;
            N2 = n2;
            N3 = n3;
            NombreAsignatura = nombreAsignatura;
            Horario = horario;
            NombreDocente = nombreDocente;
        }

        public Asignatura(int n1, int n2, int n3, string? nombreAsignatura, string? horario, string? nombreDocente, string? nombreAsignatura1, string? horario1, string? nombreDocente1) : this(n1, n2, n3, nombreAsignatura, horario, nombreDocente, nombreAsignatura1)
        {
        }

        public Asignatura()
        {
        }

        // <summary>
        /// Nombre del la asiganatura 
        /// </summary>
        public string? NombreAsignatura {  get; set; }

        // <summary>
        /// Horario
        /// </summary>
        public string? Horario {  get; set; }

        // <summary>
        /// Nombre del docente
        /// </summary>
        public string? NombreDocente {  get; set; }

        // <summary>
        /// Calcula las 3 notas parciales
        /// </summary>
        /// <returns>la nota final</returns>
        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }

        // <summary>
        /// Calcula las 3 notas parciales a partir de los parámetros
        /// </summary>
        /// <returns>la nota final</returns>
        public double CalcularNotaFinal(double N1, double N2, double N3)
        {
            return N1 + N2 + N3;
        }

        // <summary>
        /// Mostrará un mensaje basado en el rango de notas
        /// </summary>
        /// <returns>el mensaje de acuerdo a la nota final 
        /// De 0% a 59%: Reprobado
        /// De 60% a 79%: Bueno 
        /// De 80% a 89%: Muy Bueno
        /// De 90% a 100% Sobresaliente</returns>
        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal < 60)
            {
                return "Reprobado";
            }
            else if (notaFinal < 80)
            {
                return "Bueno";
            }
            else if (notaFinal < 90)
            {
                return "Muy Bueno";
            }
            else
            {
                return "Sobresaliente";
            }
        }

        /// <summary>
        /// Muestra el resultado de las operaciones
        /// </summary>
        /// <returns>imprime de resultado de operaciones</returns>
        public void Imprimir()
        {
            double notaFinal = CalcularNotaFinal();
            string mensaje = MensajeNotaFinal(notaFinal);
            Console.WriteLine("**************************************************");
            Console.WriteLine($"Nombre del estudiante : {NombreAlumno}");
            Console.WriteLine($"Numero de cuenta : {NumeroCuenta}");
            Console.WriteLine($"Correo electrónico : {Email}");
            Console.WriteLine($"Nombre de la clase : {NombreAsignatura}");
            Console.WriteLine($"Horario : {Horario}");
            Console.WriteLine($"Nombre del Docente : {NombreDocente}");
            Console.WriteLine($"Nota final : {mensaje}");
            Console.WriteLine($"Nota final :  {mensaje}");
            Console.WriteLine("**************************************************");
        }
    }
}
