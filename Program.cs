// See https://aka.ms/new-console-template for more information
/* Bevezetés a programozásba példaprogramok C#-ban
 * MicroSoft Visual Studio fejlesztőkörnyezettel
 * 
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 * Milton Friedman University, Budapest, Hungary, 2022
 */
/*
 * string line = "aaa"; // Ebbe a változóba olvassa majd be a sort

Console.WriteLine("Szia, Világ!"); // Kiírja a szöveget
*/

/*line = Console.ReadLine(); // Sor beolvasása

Console.WriteLine(line);  // A beolvasott sor kiírása

Console.Write(line);
Console.WriteLine("vege");*/

/*
Console.WriteLine("Nyomj le egy billentyűt!");
Console.ReadKey();
*/

// Egész típusú változó definíciója
//int n = 0;
// Értékadás
// n = 0;

// Több változó deklaráslása egy sorban
// int k, l;

// Állandó / konstans érték
// const int n = 100;

/*
// Valós tipusú változó deklarálása
double a = 3.14;
double b = 2.71;

// Egész típusú változónak nem lehet tört értéket adni.
// k = 2.71;

Console.WriteLine("a = " + a.ToString());
Console.WriteLine("b = " + b);
Console.WriteLine("a + b = " + (a + b));
Console.WriteLine("a - b = " + (a - b));
Console.WriteLine("b - a = " + (b - a));
Console.WriteLine("a * b = " + a * b);

// Egy változónevet, egy namespace-ben egyszer lehet használni
// int a = 2;
*/

/*
// Ezt az elemet íratjuk ki
const int n = 4;

// Karakter típusú változó deklarálása
char c = 'a';
// Szöveg típusú változó deklarálása
string s = "szöveg";
// Konstans szöveg típusú változó deklarálása
const string t = "másik";

// Konstant változót nem lehet felülírtni
//t = "egyik";

// Karakter típusú változó kiíratása
Console.WriteLine("Karakter típusú változó: " + c);
// Szöveg típusú változó kiíratása
Console.WriteLine("Szöveg típusú változó: " + s);
// Szöveg típusú változó egy elemének kiíratása
Console.WriteLine("Az " + s + " szöveges típusú változó " + n + ". elme: " + s[n]);
// Szöveg típusú változók konkatenációjának / összefűzésének kiíratása
Console.WriteLine("Szöveges változók összefűzése: " + s + " " + t);
// Szöveg és karakter típusú változók konkatenációjának / összefűzésének kiíratása
Console.WriteLine("Szöves és karakter változók összefűzése: " + s + " " + c);
*/

/*
// Logikai (Boolean) változó. Értéke true / false
bool A = true;
// Logikai (Boolean) konstans változó. Értéke true / false és nem változtatható meg.
const bool B = true;

// Logikai változó kiiratása
Console.WriteLine("A = " + A);
Console.WriteLine("B = " + B);
*/

/*
 * AND / ÉS művelet
 * A | B | A AND B
 * ================
 * n | n | n
 * n | i | n
 * i | n | n
 * i | i | i
 */

// Példa AND műveletre
//Console.WriteLine("A AND B =" + (A && B));

/*
 * OR / VAGY művelet
 * A | B | A OR B
 * ================
 * n | n | n
 * n | i | i
 * i | n | i
 * i | i | i
 */

// Példa OR műveletre
//Console.WriteLine("A OR B = " + (A || B));

/*
 * XOR / KIZÁRÓ VAGY művelet
 * A | B | A XOR B
 * ================
 * n | n | n
 * n | i | i
 * i | n | i
 * i | i | n
 */

// Példa XOR műveletre
//Console.WriteLine("A XOR B = " + (A ^ B));

/*
 * Negáció művelet
 * A | NOT B
 * ================
 * n | i
 * i | n
 *
 */

// Példa NOT műveletre
//Console.WriteLine("NOT A = " + !A);


// Egész típusú változóban nem lehet szöveget rakni
//int a = "Hello";

/*
 * Művelet: speciális függvény
 * 
 * + : R x R -> R, ahol R a valós számok halmaza
 * 
 * pl. 2.1 + 3.3 = 5.4
 * 
 */

