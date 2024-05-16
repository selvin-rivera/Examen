

namespace Examen
{
    public interface IAsignatura
    {
        // <summary>
        /// Sumará las 3 notas parciales
        /// </summary>
        /// <returns>la nota final</returns>
        public double CalcularNotaFinal();

        // <summary>
        /// Sumará las 3 notas parciales a partir de los parámetros
        /// </summary>
        /// <returns>la nota final</returns>
        public double CalcularNotaFinal(double N1, double N2, double N3);

        // <summary>
        /// Mostrará un mensaje basado en de la nota final
        /// </summary>
        /// <returns>el mensaje de acuerdo a la nota final</returns>
        public string MensajeNotaFinal(double notaFinal);

        // <summary>
        /// Mostrará en pantalla los datos del alumno, datos de la asignatura y la nota final 
        /// </summary>
        /// <returns>datos del alumno, datos de la asgnatura y la nota finall</returns>
        public void Imprimir();
    }
}
