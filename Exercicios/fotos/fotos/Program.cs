namespace Fotos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlbumDeFotos fotinha = new AlbumDeFotos();
            Console.WriteLine("Situação 1");
            fotinha.TotalDeFotos = 32;
            fotinha.NumeroDeFotos = 40;
            fotinha.TotalDePaginas = 30;
            Console.WriteLine("Limite de Fotos:32,Quantia de Fotos:40");

            AlbumDeFotos fotas2 = new AlbumDeFotos();
            Console.WriteLine("Situação 2");
            fotinha.TotalDeFotos = 95;
            fotinha.NumeroDeFotos = 20;
            fotinha.TotalDePaginas = 30;
            Console.WriteLine("Limite de Fotos:20,Quantia de Fotos:95");
        }
    }
}
