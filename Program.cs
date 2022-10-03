/* Elso orai program
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 * Milton Friedman University, Budapest, Hungary, 2022 
 */

/*
string line = ""; // Ez a beolvasando sor szoveges valtozoja

Console.WriteLine("Szia, Vilag!"); // Kiiras*/

// Pelda a ReadLine() metodusra
/*Console.WriteLine("Irjon be egy szoveget ls nyomjon ENTER-t!");  // Kezelesi utasitas
line = Console.ReadLine(); // Sor beolvasara
//Console.WriteLine(line); // Teljesen felesleges barbarizmus (a beolvasott valtozo kiirasa) */

// Pelda ReadKey() metodusra
/*Console.WriteLine("Nyomjon le egy billentyut!");  // Kezelesi utasitas
Console.ReadKey();  // Beker egy billentyut */

// Pelda a Write() metodusra
/*Console.Write("Teszt");
Console.Write("Teszt2");*/

/*int n; // n valtozo, egesz

n = 0;*/


/*
int n = 0;   // Egesz valtozo ertekadassal
byte b = 0;  // byte ertekadassal

// Egesz szam kiirasa
Console.Write("Egész változó: "); Console.WriteLine(n);
// Byte tipusu valtozo kiirasa
Console.Write("Byte változó: "); Console.WriteLine(b);

double r = 1.41; // Valos szam ertekadassal

// Lebegopontos valtozo kiirasa
Console.Write("Lebegőpontos változó: "); Console.WriteLine(r);

char c = 't';  // Karakter
string str = "Szöveg"; // Szoveg

// Karakter kiirasa
Console.Write("Karakter: "); Console.WriteLine(c);
// String kiirasa
Console.Write("Szoveg/string: "); Console.WriteLine(str);
// A string egy elemenek kiirasa
Console.Write("Karakter: "); Console.WriteLine(str[3]);

bool l, k;  // Logikai változok
l = false;
k = true;

// Logikai valtozok kiirasa
Console.Write("Boolean/logikai változók: ");
Console.Write(l);
Console.Write(" ");
Console.WriteLine(k);

// Pelda szoveg összefuzesere
Console.Write("Szöveg változó: "); Console.WriteLine(str);
Console.WriteLine(str + " még szöveg");
*/

/*
// Egész számot definiálok
int n = 0;

// Hiba, nem lehet lebegőpontos értéket adni egész változónak
n = 3.14;
*/

/*
// = értéadás
string str = "pelda";
*/

// ----------- Óra eleje 2022. 09. 26. ------------------------------------------

/*
// Matematikai operátorok
// Két szám deklarálása
double r = 3.14;
double p = 2.71;

// A számok kiírása
Console.WriteLine("Az r értéke: " + r);
Console.WriteLine("A p értéke: " + p);

// A művelet eredményét tároló változó
double result; // = r + p;

// Összeadás művelet
result = r + p;

// Az összeadás eredményének kiírása
Console.WriteLine("Ar r + p művelet eredménye: " + result);

// Kivonás művelet
result = r - p;

// Az kivonás eredményének kiírása
Console.WriteLine("Ar r - p művelet eredménye: " + result);

// Szorzás művelet
result = r * p;

// Az szorzás eredményének kiírása
Console.WriteLine("Ar r * p művelet eredménye: " + result);

// Osztás művelet
result = r / p;

// A osztás eredményének kiírása
Console.WriteLine("Ar r / p művelet eredménye: " + result);


// Maradékos osztás művelet
// Egész változó deklarálása
int n = 42;
int m = 11;

result = n % m;
// Az maradékos osztás eredményének kiírása
Console.WriteLine("Az " + n + " % " + m + " maradékos osztás művelet eredménye: " + result);
*/

/*
// Párosság vizsgálat, logokai operátorok ---------------------------------
int n = 137;
int m = 2;


// Elágazás else utasítással
if (n % m == 0)
{
    // Az o változó itt érvényes
    //int o = 137;
    // Több utasítást is végrehajt
    Console.WriteLine("Az " + n + " páros szám");
    Console.WriteLine("Jaj, de jó!");
    // Az o itt érvényes
    //Console.WriteLine("o = " + o);
}
else
{
    Console.WriteLine("Az " + n + " páratlan szám");
}
// Nincs deklarálva az o, nem évényes
//Console.WriteLine("o = " + o);


// Elágazás else nélkül

string message = " páratlan szám";

if (n % m == 0)
    message = " páros szám";

Console.WriteLine("Az " + n + message);
*/

