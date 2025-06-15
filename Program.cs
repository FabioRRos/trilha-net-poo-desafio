using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone iphone = new Iphone("14997724891", "Iphone 16", "1544254", 16);

iphone.InstalarAplicativo("Whatsapp");
iphone.Ligar();
iphone.ReceberLigacao();

Smartphone nokia = new Nokia("14997724891", "Nokia Lumia", "1544254", 16);


nokia.InstalarAplicativo("Telegram...");
nokia.Ligar();
nokia.ReceberLigacao();


