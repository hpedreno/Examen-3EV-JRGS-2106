using System.Collections.Generic;
using System;

namespace Examen3EV_NS
{
    /// <summary>
    /// Esta clase nos calcula las estadísticas de un conjunto de notas 
    /// Defines the <see cref="EstablecerNota" />.
    /// </summary>
    public class EstablecerNota
    {
        /// <summary>
        /// Mensaje de error en caso de lista vacía
        /// </summary>
        public string errorListaVacia = "Error: La lista no contiene elementos";

        /// <summary>
        /// Mensaje de error en caso de notas menores a 0 o mayores a 10
        /// </summary>
        public string errorNotasIncorrectas = "Error: Las notas deben estar entre 0 y 10, ambos inclusive";

        /// <summary>
        /// Representa el contador de suspensos
        /// </summary>
        private int suspenso;

        /// <summary>
        /// Representa el contador de aprobados
        /// </summary>
        private int aprobado;

        /// <summary>
        /// Representa el contador de notables
        /// </summary>
        private int notable;

        /// <summary>
        /// Representa el contador sobresalientes
        /// </summary>
        private int sobresaliente;

        /// <summary>
        /// Representa la nota media;
        /// </summary>
        private double notaMedia;

        /// <summary>
        /// Método Getter
        /// </summary>
        /// <returns>Devuelve el contador de suspensos</returns>
        public int GetSuspenso()
        {
            return suspenso;
        }
        /// <summary>
        /// Método Getter
        /// </summary>
        /// <returns>Devuelve el contador de aprobados</returns>
        public int GetAprobado()
        {
            return aprobado;
        }
        /// <summary>
        /// Método Getter
        /// </summary>
        /// <returns>Devuelve el contador de notables</returns>
        public int GetNotable()
        {
            return notable;
        }
        /// <summary>
        /// Método Getter
        /// </summary>
        /// <returns>Devuelve el contador de sobresalientes</returns>
        public int GetSobresaliente()
        {
            return sobresaliente;
        }
        /// <summary>
        /// Método Getter
        /// </summary>
        /// <returns>Devuelve la nota media</returns>
        public double GetNotaMedia()
        {
            return notaMedia;
        }

        /// <summary>
        /// Constructor por defecto
        /// <para>Se establece una nota media de 0 por defecto</para>
        /// Initializes a new instance of the <see cref="EstablecerNota"/> class.
        /// </summary>
        public EstablecerNota()
        {
            this.suspenso = 0;
            this.aprobado = 0;
            this.notable = 0;
            this.sobresaliente = 0;

            this.notaMedia = 0.0;
        }

        /// <summary>
        /// Constructor a partir de un array.
        /// </summary>
        /// <remarks>Este constructor llama a su vez a la función "CalcularEstadistica()"</remarks>
        /// <param name="arrayNotas">The arrayNotas<see cref="List{int}"/>Array de notas</param>
        /// <return>Devuelve la nota media</return>
        public EstablecerNota(List<int> arrayNotas)
        {
            CalcularEstadistica(arrayNotas);
        }

        /// <summary>
        /// <para>Mediante el Array de Notas pasado por parámetro calculamos las estadísticas.</para>
        /// <para>Calcula la notaMedia y el número de suspensos/aprobados/notables/sobresalientes</para>
        /// </summary>
        /// <param name="arrayNotas">The arrayNotas<see cref="List{int}"/>Listado de notas</param>
        /// <exception cref="System.ArgumentOutOfRangeException">La lista no puede estar vacía.</exception>
        /// <returns>The <see cref="double"/>Devuelve la nota media</returns>
        public double CalcularEstadistica(List<int> arrayNotas)
        {
            // TODO: hay que modificar el tratamiento de errores para generar excepciones
            //

            if (arrayNotas.Count <= 0)  // Si la lista no contiene elementos, devolvemos un error
            {
                throw new ArgumentOutOfRangeException(this.errorListaVacia);
            }

            for (int i = 0; i < 10; i++)
            {
                if (arrayNotas[i] < 0 || arrayNotas[i] > 10)  // comprobamos que las notas están entre 0 y 10 (mínimo y máximo), si no, error
                {
                    throw new ArgumentOutOfRangeException(this.errorNotasIncorrectas);
                }
            }

            for (int i = 0; i < arrayNotas.Count; i++)
            {
                if (arrayNotas[i] < 5)
                {
                    this.suspenso++;        // Por debajo de 5 suspenso
                }
                else if (arrayNotas[i] >= 5 && arrayNotas[i] < 7)
                {
                    this.aprobado++;        // Nota para un aprobado: entre 5 y 7
                }
                else if (arrayNotas[i] >= 7 && arrayNotas[i] < 9)
                {
                    this.notable++;         // Nota para un notable: entre 7 y 9
                }
                else if (arrayNotas[i] >= 9) //Añado un = para que 9 también sea notable
                {
                    this.sobresaliente++;   // Nota para sobresaliente: 9 o más
                }

                this.notaMedia += arrayNotas[i];
            }

            this.notaMedia /= arrayNotas.Count;

            return this.notaMedia;
        }
    }
}
