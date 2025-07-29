namespace Array_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            Console.WriteLine("ingresa 10 numeros:");
            for (int i = 0; i < numeros.Length; i++) 
            {
                Console.Write("numero " + (i + 1) + ": ");
                numeros[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("\nnumeros pares ingresados:");
            for (int i = 0; i < numeros.Length; i++) 
            {
                if (numeros[i] % 2 == 0)
                    Console.WriteLine(numeros[i]);
            }
        }
    }
}
