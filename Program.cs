using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto Nokia
        Nokia nokia = new Nokia("123456789", "Nokia 1100", "001122334455667");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Whatsapp");

        Console.WriteLine();

        // Criando um objeto Iphone
        Iphone iphone = new Iphone("987654321", "Iphone 13", "998877665544332");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
