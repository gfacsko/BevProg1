/*Bevezetés a programozásba példaprogramok C#-ban
 * MicroSoft Visual Studio fejlesztőkörnyezettel
 * 
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 *Milton Friedman University, Budapest, Hungary, 2022
 */

// Egyszerű szöveg olvasása és írása
/*
// Írás
StreamWriter sw = new StreamWriter(@"C:\Users\HL3E5Y\source\repos\FajlKezeles\teszt.txt");
sw.WriteLine("Teszt...");
sw.WriteLine("Teszt2");
sw.Close();

// Olvasás
StreamReader sr = new StreamReader(@"C:\Users\HL3E5Y\source\repos\FajlKezeles\teszt.txt");
Console.WriteLine(sr.ReadLine());
Console.WriteLine(sr.ReadLine());
sr.Close();
*/

/*
// Binális állományok olvasása

using System.Xml.Linq;

FileStream fs = new FileStream(@"C:\Users\HL3E5Y\source\repos\FajlKezeles\teszt.exe", FileMode.OpenOrCreate);
int Size = 1024;
byte[] data = new byte[Size];
int b = fs.Read(data, 0, Size);
while (b != 0)
{
    b = fs.Read(data, 0, Size);
}
fs.Close();
*/


// Binális állományok írása és olvasása

/*
// Írás
Stream sin = new FileStream(@"C:\Users\HL3E5Y\source\repos\FajlKezeles\teszt.exe", FileMode.Create);
BinaryWriter bw = new BinaryWriter(sin);
bw.Write(124);
bw.Write("Name");
bw.Close();
sin.Close();

// Olvasás
Stream sout = new FileStream(@"C:\Users\HL3E5Y\source\repos\FajlKezeles\teszt.exe", FileMode.Open);
BinaryReader br = new BinaryReader(sout);
Console.WriteLine(br.ReadInt32());
Console.WriteLine(br.ReadString());
br.Close();
sout.Close();
*/

// Univerzális szöveg olvasás és írás

/*
// Csatorna létrehozása: megadom az állomány elérési útját ÉS append / hozzáfűzés módban nyitom meg (true)
StreamWriter sw = new StreamWriter(@"C:\Users\HL3E5Y\source\repos\FajlKezeles\teszt2.txt", true);

// Állomány írása
sw.WriteLine("Üdv!");

// Állomány lezárása
sw.Close();

// Olvasó csatorna létrehozása
StreamReader sr = new StreamReader(@"C:\Users\HL3E5Y\source\repos\FajlKezeles\teszt2.txt");


// Állomány olvasása
while (sr.EndOfStream == false) // Addig olvas, amíg nem ér az állomány végére
{
    // Kiolvas egy sort és mindjárt kiírja a consolra
    Console.WriteLine(sr.ReadLine());
}


//Console.WriteLine(sr.ReadToEnd()); // Ez mindent beolvas

// Állomány lezárása
sr.Close();
*/


