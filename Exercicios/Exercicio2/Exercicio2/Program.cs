namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Giu";
            p.DataNascimento = new DateTime(2007, 8, 25);
            p.Altura = 1.60f;

            p.ImprimirDados();

            int idade = p.CalcularIdade();

            Console.WriteLine("Idade: " + idade);

            Console.ReadKey();
        }

    }
}