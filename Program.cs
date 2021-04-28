using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            float notaUm = float.Parse(Console.ReadLine());

            Console.Write("Digite o primeiro número: ");
            float notaDois = float.Parse(Console.ReadLine());

            Console.Write("Digite o primeiro número: ");
            float notaTres = float.Parse(Console.ReadLine());

            float media = (notaUm + notaDois + notaTres) / 3;

            Console.WriteLine("notas digitadas: 1° Nota foi " + notaUm + ", 2° nota foi " + notaDois + " e a 3° nota foi " + notaTres);
            Console.WriteLine("Sua média final é " + media);

            if (media < 6){
                Console.WriteLine("Você foi reprovado!");
            }
            else{
                Console.WriteLine("Você foi aprovado!");
            }

        }
    }
}
