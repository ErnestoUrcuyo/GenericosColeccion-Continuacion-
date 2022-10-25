using System.Collections;

Hashtable openWith = new Hashtable();

//Adicionamos elementos
openWith.Add("txt", "notepad.exe");
openWith.Add("bmp", "paint.exe");
openWith.Add("dib", "paint.exe");
openWith.Add("rtf", "wordpad.exe");

//Mostrar los elementos
foreach (DictionaryEntry elemento in openWith)
    Console.WriteLine("{0}, {1}", elemento.Key, elemento.Value);

//Intentamos colocar un elemento con llave repetida
// openWith.Add("txt", "winword.exe");

Console.WriteLine("---------------------");

//Cantidad de elementos
Console.WriteLine(openWith.Count);

Console.WriteLine("---------------------");

//Obtenemos el elemento de determinada llave
Console.WriteLine(openWith["txt"]);
Console.WriteLine(openWith["xls"]);

Console.WriteLine("---------------------");

//Colocamos el elemento en una llave
openWith["xls"] = "excel.exe";
openWith["txt"] = "winword.exe";
foreach (DictionaryEntry elemento in openWith)
    Console.WriteLine("{0}, {1}", elemento.Key, elemento.Value);

Console.WriteLine("---------------------");

//Verificamos si hay un elemento
Console.WriteLine(openWith.Contains("pdf"));
Console.WriteLine(openWith.Contains("txt"));

Console.WriteLine("---------------------");

//Eliminamos un elemento
openWith.Remove("xls");
foreach (DictionaryEntry elemento in openWith)
    Console.WriteLine("{0}, {1}", elemento.Key, elemento.Value);

Console.WriteLine("---------------------");

Console.WriteLine("llaves:","\n");
foreach (string llave in openWith.Keys)
    Console.WriteLine(llave);
Console.WriteLine("---------------------");

Console.WriteLine("valores:","\n");
foreach (string valor in openWith.Values)
    Console.WriteLine(valor);
Console.WriteLine("---------------------");
