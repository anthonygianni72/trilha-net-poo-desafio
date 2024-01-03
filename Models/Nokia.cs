using System;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string Imei, int memoria) : base(numero, modelo, Imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            
            Console.WriteLine($"Instalando o aplicativo {nomeApp} em um Nokia.");
        
        }
    }
}