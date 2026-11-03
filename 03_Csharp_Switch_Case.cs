C# ÕPPESPICKER 3/3 — SWITCH / CASE / MEETODID
============================================

1. SWITCHI MÕTE
---------------
switch (muutuja) valib väärtuse põhjal sobiva case'i. case on konkreetne väärtus, mitte tavaline arvude vahemik. default käivitub, kui ükski case ei sobi. break väljub switch-ist. Ühe switch-i case'id ei käivitu automaatselt üksteise järel.

2. PÕHIMUSTER
------------
Console.WriteLine("Kirjuta koer või kass:");
string loom = Console.ReadLine();
switch (loom)
{
    case "koer":
        Console.WriteLine("Auh!");
        break;
    case "kass":
        Console.WriteLine("Mjäu!");
        break;
    default:
        Console.WriteLine("Tundmatu loom!");
        break;
}

3. STRING JA INT CASE
--------------------
string valik = Console.ReadLine();
switch (valik) { case "1": Console.WriteLine("Üks"); break; default: break; }
// Kui valik on string, siis case "1" on jutumärkides.

int number = int.Parse(Console.ReadLine());
switch (number) { case 1: Console.WriteLine("Üks"); break; default: break; }
// Kui number on int, siis case 1 ei ole jutumärkides.

4. TÄIELIK PROGRAMM: JAGAMINE + KODULINN + HURRAA
------------------------------------------------
Harjutusnäide sinu kirjeldatud kontrolltöö põhjal; täpne õpetaja nõutud case'ide jaotus pole teada.

using System;
namespace Jagamine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene arv:");
            float number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta teine arv:");
            float number2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Vali tehe (/):");
            string tehe = Console.ReadLine();

            switch (tehe)
            {
                case "/":
                    if (number2 == 0)
                    {
                        Console.WriteLine("Nulliga ei saa jagada!");
                        break;
                    }
                    float tulemus = number1 / number2;
                    Console.WriteLine("Mis on sinu kodulinn?");
                    string kodulinn = Console.ReadLine();
                    NaidaTulemus(kodulinn, tulemus);
                    Hurraa();
                    break;
                default:
                    Console.WriteLine("Vale tehe!");
                    break;
            }
        }

        static void NaidaTulemus(string linn, float vastus)
        {
            Console.WriteLine($"Kodulinn: {linn}, jagatis: {vastus}");
        }

        static void Hurraa()
        {
            Console.WriteLine("Hurraaa!!");
        }
    }
}

5. TÄIELIK PROGRAMM: MITU CASE'I JA MEETODID
--------------------------------------------
using System;
namespace Loomad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta koer, kass või lehm:");
            string loom = Console.ReadLine();
            switch (loom)
            {
                case "koer":
                    Auh();
                    break;
                case "kass":
                    Mjau();
                    break;
                case "lehm":
                    Console.WriteLine("Muu!");
                    break;
                default:
                    Console.WriteLine("Vale valik!");
                    break;
            }
        }
        static void Auh() { Console.WriteLine("Auh auh!"); }
        static void Mjau() { Console.WriteLine("Mjäu!"); }
    }
}

6. TÄIELIK PROGRAMM: LIITMINE VÕI KORRUTAMINE
---------------------------------------------
using System;
namespace Kalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esimene arv:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Teine arv:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Tehe (+ või *):");
            string tehe = Console.ReadLine();
            float vastus;
            switch (tehe)
            {
                case "+":
                    vastus = a + b;
                    break;
                case "*":
                    vastus = a * b;
                    break;
                default:
                    Console.WriteLine("Vale tehe!");
                    return; // lõpetab Main-meetodi
            }
            Console.WriteLine("Mis su nimi on?");
            string nimi = Console.ReadLine();
            Tulemus(nimi, vastus);
        }
        static void Tulemus(string nimi, float vastus)
        {
            Console.WriteLine($"{nimi}, sinu vastus on {vastus}!");
        }
    }
}

