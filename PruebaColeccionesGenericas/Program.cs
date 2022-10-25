using PruebaColeccionesGenericas;

/*List<int> valores = new List<int>();

valores.Add(1);
valores.Add(2);
valores.Add(3);
valores.Add(4);
valores.Add(5);

foreach(var valor in valores)
    Console.WriteLine(valor);

Console.WriteLine("-----------------------");

Console.WriteLine(valores.Contains<int>(5));
Console.WriteLine(valores.Contains<int>(15));

Console.WriteLine("-----------------------");

Console.WriteLine(valores.IndexOf(4));
Console.WriteLine("-----------------------");

valores.Insert(2, 55);

foreach (var valor in valores)
    Console.WriteLine(valor);

valores.Remove(2);

valores.RemoveAt(2);

Console.WriteLine("-----------------------");
foreach (var valor in valores)
    Console.WriteLine(valor);

Console.WriteLine("-----------------------");

List<Punto> listaPuntos = new List<Punto>();
listaPuntos.Add(new Punto(5, 3));
listaPuntos.Add(new Punto(15, 4));
listaPuntos.Add(new Punto(6, 2));
listaPuntos.Add(new Punto(1, 7));

Console.WriteLine("-----------------------");

listaPuntos.Sort();

foreach (Punto punto in listaPuntos)
    Console.WriteLine(punto);*/

/********* PRUEBA QUEUE<T> *********/


/*Queue<Punto> puntos = new Queue<Punto>();

puntos.Enqueue(new Punto(3, 7));
puntos.Enqueue(new Punto(7, 9));
puntos.Enqueue(new Punto(11, 2));

foreach (Punto punto in puntos)
    Console.WriteLine("->{0}", punto);

Console.WriteLine("-----------------------");

//Hacemos Peek
Console.WriteLine("Peek {0}", puntos.Peek());

foreach (Punto punto in puntos)
    Console.WriteLine("->{0}", punto);

Console.WriteLine("-----------------------");

Console.WriteLine("Dequeue {0}", puntos.Dequeue());
Console.WriteLine("Dequeue {0}", puntos.Dequeue());

foreach (Punto punto in puntos)
    Console.WriteLine("->{0}", punto);

Console.WriteLine("-----------------------");*/

/***** Prueba Stack<T>*****/

/**/Stack<Punto> puntos = new Stack<Punto>();
puntos.Push(new Punto(3, 4));
puntos.Push(new Punto(5, 7));
puntos.Push(new Punto(9, 11));
puntos.Push(new Punto(1, 4));

foreach (Punto punto in puntos)
    Console.WriteLine("->{0}", punto);

Console.WriteLine("-----------------------");


//Hacemos un peek
Console.WriteLine("Peek {0}", puntos.Peek());
Console.WriteLine("-----------------------");
foreach (Punto punto in puntos)
    Console.WriteLine("->{0}", punto);
Console.WriteLine("-----------------------");

//Hacemos un Pop
Console.WriteLine("Pop {0}", puntos.Pop());
Console.WriteLine("-----------------------");
foreach (Punto punto in puntos)
    Console.WriteLine("->{0}", punto);/**/

/*Prueba HashSet<T>*/

/*HashSet<Punto> puntos = new HashSet<Punto>();

puntos.Add(new Punto(1, 7));
puntos.Add(new Punto(8, 11));
puntos.Add(new Punto(2, 6));

foreach (Punto punto in puntos)
    Console.WriteLine("-> {0}", punto);

Console.WriteLine("-------------------------------");

puntos.Add(new Punto(1, 15));
puntos.Add(new Punto(1, 2));

foreach (Punto punto in puntos)
    Console.WriteLine("-> {0}", punto);

Console.WriteLine("-------------------------------");
*/