using System;

namespace atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do aluno");
            string nome = Console.ReadLine();
            string[] nomes = new string[10];
            int[] nota1 = new int[10];
            int[] nota2 = new int[10];
            int[] nota3 = new int[10];
            int[] nota4 = new int[10];
            
            Console.WriteLine("Digite a primeira nota");
            int valor1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a segunda nota");
            int valor2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a terceira nota");
            int valor3 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a quarta nota");
            int valor4 = int.Parse(Console.ReadLine());

            float mediaCalculadora = Media(valor1, valor2, valor3, valor4);

            float Media(int v1, int v2, int v3, int v4){
                float media = (v1+v2+v3+v4)/4;
                Console.WriteLine($"A média é {media}");
                return media;
            }
           
            
        }
    }
}
