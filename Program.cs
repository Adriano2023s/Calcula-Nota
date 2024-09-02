using System;

namespace CalculaNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno("Adriano", 33, 19, 10);
            
            double notaFinal = aluno.Calculo();
            double notaMinima = 60;

            if (notaFinal >= notaMinima)
            {
                Console.WriteLine($"O aluno: {aluno.Nome}, obteve a nota: {notaFinal}, e foi aprovado!");
            }
            else
            {
                double pontosFaltantes = notaMinima - notaFinal;
                Console.WriteLine($"O aluno: {aluno.Nome}, foi reprovado! e faltaram para a sua aprovação: {pontosFaltantes}, tente novamente!");
            }
        }
    }
}
