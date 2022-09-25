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

// Rövidító operátorok
int i = 2;

/*Console.WriteLine(i++);
Console.WriteLine(i);*/

int j = 0;
// j = j + i;
j += i;
// j = j * 3;
j *= 3;
Console.WriteLine(j);