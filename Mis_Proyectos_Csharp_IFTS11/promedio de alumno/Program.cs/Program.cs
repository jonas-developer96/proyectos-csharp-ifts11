namespace Array_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] notas = { 3, 5, 6, 8, 10 };
            int suma = 0;
            foreach (int calificacion in notas)
            {
                suma += calificacion;
            }
            double promedio = (double)suma / notas.Length;
            Console.WriteLine("Promedio es: " + promedio);
            if (promedio >= 6)
            {
                Console.WriteLine("El alumno aprobó");
            }
            else
            {
                Console.WriteLine("El alumno no aprobó");
            }
        }
    }
}