7. MEETODITE LOOMINE JA KUTSUMINE
--------------------------------
static void Hurraa()
{
    Console.WriteLine("Hurraaa!!");
}
// Main-is: Hurraa();

static void Tervita(string nimi)
{
    Console.WriteLine($"Tere, {nimi}!");
}
// Main-is: Tervita("Mari");

static float Jaga(float a, float b)
{
    return a / b;
}
// Main-is (b != 0 korral): float tulemus = Jaga(10, 2);

void tähendab, et meetod ei tagasta väärtust. Kui meetod tagastab arvu, võib tagastustüüp olla float või int. Meetodi nimi peab väljakutses ühtima. Defineeri meetod Main-ist väljaspool, kuid Program-klassi sees.

8. VÄLJASTAMINE ÜHEL REAL
-------------------------
Console.WriteLine($"Linn: {kodulinn}, tulemus: {tulemus}");
Console.Write("Linn: "); Console.Write(kodulinn); Console.Write(", tulemus: "); Console.WriteLine(tulemus);
Console.WriteLine("Linn: " + kodulinn + ", tulemus: " + tulemus);

9. SWITCH KOOS IF-IGA
---------------------
case "/":
    if (number2 != 0)
    {
        Console.WriteLine($"Jagatis: {number1 / number2}");
    }
    else
    {
        Console.WriteLine("Nulliga jagamine pole lubatud");
    }
    break;
// Selle jaoks peavad number1 ja number2 olema varem loodud arvmuutujad.

10. KORDUVAD CASE'I VÄÄRITIMÕISTMISED
------------------------------------
- case "China": ei tähenda automaatselt, et kutsutakse ChinaMethod(). Pead selle rea ise kirjutama.
- static void ChinaMethod() on definitsioon, ChinaMethod(); on väljakutse.
- string ChinaMethod = Console.WriteLine("..."); on vale: WriteLine ei tagasta stringi.
- case "1": ja case 1: on erinevad; sõltub switch-i muutuja tüübist.
- default ei tähenda järgmise sammu automaatset käivitamist.
- Kui soovid kolme järjestikust tegevust, pane need samasse case'i või kasuta eraldi selget juhtloogikat; ära lisa põhjendamatut menüüd.
- Kui jagamine on ainus lubatud tehe, ära lisa teisi tehteid lihtsalt case'ide arvu suurendamiseks.

11. KUIDAS LAHENDADA UUT SWITCHI ÜLESANNET
----------------------------------------
1) Leia ülesandest, MILLE järgi valitakse case (sõna, tehe või arv).
2) Loo sobiva tüübiga muutuja (string või int) ja küsi sisend.
3) Kirjuta switch (muutuja).
4) Lisa täpselt ülesandes nõutud case'id ja tegevused.
5) Lisa break; igasse harusse ning vajadusel default.
6) Kui nõutakse meetodit, kirjuta static void Meetod() väljaspool Main-i ning kutsu seda Meetod();.
7) Testi kõiki case'e, valet sisendit ja jagamisel nulli.

12. HARJUTUSED
-------------
A) Küsi sõna "tervitus" või "hurraa"; esimene väljastab Tere, teine kutsub meetodi Hurraa().
B) Küsi arv 1, 2 või 3; iga case väljastab eri sõnumi, default ütleb Vale arv.
C) Küsi kaks arvu ja tehe /; nulliga jagamisel teade; muidu küsi kodulinn ja väljasta "Tartu, vastus 5" ühel real ning kutsu Hurraa().
D) Küsi päev (E, T, K); iga case kutsub erineva meetodi või väljastab sõnumi.

13. KONTROLLNIMEKIRI
--------------------
[ ] switch-i muutuja on loodud
[ ] case väärtused on õiget tüüpi
[ ] iga case sees on nõutud tegevus
[ ] break ja default on olemas
[ ] meetod on defineeritud ja õigesti välja kutsutud
[ ] jagaja pole null
[ ] väljund on ülesandes nõutud kujul
