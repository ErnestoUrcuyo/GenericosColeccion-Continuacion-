using System.Collections;

Stack miStack = new Stack(); // LIFO

// Agregamos elementos
miStack.Push("Manzana");
miStack.Push("Pera");
miStack.Push("Ciruela");
miStack.Push("Mango");

// Iteramos el Stack
foreach (string fruta in miStack)
    Console.WriteLine("->{0}", fruta);

Console.WriteLine("-----");

// Hacemos Pop
Console.WriteLine(miStack.Pop());

foreach (string fruta in miStack)
    Console.WriteLine("->{0}", fruta);

Console.WriteLine("-----");

// Hacemos Peek
Console.WriteLine(miStack.Peek());

foreach (string fruta in miStack)
    Console.WriteLine("->{0}", fruta);

Console.WriteLine("-----");

// Cantidad de elementos
Console.WriteLine(miStack.Count);

Console.WriteLine("-----");