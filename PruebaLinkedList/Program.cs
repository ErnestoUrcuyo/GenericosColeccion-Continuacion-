LinkedList<int> numeros = new LinkedList<int> ();

foreach (int numero in new int[] { 10, 8, 6, 4, 3, 0 })
    numeros.AddFirst (numero); /* AddLast hace lo contrario, agregandolos al final, resultando en: 10, 8, 6, 4, 2, 0 */

foreach(int numero in numeros)
    Console.WriteLine(numero);

Console.WriteLine("-----------------------");
numeros.Remove(6);
foreach (int numero in numeros)
    Console.WriteLine(numero);
Console.WriteLine("-----------------------");
LinkedListNode<int> nodoImportante = new LinkedListNode<int> (15);
numeros.AddFirst(nodoImportante);

for (LinkedListNode<int>nodo = numeros.First; nodo != null; nodo = nodo.Next)
    Console.WriteLine(nodo.Value);

string[] colores = { "negro", "amarillo", "verde", "azul", "violeta", "plata" };
string[] colores2 = { "oro", "blanco", "café", "azul", "gris" };

LinkedList<string> lista1 = new LinkedList<string>();

foreach (string color in colores)
    lista1.AddLast (color);
Console.WriteLine("-----------------------");

LinkedList<string> lista2 = new LinkedList<string>(colores2);

Concatenar(lista1, lista2);
ImprimirLista(lista1);
Console.WriteLine("-----------------------");

Console.WriteLine("\nConvirtiendo las cadenas en lista1 a mayúsculas\n");
CadenasAMayusculas(lista1);
ImprimirLista(lista1);
Console.WriteLine("-----------------------");

Console.WriteLine("\nEliminar las cadenas entre NEGRO y CAFÉ\n");
EliminarElementosEntre(lista1, "NEGRO", "CAFÉ");
Console.WriteLine("-----------------------");

ImprimirLista(lista1);
Console.WriteLine("-----------------------");
ImprimirListaInversa(lista1);

void ImprimirListaInversa<E>(LinkedList<E> lista)
{
    Console.WriteLine("Lista invertida: ");

    //itera a través de la lista, utilizando los nodos
    LinkedListNode<E> nodoActual = lista.Last;

    while(nodoActual != null)
    {
        Console.Write("{0} ", nodoActual.Value);
        nodoActual = nodoActual.Next;
    }
    Console.WriteLine();
}

void EliminarElementosEntre<E>(LinkedList<E> lista, E elementoInicial, E elementoFinal)
{
    LinkedListNode<E> nodoActual = lista.Find(elementoInicial);
    LinkedListNode<E> nodoFinal = lista.Find(elementoFinal);

    while ((nodoActual.Next != null) && nodoActual.Next != nodoFinal)
    {
        lista.Remove(nodoActual.Next);
    }
}

void CadenasAMayusculas(LinkedList<string> lista1)
{
    LinkedListNode<string> nodoActual = lista1.First;

    while(nodoActual != null)
    {
        string color = nodoActual.Value;
        nodoActual.Value = color.ToUpper();

        nodoActual = nodoActual.Next;
    }
}

ImprimirLista(lista1);

void Concatenar<E>(LinkedList<E> lista1, LinkedList<E> lista2)
{
    foreach(E valor in lista2)
        lista1.AddLast (valor);
}

void ImprimirLista<E>(LinkedList<E> lista)
{
    Console.WriteLine("lista enlazada: ");

    foreach (E valor in lista)
        Console.Write("{0} ", valor);
    Console.WriteLine();
}