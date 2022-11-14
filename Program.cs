/* Bevezetés a programozásba példaprogramok C#-ban
 * MicroSoft Visual Studio fejlesztőkörnyezettel
 * 
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 * Milton Friedman University, Budapest, Hungary, 2022
 */

/*
 * Írjon programot, mely megszámolja, hogy a beírt mondatban hány darab "a" betű van!
*/
/*
// Bekérem a mondatot
Console.WriteLine("Kérem írjon be egy mondatot! ");
string mondat = Console.ReadLine(); //.ToLower(); // Kis betűvé alakít mindent.

// Ellenőrzésképpen kiírom a bekért szöveget
Console.WriteLine("\nA beírt mondat: " + mondat);

// Az "a" betűk száma
int nA = 0;

// Megszámolom az "a" betűk számát
for (int i = 0; i < mondat.Length; i++)
{
    if (mondat[i] == 'a')
    {
        nA++;
    }
}

// Az eredmény kiíratása
Console.WriteLine("\nA mondatban " + nA + " db a betű van.");
*/


/*
 * Az előző programot alakítsa át úgy, hogy a számlálandó betűt is ön adhassa meg!
*/

/*
// Bekérem a mondatot
Console.WriteLine("Kérem írjon be egy mondatot! ");
string mondat = Console.ReadLine(); //.ToLower(); // Kis betűvé alakít mindent.

// Bekérem a keresendő betűt
Console.WriteLine("Kérem írjon be egy betűt! ");
// Bekér egy szöveget
string line = Console.ReadLine();
// Átalakítja karakterré. Ha nem egy betű, akkor az első betűt tárolja el.
char betu = line[0];

// Ellenőrzésképpen kiírom a bekért szöveget és a betűt
Console.WriteLine("\nA beírt mondat: " + mondat);
Console.WriteLine("A keresendő betű: " + betu);

// A betűk száma
int nBetu = 0;

// Megszámolom az "a" betűk számát
for (int i = 0; i < mondat.Length; i++)
{
    if (mondat[i] == betu)
    {
        nBetu++;
    }
}

// Az eredmény kiíratása
Console.WriteLine("\nA mondatban " + nBetu + " db " + betu + " betű van.");
*/

/*
 * Az input szövegből távolítsa el a szóközöket!
*/
/*
// Bekérek egy szöveget
Console.WriteLine("Kérem írjon be valamit! ");
string szoveg = Console.ReadLine(); 

// Ellenőrzésképpen kiírom a bekért szöveget
Console.WriteLine("\nA beírt szöveg: " + szoveg);

// Eltávolítom a szóközt
Console.WriteLine("A szöveg szóközök nélkül: ");
for (int i = 0; i < szoveg.Length; i++)
{
    if (szoveg[i] != ' ')
    {
        Console.Write(szoveg[i]);
    }
}

// Új sor
Console.WriteLine();
*/

/*
 * Olvasson be egy mondatot és egy szót! Mondja meg, hogy a szó szerepel-e a mondatban!
*/

/*
// Bekérem a mondatot
Console.WriteLine("Kérem írjon be egy mondatot! ");
string mondat = Console.ReadLine();

// Bekérem a keresendő betűt
Console.WriteLine("Kérem írjon be egy szót! ");
// Bekér egy szöveget
string szo = Console.ReadLine();

// Ellenőrzésképpen kiírom a bekért mondatot és a szót
Console.WriteLine("\nA beírt mondat: " + mondat);
Console.WriteLine("A keresendő szó: " + szo + "\n");

// Annak eldöntése, hogy szerepel-e benne a szó
if (mondat.Contains(szo)) // Mintát az Contains metódussal lehet keresni
    Console.WriteLine("Az adott szó szerepel a mondatban.");
else
    Console.WriteLine("Az adott szó nem szerepel a mondatban.");
*/

/*
 * A beolvasott mondatról döntse el, hogy az visszafelé is ugyanazt jelenti-e! 
 * (Az "Indul a görög aludni", vagy a "Géza kék az ég" visszafelé olvasva is 
 * ugyanazt jelenti.) Ügyeljen a mondatvégi írásjelekre, mivel azok a mondat 
 * elején nem szerepelnek.
*/

