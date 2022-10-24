/*
 * Stringkezelő programok
 * 
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 * Milton Friedman University, Budapest, Hungary, 2022 
 * 
 * */


/*
 * Írjon programot, mely megszámolja, hogy a beírt mondatban hány darab "a" betű van!
*/

/*
// Bekérünk egy mondatot
string str = "";

Console.Write("Írjon be egy mondatot! ");
str = Console.ReadLine();

// A bekért mondat ellenőrzése
Console.WriteLine("A beírt mondat: " + str);

// Az "a" betűk megszámlálása
// Az "a" betűk száma
int nSample = 0;
for (int i = 0; i < str.Length; i++) // A "Length" tulajdonság a string hossza
{ 
    if (str[i] == 'a')
        nSample++; // nSample += 1; // nSample = nSample + 1;
}

// Az eredmény kiíratása
Console.WriteLine("A beírt mondatban " + nSample + " a betű taláható.");
*/

/*
 * Írjon programot, mely megszámolja, hogy a beírt mondatban hány darab megadott
 * betű van!
*/

/*
// Bekérünk egy mondatot
string str = ""; // A mondat

Console.Write("Írjon be egy mondatot! ");
str = Console.ReadLine();

// Bekérünk egy mintát
string strSample = "";

Console.Write("Írja be a keresendő mintát (egy karakter)! ");
strSample = Console.ReadLine();

char sample = (char)strSample[0];

// A bekért mondat és minta ellenőrzése
Console.WriteLine("A beírt mondat: " + str);
Console.WriteLine("A beírt minta: " + sample);

// Az minta megszámlálása
// Az minta száma
int nSample = 0;
for (int i = 0; i < str.Length; i++) // A "Length" tulajdonság a string hossza
{ 
    if (str[i] == sample)
        nSample++; // nSample += 1; // nSample = nSample + 1;
}

// Az eredmény kiíratása
Console.WriteLine("A beírt mondatban " + nSample + " " + sample + " taláható.");
*/

/*
 * Az input szövegből távolítsa el a szóközöket!
 */

/*
// Bekérünk egy szöveget
Console.Write("Írjon be egy szöveget! ");
string str = Console.ReadLine();

// Itt tárolom el az eredményeket
string result = str.Replace(' ', '_');

// Kiírom az eredményt
Console.WriteLine("A szóköz nélküli szöveg: " + result);
*/

/*
 * Olvasson be egy mondatot és egy szót! Mondja meg, hogy a szó szerepel-e a mondatban!
*/

/*
// Bekérünk egy mondatot
Console.Write("Írjon be egy mondatot! ");
string sentence = Console.ReadLine();

// Bekérünk egy mintát
Console.Write("Írja be a keresendő szót! ");
string word = Console.ReadLine();

// A bekért mondat és minta ellenőrzése
Console.WriteLine("A beírt mondat:!" + sentence + "!");
Console.WriteLine("A beírt szó:!" + word + "!");

// Annak eldöntése, hogy szerepel-e benne a szó
if (sentence.Contains(word)) // Mintát az Contains metódussal lehet keresni
    Console.WriteLine("Az adott szó szerepel a mondatban.");
else
    Console.WriteLine("Az adott szó nem szerepel a mondatban.");
*/

/*
 * A beolvasott mondatok kisbetűit alakítsa nagybetűsre, a nagybetűs karaktereket pedig kisbetűsre!
*/

/*
// Bekérünk egy mondatot
Console.Write("Írjon be egy mondatot! ");
string sentence = Console.ReadLine();

for (int i = 0; i < sentence.Length; i++)
{
    if (sentence[i] >= 'a' && sentence[i] <= 'z')// ( || (sentence[i] >= 223))
        Console.Write(sentence[i].ToString().ToUpperInvariant());
    else
        Console.Write(sentence[i].ToString().ToLowerInvariant());
}
*/

/*
 * Két mondatról döntse el, hogy azonosak-e! Ha a kis és nagybetűk különböznek, a programnak akkor is megoldást kell adnia!
 * 
 */