/*
// Két egész szám
int a = 4;
int b = 17;

// Példa műveletre
int c = a + b;
int d = a * b;
int e = a - b;
// Típus konverzió
int f = (int)((double)a / (double)b);
// Modulo / oszthatóság
int g = b % a;
// Páros / páratlan számok
int h = a % 2;
int i = b % 2;

// Eredmények kiírása
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("c = a + b = " + c);
Console.WriteLine("d = a * b = " + d);
Console.WriteLine("e = a - b = " + e);
Console.WriteLine("f = a / b = " + f);
Console.WriteLine("g = b mod a = " + g);
Console.WriteLine("h = a mod 2 = " + h);
Console.WriteLine("i = b mod 2 = " + i);
*/

// Példa elágazásra. HA ((a mod 2) == 0), AKKOR a páros szém
//if (a % 2 == 0)
//    Console.WriteLine("A(z) " + a + " páros szám.");

/*
if (a % 2 == 0)
{
    Console.WriteLine("A(z) " + a + " páros szám.");
    if (a % 3 == 0)
    {
        Console.WriteLine("A(z) " + a + " 3-mal osztható szám.");

    }
    else
    {
        Console.WriteLine("A(z) " + a + " 3-mal nem osztható szám.");
    };
}
else
{
    Console.WriteLine("A(z) " + a + " páratlan szám.");
};

if (b % 2 == 0)
{
    Console.WriteLine("A(z) " + b + " páros szám.");
} 
else
{
    Console.WriteLine("A(z) " + b + " páratlan szám.");
};


// Relációs operátorok
if (a == b)
{
    Console.WriteLine("A(z) " + a + " kisebb a(z) " + b + "-nél.");
}


// Relációs operátorok
Console.WriteLine("A(z) " + a + " == a(z) " + b + "-nél: " + (a == b));
Console.WriteLine("A(z) " + a + " < a(z) " + b + "-nél: " + (a < b));
Console.WriteLine("A(z) " + a + " > a(z) " + b + "-nél: " + (a > b));
Console.WriteLine("A(z) " + a + " <= a(z) " + b + "-nél: " + (a <= b));
Console.WriteLine("A(z) " + a + " >= a(z) " + b + "-nél: " + (a >= b));

// Értéket add, ha csak = van. Ne hazsnálják! Gyakori hiba. 
Console.WriteLine("A(z) " + a + " = a(z) " + b + "-nél: " + (a = b));
*/

/*
// Logikai operátorok
bool a = true;
bool b = false;

Console.WriteLine("A(z) a ÉS b állítás: " + (a && b));

if (a && b)
{
    Console.WriteLine("Igaz.");
}
else
{
    Console.WriteLine("Hamis.");
}

Console.WriteLine("A(z) a VAGY b állítás: " + (a || b));

if (a || b)
{
    Console.WriteLine("Igaz.");
}
else
{
    Console.WriteLine("Hamis.");
}

Console.WriteLine("A(z) a XOR / kizáró VAGY b állítás: " + (a ^ b));

if (a ^ b)
{
    Console.WriteLine("Igaz.");
}
else
{
    Console.WriteLine("Hamis.");
}

Console.WriteLine("A(z) a NOT b állítás: " + (!b));

if (!b)
{
    Console.WriteLine("Igaz.");
}
else
{
    Console.WriteLine("Hamis.");
}
*/


/*
// Rövidító operátorok
int i = 2;

Console.WriteLine(i++);
Console.WriteLine(i);

// Rövidítések
int j = 0;
// j = j + i;
j += i;
// j = j * 3;
j *= 3;
Console.WriteLine(j);
*/

/*
// Példa ciklusra
// Maximális érték
const int N = 100;

// A for ciklus
for (int i = 0; i < N; i++)
{
    Console.WriteLine("i = " + i);
}

// A ciklus változó nem létezik a cikluson kívül
//double i = 137;

//
*/

/*
// Példa tíz szó kiiratása
const int Nszavak = 10;

//string[] szavak = new string[Nszavak];
string[] szavak = new string[] { "egy", "kettő", "három", "négy", "öt", "hat", "hét", "nyolc", "kilenc", "tíz" };

// Kiírom az eredményt
for (int i = 0; i < Nszavak; i++)
{
    Console.WriteLine((i + 1) + ". szó: " + szavak[i]);
}
*/

/*
// Példa számok kiiratására 
// A tömb deklarálásánál adom meg az értékeket
int[] szamok = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

// Kiírom a tömb értékeit
for (int i = 0; i < szamok.Length; i++)
{ 
    Console.WriteLine((i+1) + ". szám: " + szamok[i]);
}
*/

