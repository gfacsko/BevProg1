// See https://aka.ms/new-console-template for more information
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