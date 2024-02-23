namespace lampada
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            // instancia de um objeto
            Lampada lampada1 = new Lampada();
            Lampada lampada2 = new Lampada();

            //acessando um atributo publico do objeto
            lampada1.Ligada = true;
            lampada1.Potencia = 150;
            lampada1.Cor = "azul";

            lampada2.Ligada = false;
            lampada2.Potencia = 100;
            lampada2.Cor = "roxo";

            //visualizando os valores de atributos
            Console.WriteLine(" Essa é a lâmpada 1");
            Console.WriteLine(" A lâmpada está Ligada? " + lampada1.Ligada);
            Console.WriteLine(" Qual a potência da lâmpada? " + lampada1.Potencia);
            Console.WriteLine(" Qual a cor da lâmpada? " + lampada1.Cor);
            Console.WriteLine("*******************************");
            Console.WriteLine(" Essa é a lâmpada 2");
            Console.WriteLine(" A lâmpada está Ligada? " + lampada2.Ligada);
            Console.WriteLine(" Qual a potência da lâmpada? " + lampada2.Potencia);
            Console.WriteLine(" Qual a cor da lâmpada? " + lampada2.Cor);



        }
    }
}