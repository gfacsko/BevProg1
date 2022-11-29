﻿/*
 * Bevezetés a programozásba példaprogramok C#-ban
 * MicroSoft Visual Studio fejlesztőkörnyezettel
 * 
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 * Milton Friedman University, Budapest, Hungary, 2022
 * */

/*
int a = 2;
int b = 3;

string str = (a < b) ? "b" : "a";

Console.WriteLine(str);

//   valtozo = (logikai operátor) ? 

// Ennek a rövidítése:

string str = "";

if (a < b)
    str = "b";
else
    str = "a";

// -------

int i = 0;

i = i + 1;

i += 1;

i++;

++i;

*/

/*
// Példák listákra: számok
List<Int16> list = new List<Int16>();
list.Add(42);
list.Add(137);
list.Add(255);

// Példák listákra: szöveg
List<string> authors = new List<string>(5);

authors.Add("Facskó Gábor");
authors.Add("Lőrincz L. László");
authors.Add("Nemere István");
authors.Add("Zsoldos Péter");
authors.Add("Arthur C. Clarke");
authors.Add("Isaac Asimov");

// Initializálás tömbbel
string[] animals = { "Cow", "Camel", "Elephant" };
List<string> animalsList = new List<string>(animals);
*/

// Listák kiírása - barbár megoldás (new így csinálják) ------------
/*
// Az ArrayListet szöveggé alakítom
string str = string.Join(", ", list.ToArray());

// Kiíratom a szöveget
Console.WriteLine(str);*/

// Listák kiírása -----------------------------------

/*
foreach (int a in list)
{
    Console.WriteLine(a);
}
*/
/*
// Eredeti lista
Console.WriteLine("Az eredeti lista:");
foreach (string a in authors)
    Console.WriteLine(a);
*/
/*Console.WriteLine("Count: " + authors.Count);
Console.WriteLine("Capacity: " + authors.Capacity);*/

// Beszúrok egy elemet a 3 (negyedik) helyre
//authors.Insert(3, "Bill Gates");

/*string[] newAuthors = { "New Author1", "New Author2", "New Author3" };
authors.InsertRange(2, newAuthors);*/

// Egy elem törlése
//authors.Remove("New Author1");

// Egy adott helyen lévő elem törlése
//authors.RemoveAt(2);

// Egy adott helyről több elem törlése
//authors.RemoveRange(2, 2);
// Az egész lista törlése
//authors.Clear();

/*
// Keresés a listában
int idx = authors.IndexOf("Nemere István");
if (idx >= 0)
    Console.WriteLine($"A listában az elem az {idx}. helyen található");
else
    Console.WriteLine("Az elem nincs a listában");

// Keresés, de hibakezelés nélkül
Console.WriteLine(authors.IndexOf("Nemere István", 2));
*/

/*
// Rendezi az elemeket
authors.Sort();

// Megfordítja az elemeket
authors.Reverse();*/
/*
// Létrehozok egy második listát
List<string> secondAuthors = new List<string>();
secondAuthors.Add("Kovacs Laszlo");
secondAuthors.Add("Tuk Peregin");
secondAuthors.Add("Gandalf, the Grey");

// Kiírom a második listát
Console.WriteLine("\nA második lista:");
foreach (string a in secondAuthors)
    Console.WriteLine(a);

// Hozzáadom a második listát az első litához
authors.AddRange(secondAuthors);

// Az új lista
Console.WriteLine("\nA módosított lista:");
foreach (string a in authors)
    Console.WriteLine(a);

*/


// Példa ArrayListre
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Diagnostics;

ArrayList al = new ArrayList();

// adding elements using ArrayList.Add() method
al.Add(42);
al.Add(137);
al.Add(25.5);
al.Add("Facskó Gábor");
al.Add("Lőrincz L. László");
al.Add("Nemere István");
al.Add("Zsoldos Péter");
al.Add("Arthur C. Clarke");
al.Add("Isaac Asimov");
al.Add(null);

// Az ArrayList kiíratása
Console.WriteLine("Az eredeti lista kiírása:");
foreach (var val in al)
    Console.WriteLine(val);

// Variációk elemek eltávolítására
//al.Remove(25.5);

//al.RemoveAt(3);

//al.RemoveRange(1,2);

// Eltávolítok mindent
//al.Clear();

// Rendezés
//al.Sort();

// Megfordítás
al.Reverse();
// A módosított ArrayList kiíratása
Console.WriteLine("\nAz módosított lista kiírása:");
foreach (var val in al)
    Console.WriteLine(val);

Console.WriteLine("Count: " + al.Count);
Console.WriteLine("Capacity: " + al.Capacity);