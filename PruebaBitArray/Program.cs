using System.Collections;

BitArray miArreglo = new BitArray(new byte[] { 1, 2, 4, 8, 16 });

Console.WriteLine(miArreglo.Count);

MuestraArreglo(miArreglo);

Console.WriteLine("----------");

//Obtener un bit en particular
Console.WriteLine(miArreglo.Get(3));

//Ponemos un bit en particular
miArreglo.Set(3, true);
MuestraArreglo(miArreglo);
Console.WriteLine(miArreglo.Get(3));

Console.WriteLine("----------");

//Clonamos el BitArray
BitArray arreglo2 = (BitArray)miArreglo.Clone();
MuestraArreglo(arreglo2);

//Invertimos el arreglo, NOT
arreglo2 = arreglo2.Not();
MuestraArreglo(arreglo2, "areglo2");

Console.WriteLine("----------");

//Creamos otro
BitArray arreglo3 = new BitArray(new byte[] { 5, 7, 9, 13, 15 });
MuestraArreglo(arreglo3, "arreglo3");
Console.WriteLine("----------");

//Hacemos OR entre arreglos
arreglo3.Or(miArreglo);
MuestraArreglo(miArreglo, "miArreglo");
MuestraArreglo(arreglo3, "arreglo3");
Console.WriteLine("==========");

//Hacemos AND entre arreglos
MuestraArreglo(miArreglo, "miArreglo");
MuestraArreglo(arreglo3, "arreglo3");
Console.WriteLine("==========");

arreglo3.And(miArreglo);
MuestraArreglo(arreglo3, "arreglo 3");
Console.WriteLine("==========");

//Hacemos XOR entre arreglos
arreglo3 = new BitArray(new byte[] { 1, 7, 9, 13, 21 });
MuestraArreglo(miArreglo, "miArreglo");
MuestraArreglo(arreglo3, "arreglo3");
Console.WriteLine("==========");

arreglo3.Xor(miArreglo);
MuestraArreglo(arreglo3, "arreglo3");
Console.WriteLine("==========");



void MuestraArreglo(BitArray miArreglo, string pNombre = " ")
{
    int c = 0;
    Console.Write("{0}\t", pNombre);

    foreach(bool b in miArreglo)
    {
        c++;
        if (b)
            Console.Write("1");
        else
            Console.Write("0");
        if(c % 8 == 0)
            Console.Write(",");
    }
    Console.WriteLine();
}
