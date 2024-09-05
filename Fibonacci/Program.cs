namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor abaixo de 100: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            List<int> list = new List<int>();

            int x = 1;
            int soma = 0;
            int y = 0;
            int z = 0;
           

            Console.WriteLine(y);
            Console.WriteLine(x);

            for (int i = 0; i < 15; i++)
            {


                soma = x + y;
                y = x;
                x = soma;


                Console.WriteLine(soma);

                list.Add(soma);

            }
            Console.WriteLine();

            foreach (int number in list) {

                if (number == n) { Console.WriteLine(n + " Pertence ao fibonacci!"); }
                

            }

            Console.WriteLine();

        
            Console.ReadKey();
        }
    }
}

