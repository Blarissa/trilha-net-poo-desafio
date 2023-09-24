using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");

var nokia = new Nokia("123456", "11111111", "Modelo 1", 128);
nokia.InstalarAplicativo("Whatsapp");
nokia.Ligar();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");

var iphone = new Iphone("654321", "22222222", "Modelo 2", 64);
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();