/*
// Bekérem a mondatot
Console.WriteLine("Kérem írjon be egy mondatot! ");
string mondat = Console.ReadLine().ToLower(); // Kis betűssé alakítja

// Ellenőrzésképpen kiírom a bekért mondatot
Console.WriteLine("\nA beírt mondat: " + mondat);

// El kell távolítani a szóközöket és az írásjeleket
// Ez fogja tárolni a feldolgozott mondatot
char[] ujMondat = new char[mondat.Length];
// Kiszűröm a szóközt és az írásjeleket
int iUjMondat = 0; // Ez adja majd meg az új mondat hosszát
for (int i = 0; i < mondat.Length; i++)
{
    if (mondat[i] != ' ' && mondat[i] != '.' && mondat[i] != ',' && mondat[i] != '!' && mondat[i] != '?')
    {
        ujMondat[iUjMondat++] = mondat[i];
    }
}

// Visszaalakítom a karektertömböt stringé
mondat = string.Join("", ujMondat);

// Ellenőrzésképpen kiírom a szűrt mondatot
Console.WriteLine("A szűrt mondat: " + mondat);

// Jelzi, hogy palindroma-e a szöveg
bool isPalindroma = true;

// Összehasonlítom a betűket a mondat elején és végén
for (int i = 0; i < iUjMondat; i++)
{
    if (mondat[i] != mondat[(iUjMondat - 1) - i])
    {
        isPalindroma = false;
        //Console.WriteLine(mondat[i] + " " + mondat[(iUjMondat - 1) - i]);
    }
}

if (isPalindroma)
{
    Console.WriteLine("A mondat palindroma.");
}
else
{
    Console.WriteLine("A mondat nem palindroma.");
}
*/

/*
 * A beolvasott mondatok kisbetűit alakítsa nagybetűsre, a nagybetűs karaktereket pedig kisbetűsre!
*/

/*
// Bekérem a mondatot
Console.WriteLine("Kérem írjon be egy mondatot! ");
string mondat = Console.ReadLine(); // Kis betűssé alakítja

// Ellenőrzésképpen kiírom a bekért mondatot
Console.WriteLine("\nA beírt mondat: " + mondat);

// Kiírom az átalakított mondatot
Console.Write("Az átalakított mondat: ");
for (int i = 0; i < mondat.Length; i++)
{
    if (mondat[i] >= 'a' && mondat[i] <= 'z')
    { 
        Console.Write(mondat[i].ToString().ToUpperInvariant());
    }
    else
    { 
        Console.Write(mondat[i].ToString().ToLowerInvariant());
    }
}

// Új sor
Console.WriteLine();
*/

/*
 * Két mondatról döntse el, hogy azonosak-e! Ha a kis és nagybetűk különböznek, a programnak akkor is megoldást kell adnia!
*/

/*
// Bekérünk egy mondatot
Console.Write("Írjon be egy mondatot! ");
string mondat1 = Console.ReadLine().ToLower();

// Bekérünk még egy mondatot
Console.Write("Írjon be még egy mondatot! ");
string mondat2 = Console.ReadLine().ToLower();

// A bekért mondat és minta ellenőrzése
Console.WriteLine("A beírt mondat: " + mondat1);
Console.WriteLine("A beírt másik mondat: " + mondat2);

// Ez jelzi, hogy azonos-e a két mondat
bool isSame = true;
// Ha nem azonos a hosszuk, akkor nem is kell vizsgálni tovább.
if (mondat1.Length == mondat2.Length)
{
    // Van-e különböző karakter
    for (int i = 0; i < mondat1.Length - 1; i++)
    {
        if (mondat1[i] != mondat2[i])
        {
            isSame = false;
        }
    }
}
else
{
    isSame = false;
}

if (isSame)
{
    Console.WriteLine("A két mondat azonos!");
}
else
{
    Console.WriteLine("A két mondat nem azonos!");
}
*/

/*
 * Állapítsa meg, hogy az input szövegben szerepelnek-e számok! * 
 */

/*
// Bekérünk egy szöveget
Console.Write("Írjon be egy szöveget! ");
string szoveg = Console.ReadLine();

// A bekért szöveg ellenőrzése
Console.WriteLine("A beírt szöveg: " + szoveg);

// Ez jelzi, hogy van-e szám a szövegben
bool isNumber = false;

// Megvizsgálunk minden karaktert
for (int i = 0; i < szoveg.Length - 1; i++)
{
    // Ha van benn szám, akkor jelzi
    if('0' <= szoveg[i] && szoveg[i]<='9')
    {
        isNumber = true;
    }
}

if (isNumber)
{
    Console.WriteLine("Van szám a szövegben.");
}
else
{
    Console.WriteLine("Nincs szám a szövegben.");
}
*/

/*
 *Kérjen be egy stringet, és írassa ki betűnként, mindegyiket új sorba!
*/

/*
// Bekérünk egy szöveget
Console.Write("Írjon be valamit! ");
string str = Console.ReadLine();

// A bekért szöveg ellenőrzése
Console.WriteLine("A beírt szöveg: " + str);

// Kiírja soronként
for (int i = 0; i < str.Length; i++)
{
    Console.WriteLine(str[i]);
}
*/

/*
 * Kérjen be egy stringet, és írassa ki visszafelé!
*/