/*
// Példa számok kiiratására 
// A tömb értékeit később adom meg

// Megadom a tömb hosszát
const int Nszamok = 20;
// Lefoglalom a tömb helyét
int[] szamok = new int[Nszamok];

// Feltöltöm a tömböt ciklussal
for (int i = 0; i < Nszamok; i++)
{
    szamok[i] = (i + 1) * 10;
}

// Kiírom a tömb értékeit
for (int i = 0; i < Nszamok; i++)
{
    Console.WriteLine((i + 1) + ". szám: " + szamok[i]);
}
*/

/*
// Első 100 szám páros, páratlan és 13-mal osztható számainak összege
const int Nszamok = 100;

// Az összeg tárolása
int sum = 0;

for (int i = 1; i <= Nszamok; i++)
{
    //if ((i % 2) == 0) // Páros számok
    //if ((i % 2) == 1) // Páratlan számok
    if ((i % 13) == 0) // 13-mal osztható számok
    {
        sum = sum + i;
    }
}
//Console.WriteLine("Az első " + Nszamok + " páros szám összege: " + sum);
//Console.WriteLine("Az első " + Nszamok + " páratlan szám összege: " + sum);
Console.WriteLine("Az első " + Nszamok + " 13-mal osztható szám összege: " + sum);
*/

/*
// Példa while-do (elöltesztelő) ciklusra
// 20 szám kiíratása
const int n = 20;

// Ciklusváltozó
int i = 1;

// Elöltesztető ciklus
while (i <= n)
{
    // Kiírom számokat
    Console.WriteLine(i);
    // Növelni kell a ciklusváltozó értékét (vagy végtelen ciklusba kerülök)
    i = i + 1;
}
*/

/*
// Példa do-while (hátultesztelő) ciklusra
// 20 szám kiíratása
const int n = 20;

// Ciklusváltozó
int i = 1;

// Hátultesztető ciklus
do
{
    // Kiírom számokat
    Console.WriteLine(i);
    // Növelni kell a ciklusváltozó értékét (vagy végtelen ciklusba kerülök)
    i = i + 1;
} while (i <= n);
*/


/*
// Számok összege while-do ciklussal
const int n = 100;

// Ciklusváltozó
int i = 1;

// A számok összege
int sum = 0;

// Elöltesztető ciklus
while (i <= n)
{
    // Összeadom a számokat
    sum = sum + i;
    // Növelni kell a ciklusváltozó értékét (vagy végtelen ciklusba kerülök)
    i = i + 1;
}
// Kiírom számokat
Console.WriteLine("Az első " + n + " szám összege: " + sum);
*/

/*
// Egész típusú változó
int i = 10;
// Lebegőpontos (valós) typusú változó
double r = 13.1;
// Egész típusú változóba lebegőpontos változót típuskényszerítéssel helyezhetünk
int osszeg = i + (int)r;

// Ugrik a "vege" cimkére
goto vege;

// Eredmények kiírás + egy extra típuskényszerítés
Console.WriteLine(i + " + " + (int)r + " = " + osszeg);

vege:
Console.WriteLine("The End");
*/

// Másodfokú egyenlet megoldása
Console.WriteLine("A másodfokú egyenlet általános alakja:");
Console.WriteLine("a * x^2 + b * x + c = 0");

// Segéd string változó
string line = "";

// Bekérem az "a" változót
Console.Write("a = ");
line = Console.ReadLine();
double a = Convert.ToDouble(line);

// Bekérem az "b" változót
Console.Write("b = ");
line = Console.ReadLine();
double b = Convert.ToDouble(line);

// Bekérem az "c" változót
Console.Write("c = ");
line = Console.ReadLine();
double c = Convert.ToDouble(line);

// Ellenőrzés
Console.WriteLine(a + " * x^2 + " + b + " * x + " + c + " = 0");

// Diszkrimináns
//double D = b * b - 4 * a * c;
// Math.Pow() hatványoz
double D = Math.Pow(b, 2) - 4 * a * c;
// A diszkrimináns értékeének kiíratása
Console.WriteLine("A diszkrimináns értéke: " + D);

// A diszkrimináns értéke szerinti megoldások megadása
if (D > 0)
{
    // Gyökvonás a Math.Sqrt()
    double x1 = (-1 * b - Math.Sqrt(D)) / (2 * a);
    double x2 = (-1 * b + Math.Sqrt(D)) / (2 * a);
    Console.WriteLine("Két megoldás van: x1 = " + x1 + " és x2 = " + x2);
}

if (D == 0)
{
    double x = (-1 * b) / (2 * a);    
    Console.WriteLine("Egy megoldás van: x = " + x);
}

if (D < 0)
{
    Console.WriteLine("Nincs megoldás a valós számok halmazán.");
}