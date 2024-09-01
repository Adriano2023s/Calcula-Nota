using System;

namespace CalculaNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculaNota cn = new CalculaNota("Adriano", 90, 81, 80);
            
            double notaFinal = cn.Calculo();
            double notaMinima = 60;

            if (notaFinal >= notaMinima)
            {
                Console.WriteLine($"Você foi aprovado Sua nota foi de: {notaFinal}!");
            }
            else
            {
                double pontosFaltantes = notaMinima - notaFinal;
                Console.WriteLine($"Você foi reprovado! Faltaram pra sua aprovação: : {pontosFaltantes}");
            }
        }
    }
}
