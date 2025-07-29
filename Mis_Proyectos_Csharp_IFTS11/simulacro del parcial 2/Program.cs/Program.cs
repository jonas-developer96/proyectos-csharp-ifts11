namespace simulacro_parcial_2_tecnicas
{
    internal class Program
    {
        static void Main(string[] args)
        /*{
            Stack<string> tpracticos = new Stack<string>();

            tpracticos.Push("leer un capitulo");
            tpracticos.Push("preparar cafe");
            tpracticos.Push("ordenar el cuarto");



            Console.WriteLine("leer un capitulo (Pop):" + tpracticos.Pop());

            Console.WriteLine("prepar cafe (Peek):" + tpracticos.Peek());
        }*/



        {
            Stack<string> notas = new Stack<string>();
            notas.Push("el cielo es el limite");
            notas.Push("el mar azul");
            notas.Push("la primavera tardia");
            notas.Push("la amazonas del paraiso");

            while (notas.Count > 0)
            {
                Console.WriteLine(notas.Pop());
            }
            if (notas.Count == 0)
            {
                Console.WriteLine("la pila esta vacia");
            }





            /* -Y como cierre, mostrar si la pila quedó vacía*/





























        }
    }
}
