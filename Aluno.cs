namespace CalculaNota
{
    internal class Aluno
    {
        private string _Nome;
        private double _Nota1;
        private double _Nota2;
        private double _Nota3;
        public double P1;
        public double P2;
        public double P3;

        public string Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                _Nome = value;
            }
}

        public double Nota1
        {
            get
            {
                return _Nota1;
            }
            set
            {
                _Nota1 = value;
            }
        }

        public double Nota2
        {
            get
            {
                return _Nota2;
            }
            set
            {
                _Nota2 = value;
            }
        }

        public double Nota3
        {
            get
            {
                return _Nota3;
            }
            set
            {
                _Nota3 = value;
            }
        }

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
