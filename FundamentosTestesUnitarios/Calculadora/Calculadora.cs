namespace Calculadora
{
    public class Calculadora
    {
        public decimal Somar(decimal numeroUm, decimal numeroDois)
        {
            return numeroUm + numeroDois;
        }

        public decimal Subtrair(decimal numeroUm, decimal numeroDois)
        {
            return numeroUm - numeroDois;
        }

        public decimal Multiplicar(decimal numeroUm, decimal numeroDois)
        {
            return numeroUm * numeroDois;
        }

        public decimal Dividir(decimal numeroUm, decimal numeroDois)
        {
            if (numeroDois == 0.00m)
            {
                throw new DivideByZeroException("Não é possível realizar divizão por zero");
            }

            return numeroUm / numeroDois;
        }
    }
}
