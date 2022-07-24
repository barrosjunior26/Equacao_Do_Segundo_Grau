namespace equacao
{
    class EquacaoSegundoGrau
    {
        public static void Main(String[] args)
        {
            //Equação do segundo grau

            //Declaração de variáveis
            int opcao = 0;

            do
            {
                //Solicitando ao usuário os valores de A, B e C
                Console.Write("Informe o valor de A: ");
                double A = double.Parse(Console.ReadLine());
                Console.Write("Informe o valor de B: ");
                double B = double.Parse(Console.ReadLine());
                Console.Write("Informe o valor de C: ");
                double C = double.Parse(Console.ReadLine());

                //Encontrando o valor de delta usando a formula de Bhaskara Δ = b 2 – 4ac
                double delta = Math.Pow(B, 2) - 4 * A * C;

                //Imprimindo o valor de delta
                Console.WriteLine("O valor de delta é = " + delta);

                //Encontranto as raízes de X1 e X2 usando a seguinte formula de Bhaskara
                double X1 = (-B + Math.Sqrt(delta) / 2 * A);
                double X2 = (-B - Math.Sqrt(delta) / 2 * A);

                //Mostrando o resultado das raízes de delta X1 e X2
                //E se delta der um valor positivo acima de 0, X1 e X2 terão valores diferentes;
                if (delta > 0)
                {
                    Console.WriteLine("Existem duas raízes reais diferentes, X1 = " + X1 + " e X2 = " + X2);
                }
                ///Se o meu delta der 0, X1 e X2 terão o mesmo valor
                else if (delta == 0)
                {
                    Console.WriteLine("Existem duas raízes reais iguais, X1 = " + X1 + " e X2 = " + X2);
                }
                else
                {
                    Console.WriteLine("Não existem raízes reais!");
                }
                Console.Write("Digite 1 para nova operação ou 0 para sair: ");
                opcao = int.Parse(Console.ReadLine());
            } while (opcao != 0);
        }
    }
}