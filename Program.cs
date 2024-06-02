using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "96587-3654", modelo: "Nokia Tijolão", imei: "0123456789", memoria: 4);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Google Docs");

Console.WriteLine("-----------------------------------------");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "36587-4861", modelo: "Iphone 15", imei: "9876543210", memoria: 256);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Microsoft Office");

Console.WriteLine("-----------------------------------------");