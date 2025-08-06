namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }

        // Construtor recebe os três parâmetros e seta nas propriedades
        public Smartphone(string numero, string modelo, string imei)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato que será implementado nas classes filhas
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
