namespace MembrosEstaticos
{
    class ConversorDeMoeda
    {
        public static double cotacao = 0.0;
        public static double valorDolar = 0.0;

        public static double calcularValorReais()
        {
            return cotacao * (valorDolar+(valorDolar*0.06));
        }
    }
}
