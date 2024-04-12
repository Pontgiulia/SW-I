namespace ExercicioSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Salario p = new Salario();
            p.Nome = "Giu";
            p.Sal = 20000;
            p.HED = 0;
            p.HEN = 24;
            p.ND = 0;
            p.Fal = 32;
            p.DE = 5;
            p.REF = 2;
            p.Val = 0;
            Console.WriteLine(p.FolhaDePagamento());
        }
    }
}