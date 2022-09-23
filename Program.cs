// See https://aka.ms/new-console-template for more information
//string line;

//Console.WriteLine("Szia, Vilag!"); // kiírás konzol képernyőre (a Console oszály statikus WriteLine metódusa)

/*line = Console.ReadLine(); // Sor beolvasása
Console.WriteLine(line);  // A beolvasott sor kiírása

Console.Write(line);

Console.WriteLine("Nyomj le egy billentyűt!");
Console.ReadKey();*/

/*
int n = 0;
byte b = 0;
string str = "szoveg";
char c = 'c';
bool l = false;

Console.WriteLine(n);
Console.WriteLine(b);

Console.WriteLine(str);
Console.WriteLine(str[3]); // A szamozas 0-tol kezdodik.
Console.WriteLine(c);

Console.WriteLine(l);

Console.WriteLine(sizeof(int)); // Wikipédia

int j, k, m;

j = 1;
k = 2;
//m = 3;

Console.WriteLine(j);
Console.WriteLine(k);
//Console.WriteLine(m);

//float j = 1.2;

*/

/*string str = "vege";

Console.WriteLine("eleje, " + str);*/

//int n = "szoveg";
//int n = 1.4;

//int n = 137;

/*Console.WriteLine(n % 42);

Console.WriteLine(n == 43);
Console.WriteLine(n > 43);
Console.WriteLine(n < 43);
Console.WriteLine(n <= 43);

if (n > 42 && n == 137)
    Console.WriteLine("Nagyobb");*/

/*for (int i=0;i<n;i++)
    Console.WriteLine(i);*/

/*
// Tomb merete
const int nSzavak = 10; 

// Szavak tomb deklaracio
string[] szavak = new string[nSzavak] {"egy","ketto","harom","negy","ot","hat","het","nyolc","kilenc","tiz"};

// Kiiratas
for (int i = 0; i < nSzavak;i++)
    Console.WriteLine(szavak[i]);
*/

/*
// Elso 100 szam kiiratasa ciklussal
const int n = 100;

for (int i = 1; i <= n; i++)
    Console.WriteLine(i.ToString());
*/

/*
 * 
// Az elso n szam paros, paratlan és 13-mal oszthato számainak összege
const int n = 100;

// Összeg
int s = 0;

for (int i = 0; i <= n; i++)
{
    // Páros számok összege
    //if ((i % 2) == 0)
    // Páratlan számok összege
    // if ((i % 2) == 1)
    // 13-mal osztható számok összge
    if ((i % 13) == 0)
    {
        s = s + i;
    };
};

// Eredmeny kiiratasa
Console.WriteLine(s);
*/

// A while ciklus

const int n = 100;

int i = 0;

while (i < n)
{
    i++;
    Console.WriteLine(i.ToString());
}

Console.WriteLine("While ciklus vége.");

/*
// A do-while ciklus

const int n = 100;

int i = 0;

do
{
    i++;
    Console.WriteLine(i.ToString());
}
while (i < n);


Console.WriteLine("A do-while ciklus vége.");
*/


