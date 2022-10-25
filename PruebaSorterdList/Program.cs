using System.Collections;

SortedList miLista = new SortedList();

//Adicionamos
miLista.Add(754, "Honda");
miLista.Add(123, "Nissan");
miLista.Add(587, "Toyota");
miLista.Add(323, "Mazda");

//Iteremos
foreach(DictionaryEntry elemento in miLista)
    Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);

Console.WriteLine("---------------------");

//Cantidad de elementos
Console.WriteLine(miLista.Count);

//Contiene elemento
Console.WriteLine(miLista.Contains(123));
Console.WriteLine(miLista.Contains(678));

Console.WriteLine(miLista.ContainsKey(587));
Console.WriteLine(miLista.ContainsValue("Honda0"));

Console.WriteLine("---------------------");

//Obtenemos elementos por índice
Console.WriteLine(miLista.GetKey(2));
Console.WriteLine(miLista.GetByIndex(2));