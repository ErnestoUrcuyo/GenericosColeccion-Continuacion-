using System.Collections;

Queue miQ = new Queue(); //FIFO

//Adicionamos objetos
miQ.Enqueue("Manzana");
miQ.Enqueue("Fresa");
miQ.Enqueue("Pera");

//Iteramos
foreach (string fruta in miQ)
    Console.WriteLine("->{0}", fruta);

Console.WriteLine("---------------------");

//Obtenemos objetos
Console.WriteLine("Degueue {0}", miQ.Dequeue());
Console.WriteLine("Dequeue {0}", miQ.Dequeue());

foreach (string fruta in miQ)
    Console.WriteLine("Después de Dequeue->{0}", fruta);

Console.WriteLine("---------------------");

//Adicionamos objetos
miQ.Enqueue("Limón");
miQ.Enqueue("Mango");
miQ.Enqueue("Ciruela");

//Observamos el objeto
Console.WriteLine("Peek {0}", miQ.Peek());

foreach (string fruta in miQ)
    Console.WriteLine("Después de Peek->{0}", fruta);

Console.WriteLine("---------------------");

//Conteo de objetos
Console.WriteLine(miQ.Count);
Console.WriteLine("---------------------");

//Verifiquemos si existe el elemento
Console.WriteLine(miQ.Contains("Mango"));
Console.WriteLine(miQ.Contains("Manzana"));
