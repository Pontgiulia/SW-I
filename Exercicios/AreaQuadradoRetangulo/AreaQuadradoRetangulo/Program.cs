namespace AreaQuadradoRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula a área quadrado/retângulo");

            Area area = new Area();

            Console.WriteLine(area.Calcular());

            Console.WriteLine(area.Dados());
        }
    }
}