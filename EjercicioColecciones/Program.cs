//Desarrolle una aplicación de consola
//que cuente el número de ocurrencias de cada palabra de una cadena
//y las almacene en una Hashtable

using System.Collections;
using System.Text.RegularExpressions;
using System;


Hashtable ocurrencias = RecolectarPalabra();

MuestraHashtable(ocurrencias);


void MuestraHashtable(Hashtable tabla)
{
    Console.WriteLine("\nEl objeto Hashtable contiene:\n{0, -12}{1, -12}", 
        "Clave:", "Valor:");

    foreach (object clave in tabla.Keys)
        Console.WriteLine("{0, -12}{1, -12}", clave, tabla[clave]);

    Console.WriteLine("\ntamaño: {0}", tabla.Count);
}
Hashtable RecolectarPalabra()
{
    Hashtable tabla = new Hashtable();

    Console.WriteLine("Escriba una cadena");
    string? entrada = Console.ReadLine();
    
    string[] palabras = Regex.Split(entrada, @"\s+");

    foreach(string palabra in palabras)
    {
        string clavePalabra = palabra.ToLower();

        if (tabla.ContainsKey(clavePalabra))
            tabla[clavePalabra] = (int)tabla[clavePalabra] + 1;
        else
            tabla.Add(clavePalabra, 1);
    }
    return tabla;
}




