using System;

namespace CalificacionesDeEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos estudiantes deseas calificar?");
            int numeroDeEstudiantes = int.Parse(Console.ReadLine());

            Estudiante[] estudiantes = new Estudiante[numeroDeEstudiantes];

            for (int i = 0; i < numeroDeEstudiantes; i++)
            {
                Console.WriteLine("Ingrese el nombre del estudiante:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la nota 1:");
                double nota1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la nota 2:");
                double nota2 = double.Parse(Console.ReadLine());

                estudiantes[i] = new Estudiante
                {
                    Nombre = nombre,
                    Nota1 = nota1,
                    Nota2 = nota2
                };
            }

            Console.WriteLine("Nombre\tNota 1\tNota 2\tPromedio");
            Console.WriteLine("-------------------------------------");
            foreach (Estudiante estudiante in estudiantes)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", estudiante.Nombre, estudiante.Nota1, estudiante.Nota2, (estudiante.Nota1 + estudiante.Nota2) / 2);
            }
            Console.ReadLine();
        }
    }

    class Estudiante
    {
        public string Nombre { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
    }
}