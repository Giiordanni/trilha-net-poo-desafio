namespace Celular.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {

        public Nokia(string numero, string modelo, string imei, string memoria) : base (numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(String nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia...");
        }
    }
}