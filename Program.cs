using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero: "987654321", modelo: "Modelo XV", imei: "121212121", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Discord");
iphone.ReceberLigacao();

Console.WriteLine("||||||||||||||||||||||||||||||");

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "912345678", modelo: "Modelo VI", imei: "212121212", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.ReceberLigacao();

Console.WriteLine("||||||||||||||||||||||||||||||");
Console.WriteLine("||||||TESTES FINALIZADOS||||||");