/*
// Relációs operátorok

// Két egész szám deklarálása
int n = 42;
int m = 137;

// Kisebb
if (n < m)
    Console.WriteLine("A(z) " + n + " szám kisebb a(z) " + m + " számnál");

// Kisebb egyenlő
if (n <= m)
    Console.WriteLine("A(z) " + n + " szám nem nagyobb a(z) " + m + " számnál");

// Nagyobb
if (n > m)
    Console.WriteLine("A(z) " + n + " szám nagyobb a(z) " + m + " számnál");

// Nagyobb egyenlő
if (n >= m)
    Console.WriteLine("A(z) " + n + " szám nem kisebb a(z) " + m + " számnál");

// Egyenlőség
if (n == m)
    Console.WriteLine("A(z) " + n + " szám egyenlő a(z) " + m + " számmal");

/*
// Logikai operatorok

// Logikai (Boolean) változó. Értéke true / false
bool A = true;
// Logikai (Boolean) konstans változó. Értéke true / false és nem változtatható meg.
const bool B = false;

// Logikai változó kiiratása
Console.WriteLine("A = " + A);
Console.WriteLine("B = " + B);


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
//Console.WriteLine("A AND B = " + (A && B));

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


/*
// Logikai operátorok hazsnálata elágazásban

bool a = true;
bool b = false;

// Logikai változó kiiratása
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);

// AND művelet használata elágazásban
Console.WriteLine("A(z) a ÉS b állítás: " + (a && b));

if (a && b)
{
    Console.WriteLine("Igaz.");
}
else
{
    Console.WriteLine("Hamis.");
}

// OR művelet használata elágazásban
Console.WriteLine("A(z) a VAGY b állítás: " + (a || b));

if (a || b)
{
    Console.WriteLine("Igaz.");
}
else
{
    Console.WriteLine("Hamis.");
}

// XOR művelet használata elágazásban
Console.WriteLine("A(z) a XOR / kizáró VAGY b állítás: " + (a ^ b));

if (a ^ b)
{
    Console.WriteLine("Igaz.");
}
else
{
    Console.WriteLine("Hamis.");
}

// NOT művelet használata elágazásban
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

// ++ az i = i + 1;
//int l = ++i; // Új értek hazsnálata
//int l = i++; // Régi érték használata
//Console.WriteLine(l);

int j = 0;
// j = j + i;
j += i;
Console.WriteLine(j);
// j = j * 3;
j *= 3;
Console.WriteLine(j);
*/

/*
// A for ciklus
// Konstans, a ciklushoz használjuk
const int N = 100;

for (int i = 1; i <= N; i++)
{
    Console.WriteLine("i = " + i);
}
//Console.WriteLine("i = " + i);
*/

/*
// Konstans, a ciklushoz használjuk
const int N = 10;
// Tömb deklarációja
string[] szavak = new string[] { "egy","kettő","három","négy","öt","hat","hét","nyolc","kilenc","tíz"};

// Szabak kiíratása ciklussal
for (int i = 0; i < N; i++)
{
    Console.WriteLine(szavak[i]);
}
*/

/*
// A while cikus
// Elemek száma
const int N = 100;
int i = 1;

while (i <= N)
{
    Console.WriteLine(i);
    i++;
}
Console.WriteLine(i);
*/

/*
// A do-while cikus
// Elemek száma
const int N = 100;
int i = 1;

do
{
    Console.WriteLine(i);
    i++;
} while (i <= N);

Console.WriteLine(i);
*/


/*
// Adatbevitel
string line = "";
int m = 0;


// Bekérem a szöveget
Console.Write("Kérem az egész számot! ");
line = Console.ReadLine();

// Szöveget számmá alakít
m = Convert.ToInt32(line);

// Kiíratás
Console.WriteLine(m * 2);
*/

