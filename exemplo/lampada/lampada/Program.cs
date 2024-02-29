namespace lampada
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            // instancia de um objeto
            Lampada lampada1 = new Lampada();

            //chamando o metodo para ligar a lampada1
            lampada1.Ligar();

            //chamando o metodo para verificar se a lampada1 esta ligada
            Console.WriteLine("A lampada esta ligada? " + lampada1.estaLigada());

            lampada1.Cores();

            Console.WriteLine("Qual a cor da lampada? " + lampada1.qualCor());

            lampada1.Pot();

            Console.WriteLine("Qual a potencia da lampada? " + lampada1.estaPotencia());

            



        }
    }
}
