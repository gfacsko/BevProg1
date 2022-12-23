/*
 * A 2022. december 5-én írt zárthelyi egy lehetséges megoldása
 * 
 * Facsko Gabor (facsko.gabor@uni-milton.hu)
 * Milton Friedman Egyetem, Budapest, 2022
 */

/*
 * Kérjen be egy egészszámot, majd generáljon le egy számsort, amelyben 0 és 255 közötti számok vannak. 
 * Írja ki a számokat sorban egymás mellé szóközzel elválasztva.
 * a.	Írja ki egymás alá, hogy (1) Maximum kiválasztás, (2) Összegzés (3) Sorba rendezés (4) Kilépés. 
 *      Kérjen be egy számot egy és négy között. A kód csak ezt a négy számot fogadja el. 
 *      A (4)-es számot beadva érjen véget a program futása.
 * b.	Valósítsa meg a maximum kiválasztást és írja ki a maximális elemet!
 * c.	Valósítsa meg az összegzést és írja ki az összeget!
 * d.	Valósítsa meg a rendezést és írja ki a rendezett tömböt egymás mellé
 */


// A tömb hosszának bekérése
int nArray = -1;
do
{
    Console.Write("Kérem adja meg a generálandó tömb hosszát! ");
    string line = Console.ReadLine();
    try
    { 
        nArray = Convert.ToInt16(line);
    }
    catch (FormatException ex)
    {
        // Kiírja a hibaüzenetet
        Console.WriteLine("Valami hiba történt: " + ex.Message);
    }
} while (nArray < 0);
// Tömb
int[] array = new int[nArray];
// Véletlen szám
Random rnd = new Random();
// Tömb feltöltése
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0, 255);
}

// A tömb elemeinek a kiírása egymás mellé
Console.Write("\nA tömb elemei: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

// Menü
Console.WriteLine("\n\nVálasszon az alábbi opciók közül:\n");
Console.WriteLine("(1) Maximum kiválasztás");
Console.WriteLine("(2) Összegzés");
Console.WriteLine("(3) Sorba rendezés");
Console.WriteLine("(4) Kilépés\n");

// Opciók kezelése
int menu = -1;
do
{
    string line = Console.ReadLine();
    try
    {
        // Ide lehet bármilyen sületlenséget írni (usererror), ezt kezeli a try-catch
        menu = Convert.ToInt16(line);
        //Console.WriteLine("A(z) " + menu + " opciót választotta."); // Debuggoláshoz használtam
        // A menü kezelése
        switch (menu)
        {
            case 1: 
                // Maximum keresés
                Console.WriteLine("A tömb maximuma: " + array.Max());
                break;
            case 2:
                // Összegzés
                Console.WriteLine("A tömb elemeinek összege: "+ array.Sum());
                break;
            case 3:
                // A tömb elemeinek rendezése. Mehetne külön függvénybe is.
                Console.Write("A tömb elemei rendezettem: ");
                // A tömb rendezése
                Array.Sort(array);
                // A rendezett tömb elemeinek kiírása egymás mellé
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine(); // Új sor
                break;
            case 4:
                // Kilépés
                Console.WriteLine("A program befejezi működését.");
                break;
            default:
                // Kezeli, ha a felhasználó olyan számot ad meg, ami nincs a menüben
                Console.WriteLine("Nincs ilyen opció.");
                break;
        }
    }
    catch (FormatException ex)
    {
        // Kiírja a hibaüzenetet
        Console.WriteLine("Valami hiba történt: " + ex.Message);
    }
} while (menu != 4); // Addig ismétli magát, amíg ki nem akar lépni a felhasználó

// TRON stílusú búcsú
Console.WriteLine("\nEND OF LINE");