/*
// Másodfokú egyeletet megoldó program
string line = "";

// Állandók bekérése
Console.WriteLine("A másodfokú egyelet általános alakja: a x^2 + b x + c = 0 ");
// a állandó
Console.Write("a = "); 
line =  Console.ReadLine();
double a = Convert.ToDouble(line);
// b állandó
Console.Write("b = ");
line = Console.ReadLine();
double b = Convert.ToDouble(line);
// c állandó
Console.Write("c = ");
line = Console.ReadLine();
double c = Convert.ToDouble(line);

// Ellenőrzés
Console.WriteLine("A megadott egyenlet: " + a + " x^2 + " + b + " x + " + c);

// Diszkrimináns
double d = Math.Pow(b, 2) - 4 * a * c;
Console.WriteLine("A diszkrimináns: " + d);


// ha D > 0, akkor két megoldás van
if (d > 0)
{
Console.WriteLine("D > 0, az egyenletnek így két megoldása van.");
double x1 = (-1 * b - Math.Sqrt(d)) / (2 * a);
double x2 = (-1 * b + Math.Sqrt(d)) / (2 * a);
Console.WriteLine("Az egyenlet megoldásai: x1 = " + x1 + " x2 = " + x2);
}

// ha D = 0, akkor csak egy megoldás van
if (d == 0)
{
Console.WriteLine("D = 0, az egyenletnek így csak egy megoldása van.");
double x = (-1 * b) / (2 * a);
Console.WriteLine("Az egyenlet megoldása: x = " + x);
}

// ha D < 0, akkor nincs megoldás a _valós számok körében_.
if (d < 0)
{
Console.WriteLine("Az egyenletnek nincsen megoldása a valós számok körében.");
}

switch (d)
{
case > 0:
    Console.WriteLine("D > 0, az egyenletnek így két megoldása van.");
    double x1 = (-1 * b - Math.Sqrt(d)) / (2 * a);
    double x2 = (-1 * b + Math.Sqrt(d)) / (2 * a);
    Console.WriteLine("Az egyenlet megoldásai: x1 = " + x1 + " x2 = " + x2);
    break;
case < 0:
    Console.WriteLine("Az egyenletnek nincsen megoldása a valós számok körében.");       
    break;
default:
    Console.WriteLine("D = 0, az egyenletnek így csak egy megoldása van.");
    double x = (-1 * b) / (2 * a);
    Console.WriteLine("Az egyenlet megoldása: x = " + x);
    break;
}
*/

/*
// Példa goto parancsra
Console.WriteLine("Első sor");

// Címke / label a goto prancsra
nehasznald:
    Console.WriteLine("Példa a goto parancsra.");

// Tiltott parancs
goto nehasznald;

// Ide nem jut el
Console.WriteLine("Utolsó sor");
*/

/*
// Számológép: bekér kér számot, bekér egy műveleti jelet és elvégzi a műveletet
// Segédváltozó
string line = "";

// Bekér egy számot
Console.WriteLine("Kérek két számot:");
Console.Write("a = ");
line = Console.ReadLine();
// Valós számmá alakítja
double a = Convert.ToDouble(line);

// Bekér még egy számot
Console.Write("b = ");
line = Console.ReadLine();
// Valós számmá alakítja
double b = Convert.ToDouble(line);

// Bekér egy műveleti jelet
Console.Write("Milyen műveletet végezzek (+, -, *, /, %)? ");
// Elég egy karakter
line = Console.ReadLine();
// Egy string -> char converzió
char m = Convert.ToChar(line);

switch (m)
{
    case '+':
        Console.WriteLine(a + " " + line + " " + b + " = " + (a + b));
        break;
    case '-':
        Console.WriteLine(a + " " + line + " " + b + " = " + (a - b));
        break;
    case '*':
        Console.WriteLine(a + " " + line + " " + b + " = " + (a * b));
        break;
    case '/':
        Console.WriteLine(a + " " + line + " " + b + " = " + (a / b));
        break;
    case '%':
        Console.WriteLine(a + " " + line + " " + b + " = " + (a % b));
        break;
    default:
        Console.WriteLine("Nem tudom a parancsot értelmezni.");
        break;
}
*/

/*
// Művelet eredménye
double result = 0.0;

switch (m)
{    
    case '+':
        result = a + b;
        break;
    case '-':
        result = a - b;
        break;
    case '*':
        result = a * b;
        break;  
    case '/':
        result = a / b;
        break;
    case '%':
        result = a % b;       
        break;
    default:
        Console.WriteLine("Nem tudom a parancsot értelmezni.");
        break;
}

if (result != 0.0)
    Console.WriteLine(a + " " + line + " " + b + " = " + result);
*/

Console.WriteLine("Teszt");

// Csipog egyet
Console.Beep();
// Háttér szine
Console.BackgroundColor = ConsoleColor.DarkBlue;
// Szöveg szine
Console.ForegroundColor = ConsoleColor.Red;
// Képernyőtörlés
Console.Clear();
// Törli színbeállításokat
Console.ResetColor();
Console.WriteLine("Teszt2");
// Kiírja az ablak címét
Console.WriteLine(Console.Title);
// Az ablak magassága
Console.WriteLine("Az ablak magassága: " +Console.WindowHeight);
// Az abklak szélessége
Console.WriteLine("Az ablak szélessége: " + Console.WindowWidth);


