namespace Array_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] consultorios = new int[5];
            Console.WriteLine("ingrese 5 consultorios:");
            for (int i = 0; i < consultorios.Length; i++) 

            {
             Console.Write("consultorio " + (i + 1) + ": ");
            consultorios[i] = int.Parse(Console.ReadLine());
        }
            int mayor = consultorios[0];
            int menor = consultorios[0];

            for (int i = 1; i < consultorios.Length; i++)
            {
                if (consultorios[i] > mayor)
                    mayor = consultorios[i];

                if (consultorios[i] < menor)
                    menor = consultorios[i];
            }
            Console.WriteLine("el numero mas alto es: " + mayor);
            Console.WriteLine("el numero mas bajo es: " + menor);
        }
    }
}
