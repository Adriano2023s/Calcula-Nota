using System;

namespace CalculaNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            
            Console.WriteLine("Digite o nome do aluno \n");
          aluno.Nome = Console.ReadLine();

            Console.WriteLine($"Digite a nota do aluno: {aluno.Nome}, referente ao primeiro trimestre \n");
            aluno.Nota1 = double.Parse( Console.ReadLine() );

            Console.WriteLine($"Digite a nota do aluno: {aluno.Nome}, referente ao segundo trimestre \n");
            aluno.Nota2 = double.Parse( Console.ReadLine() );

            Console.WriteLine($"Digite a nota do aluno: {aluno.Nome}, referente ao terceiro trimestre \n");
            aluno.Nota3 = double.Parse( Console.ReadLine() );

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
