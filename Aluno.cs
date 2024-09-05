namespace CalculaNota
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
       public double Nota3 { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double P3 { get; set; }

        public Aluno(string nome, double nota1, double nota2, double nota3)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public Aluno()
        {

        }

        public double Calculo()
        {
            return CalcularMediaPonderada();
            }

        public double CalcularMediaPonderada()  
        {
            double somaPonderada = (Nota1 * P1) + (Nota2 * P2) + (Nota3 * P3);
            double somaPesos = P1 + P2 + P3;
            double mediaPonderada = somaPonderada / somaPesos;
            return mediaPonderada;
        }


    }
}
