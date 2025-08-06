namespace DesafioPOO.Models
{
    // Herdando da classe abstrata Smartphone
    public class Nokia : Smartphone
    {
        // Construtor que chama o construtor da classe base
        public Nokia(string numero, string modelo, string imei) 
            : base(numero, modelo, imei) { }

        // Implementação do método abstrato
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na loja do Nokia.");
        }
    }
}