/*
// Bekérünk egy szöveget
Console.Write("Írjon be valamit! ");
string szoveg = Console.ReadLine();

// A bekért szöveg ellenőrzése
Console.WriteLine("A beírt szöveg: " + szoveg);

// Kiírja visszafelé
for (int i = szoveg.Length-1; i >= 0; i--)
{
    Console.Write(szoveg[i]);
}
// Új sor
Console.WriteLine();
*/

/*
 * Kérjen be egy stringet, és írassa ki minden második betűjét
*/

/*
// Bekérünk egy szöveget
Console.Write("Írjon be valamit! ");
string szoveg = Console.ReadLine();

// A bekért szöveg ellenőrzése
Console.WriteLine("A beírt szöveg: " + szoveg);

// Kiírja a szöveg minden második betűjét
for (int i = 1; i < szoveg.Length; i += 2)
{
    Console.Write(szoveg[i]);
}
// Új sor
Console.WriteLine();
*/

/**
 * Kérjen be egy stringet, és írassa ki úgy külön sorokba, hogy az i. sorban 
 * az első i darab betűje van!
 */

/*
// Bekérünk egy szöveget
Console.Write("Írjon be valamit! ");
string szoveg = Console.ReadLine();

// A bekért szöveg ellenőrzése
Console.WriteLine("A beírt szöveg: " + szoveg);

// Ez az i. sor
for (int i = 0; i < szoveg.Length; i++)
{
    // Kiírja a szöveg első i. karakterét
    for (int j = 0; j <= i; j++)
    {
        Console.Write(szoveg[j]);
    }
    Console.WriteLine();
}
*/

/*
 * Kérjen be egy állomány nevet, és írassa ki, hogy program-e 
 * (".com", ".exe", ".bat" az utolsó 4 karaktere)
*/

/*
// Bekérünk egy állomány nevet
Console.Write("Írjon be egy állománynevet! ");
string fileName = Console.ReadLine();

// A bekért szöveg ellenőrzése
Console.WriteLine("A beírt állománynév: " + fileName);

// Indikátor változó
// Az EndWith("minta") megadja, hogy az adott minta megtalálható-e a szövegben.
if (fileName.EndsWith(".com") || fileName.EndsWith(".exe") || fileName.EndsWith(".bat"))
{
    Console.WriteLine("Program.");
}
else
{
    Console.WriteLine("Nem program.");
}
*/

/*
 * Kérjen be két stringet, állapítsa meg, hogy része-e a második az elsőnek, s ha igen, 
 * akkor hányadik pozíción kezdődik benne!
*/

/*
// Bekérünk egy szöveget
Console.Write("Írjon be egy szöveget! ");
string szoveg = Console.ReadLine();

// Bekérünk egy mintát
Console.Write("Írja be a keresendő mintát! ");
string minta = Console.ReadLine();

// A bekért szöveg és minta ellenőrzése
Console.WriteLine("A beírt szöveg: " + szoveg);
Console.WriteLine("A beírt minta: " + minta);

// Az IndexOf() metódus adja meg a minta helyét a stzövegben.
Console.WriteLine("A keresett minta a szövegben a " + (szoveg.IndexOf(minta)+1) + ". helyen kezdődik.");
*/

/*
 * Kérjen be egy szöveget, s minden benne lévő nagy betűt alakítson át kis betűre, 
 * majd írassa ki!
*/

/*
// Bekérünk egy szöveget
Console.Write("Írjon be egy szöveget! ");
string text = Console.ReadLine().ToLower();

// Az átalakított szöveg
Console.WriteLine("A kisbetűs szöveg: " + text);
*/


/*
* Kérjen be egy számot, majd írassa ki úgy, hogy minden számjegye 2-vel nagyobb! 
* (8 ---0, 9---1).
*/

// Bekérünk egy számot
Console.Write("Írjon be egy számot! ");
string szamStr = Console.ReadLine();

// A beírt szám
Console.WriteLine("A beírt szám: " + szamStr);

// Átalakítjuk a számot karaktertömbbé
char[] charSzamTomb = szamStr.ToCharArray();

// Végigmegyünk a szövegen
for (int i = 0; i < charSzamTomb.Length; i++)
{
    switch (charSzamTomb[i])
    {
        // Számjegyek cseréje 0-8 között
        case < '8':
            charSzamTomb[i]++;
            charSzamTomb[i]++;
            break;
        case '8':
            charSzamTomb[i] = '0';
            break;
        case '9':
            charSzamTomb[i] = '1';
            break;
    }
}

// Visszaalakítom a karektertömböt stringé
szamStr = string.Join("", charSzamTomb);

// Az átalakított szám
Console.WriteLine("Az átalakított szám: " + szamStr);