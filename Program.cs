using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

class Program
{
    static void Main()
    {
        Nokia nokiaPhone = new Nokia("123456", "Nokia Model", "IMEI123", 64);

        // Chamando métodos herdados da classe Smartphone nokia
        nokiaPhone.Ligar();
        nokiaPhone.ReceberLigacao();

        // Chamando o método sobrescrito da classe Nokia
        nokiaPhone.InstalarAplicativo("MeuApp");

        // Você também pode acessar as propriedades herdados da classe Smartphone
        Console.WriteLine($"Número: {nokiaPhone.Numero}, Modelo: {nokiaPhone.Modelo}, Memória: {nokiaPhone.Memoria}GB");

        Iphone ioshone = new Iphone("654321", "Iphone Model", "IMEI456", 128);

        // Chamando métodos herdados da classe Smartphone nokia
        ioshone.Ligar();
        ioshone.ReceberLigacao();

        // Chamando o método sobrescrito da classe Nokia
        ioshone.InstalarAplicativo("MeuAppIphone");

        // Você também pode acessar as propriedades herdados da classe Smartphone
        Console.WriteLine($"Número: {ioshone.Numero}, Modelo: {ioshone.Modelo}, Memória: {ioshone.Memoria}GB");
    }
}