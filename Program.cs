using DesafioPOO.Models;

// NOKIA
Console.WriteLine("NOKIA");
Smartphone nokia = new Nokia(numero: "992235332", modelo: "modelo X", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

// IPHONE   
Console.WriteLine("IPHONE");
Smartphone iphone = new Iphone("983410042", "modelo 15", "222222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");