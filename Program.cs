using Celular.Models;

Console.WriteLine("Cadastrando um Nokia!");
Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789", "16GB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");


Console.WriteLine("\nCadastrando um Iphone!");
Iphone iphone = new Iphone("987654321", "Iphone 12", "987654321", "128GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");