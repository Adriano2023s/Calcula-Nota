namespace CalculaNota
{
    internal class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;
        public double P1 = 30;
        public double P2 = 35;
        public double P3 = 35;

        public Aluno(string nome, double n1, double n2, double n3)
        {
            Nome = nome;
            N1 = n1;
            N2 = n2;
            N3 = n3;
            }

        public double Calculo()
        {
            return CalcularMediaPonderada();
            }

        public double CalcularMediaPonderada()
        {
            double somaPonderada = (N1 * P1) + (N2 * P2) + (N3 * P3);
            double somaPesos = P1 + P2 + P3;
            double mediaPonderada = somaPonderada / somaPesos;
            return mediaPonderada;
        }


    }
}
