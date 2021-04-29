using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro nota: ");
            float notaUm = float.Parse(Console.ReadLine());

            Console.Write("Digite o segunda nota: ");
            float notaDois = float.Parse(Console.ReadLine());

            Console.Write("Digite o terceira nota: ");
            float notaTres = float.Parse(Console.ReadLine());

            float media = (notaUm + notaDois + notaTres) / 3;

            Console.WriteLine("notas digitadas: sua 1° Nota foi " + notaUm + ", sua 2° nota foi " + notaDois + " e a sua 3° nota foi " + notaTres);
            Console.WriteLine("Sua média final é " + Math.Round(media, 1).ToString());

            if (media <= 5){
                Console.WriteLine("Você foi reprovado!");
            }
            else{
                Console.WriteLine("Você foi aprovado!");
            }

        }
    }
}
