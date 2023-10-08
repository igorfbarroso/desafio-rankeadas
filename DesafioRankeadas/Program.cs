internal class Program
{
    private static void Main(string[] args)
    {
        //Inserindo valores nas variáveis
        Console.WriteLine("Digite a quantidade de vitórias: ");
        int vitorias = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de derrotas: ");
        int derrotas = Convert.ToInt32(Console.ReadLine());

        string resultado = CalcularRank(vitorias, derrotas);
        Console.WriteLine(resultado);

        static string CalcularRank(int vitorias, int derrotas)
        {
            int saldoVitorias = vitorias - derrotas;
            string nivel;

            if (saldoVitorias < 10)
            {
                nivel = "Ferro";
            }
            else if (saldoVitorias >= 11 && saldoVitorias <= 20)
            {
                nivel = "Bronze";
            }
            else if (saldoVitorias >= 21 && saldoVitorias <= 50)
            {
                nivel = "Prata";
            }
            else if (saldoVitorias >= 51 && saldoVitorias <= 80)
            {
                nivel = "Ouro";
            }

            else if (saldoVitorias >= 81 && saldoVitorias <= 90)
            {
                nivel = "Diamante";
            }
            else if (saldoVitorias >= 91 && saldoVitorias <= 100)
            {
                nivel = "Lendário";
            }
            else if (saldoVitorias >= 101)
            {
                nivel = "Imortal";
            }
            else
            {
                nivel = "Indefinido";
            }
            string resultado = $"O herói tem de saldo de {saldoVitorias} está no nível de {nivel}";
            return resultado;
        }
    }
}