/*
 * Bevezetés a programozásba példaprogramok C#-ban
 * MicroSoft Visual Studio fejlesztőkörnyezettel
 * 
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 * Milton Friedman University, Budapest, Hungary, 2022
 * */

/*
// A lista elemeinek a szám (önkényes)
const int N = 50;

// Lista deklarációk
List<int> list = new List<int>();

// Feltöltöm a listát négyzetszámokkal
for (int i = 1; i <= N; i++)
{
    // A listához hozzáadok egy elemet 
    list.Add((int)Math.Pow((double)i,2));
}

list.RemoveRange(1, 5);

list.Remove(2500);

// A listát szöveggé alakítom
string str = String.Join(", ", list);

// Kiíratom a szöveget
Console.WriteLine(str);
*/

/*
// List with capacity = 5
List<string> authors = new List<string>(5);
string[] animals = { "Cow", "Camel", "Elephant" };
List<string> animalsList = new List<string>(animals);*/

// ArraList típusra példák

// Betölti az ArrayList deklarációit
using System.Collections;
using System.Collections.Generic;
using System.Linq;

ArrayList arlist = new ArrayList();
// or 
//var arlist = new ArrayList(); // recommended 

// adding elements using ArrayList.Add() method
ArrayList al = new ArrayList();
al.Add(1);
al.Add("Bill");
al.Add("!");
al.Add(true);
al.Add(4.5);
al.Add(null);

//al.Remove(4.5);

//al.Clear();

Console.WriteLine(al.Capacity);

Console.WriteLine(al.Contains("Bill"));

// Az ArrayListet szöveggé alakítom
string str = string.Join(", ", al.ToArray());

// Kiíratom a szöveget
Console.WriteLine(str);

/*
// adding elements using object initializer syntax
ArrayList al2 = new ArrayList() { 2, "Steve", "?", true, 4.5, null };

// Az ArrayListet szöveggé alakítom
str = string.Join(", ", al2.ToArray());

// Kiíratom a szöveget
Console.WriteLine(str);
*/