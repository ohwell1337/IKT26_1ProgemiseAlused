C# ÕPPESPICKER 2/3 — IF / ELSE / ELSE IF
=======================================

1. MÕTE
-------
if kontrollib tingimust. Kui tingimus on true, käivitatakse if-plokk. Kui see on false, võib käivituda else. else if kontrollib järgmisi tingimusi järjekorras. Ühes if/else if/else ahelas käivitub maksimaalselt üks haru.

2. PÕHIMUSTRID
-------------
if (vanus >= 18)
{
    Console.WriteLine("Täisealine");
}

if (vanus >= 18)
{
    Console.WriteLine("Täisealine");
}
else
{
    Console.WriteLine("Alaealine");
}

if (punktid >= 90)
{
    Console.WriteLine("5");
}
else if (punktid >= 75)
{
    Console.WriteLine("4");
}
else
{
    Console.WriteLine("Muu hinne");
}

3. VÕRDLUSED JA LOOGIKA
----------------------
== võrdub; != ei võrdu; > suurem; < väiksem; >= vähemalt; <= kuni.
&& tähendab JA: punktid >= 70 && punktid <= 100
|| tähendab VÕI: punktid < 0 || punktid > 100
! tähendab EI: !valmis
NB! "1 kuni 29" kaasa arvatud: punktid >= 1 && punktid <= 29.
NB! "rohkem kui 29": punktid > 29. Piirid on tähtsad!

4. TÄIELIK ELUPUNKTIDE PROGRAMM
-------------------------------
See on HARJUTUSNÄIDE sinu kirjelduse põhjal, mitte õpetaja ülesande täpne tekst. Vahemikele 0, 30–69 ja >100 on lisatud mõistlikud näidisvastused.

using System;
namespace Elupunktid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta elupunktid:");
            if (!int.TryParse(Console.ReadLine(), out int elu))
            {
                Console.WriteLine("Viga: sisesta täisarv!");
                return;
            }

            if (elu < 0 || elu > 100)
            {
                Console.WriteLine("Viga: lubatud vahemik on 0 kuni 100!");
            }
            else if (elu == 0)
            {
                Console.WriteLine("Elupunktid on otsas!");
            }
            else if (elu >= 1 && elu <= 29)
            {
                Console.WriteLine($"Oled vigane! Elupunktid: {elu}");
            }
            else if (elu >= 30 && elu <= 69)
            {
                Console.WriteLine($"Vajad taastumist. Elupunktid: {elu}");
            }
            else if (elu >= 70 && elu <= 100)
            {
                Console.WriteLine($"Oled valmis võitluseks! Elupunktid: {elu}");
            }
        }
    }
}

5. SAMA ÜLESANNE int.Parse ABIL
-------------------------------
Console.WriteLine("Sisesta elupunktid:");
int elu = int.Parse(Console.ReadLine());
// NB! Kui kasutaja sisestab sõna, tekib Parse'i viga.
if (elu < 0)
{
    Console.WriteLine("Viga!");
}
else if (elu >= 1 && elu <= 29)
{
    Console.WriteLine("Oled vigane!");
}
else if (elu >= 70 && elu <= 100)
{
    Console.WriteLine("Valmis võitluseks!");
}
else
{
    Console.WriteLine("Muu vahemik (täpsusta ülesande järgi)");
}

6. TEINE TÄIELIK PROGRAMM: VANUSE KONTROLL
-----------------------------------------
using System;
namespace Vanus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta vanus:");
            int vanus = int.Parse(Console.ReadLine());
            if (vanus < 0)
            {
                Console.WriteLine("Vigane vanus!");
            }
            else if (vanus < 18)
            {
                Console.WriteLine($"Oled {vanus} aastat vana ja alaealine.");
            }
            else
            {
                Console.WriteLine($"Oled {vanus} aastat vana ja täisealine.");
            }
        }
    }
}

7. KAKS ERALDI IF-I VS ELSE IF
------------------------------
if (arv > 0) { Console.WriteLine("Positiivne"); }
if (arv > 10) { Console.WriteLine("Üle kümne"); }
// Kui arv=20, käivituvad MÕLEMAD if-id.

if (arv > 10) { Console.WriteLine("Üle kümne"); }
else if (arv > 0) { Console.WriteLine("Positiivne"); }
// Kui arv=20, käivitub ainult esimene haru.

8. BOOL TINGIMUS
----------------
bool valmis = true;
if (valmis) { Console.WriteLine("Valmis"); }
if (!valmis) { Console.WriteLine("Ei ole valmis"); }

9. LEVINUD VEAD
---------------
VALE: if (elu >= 1 || elu <= 29) // peaaegu iga arv sobib
ÕIGE: if (elu >= 1 && elu <= 29)
VALE: if (elu > 70 && elu < 100) // 70 ja 100 jäetakse välja
ÕIGE: if (elu >= 70 && elu <= 100)
VALE: else (elu > 10) // else ei võta tingimust
ÕIGE: else if (elu > 10)
VALE: if (elu == 10); { ... } // semikoolon lõpetab if-i
ÕIGE: if (elu == 10) { ... }

10. KUIDAS UUT ÜLESANNET LAHENDADA
---------------------------------
1) Kirjuta välja kõik vahemikud ja piirid.
2) Küsi sisend ja teisenda õigesse andmetüüpi.
3) Kontrolli vigased väärtused esimesena.
4) Kirjuta if, else if, else õiges järjekorras.
5) Testi piirväärtusi (nt -1, 0, 1, 29, 30, 69, 70, 100, 101).
6) Väljasta muutujad ühel real: Console.WriteLine($"Elu: {elu}, staatus: {staatus}");

11. ISESEISVAD HARJUTUSED
------------------------
A) Küsi temperatuur. Alla 0 = külm; 0–20 = jahe; üle 20 = soe.
B) Küsi hinne 0–100. Alla 0 ja üle 100 = viga; 0–49 = mitterahuldav; 50–74 = rahuldav; 75–89 = hea; 90–100 = väga hea.
C) Küsi kaks arvu. Kui teine on 0, väljasta viga; muidu jaga ja kuva tulemus.
D) Küsi kasutajalt vanus ja bool-luba; kontrolli vanus >= 18 && luba.


12. ENNEM MAGAMISMINEKUT
------------------------

Console.WriteLine("Sisesta elupunktid:");

if (!int.TryParse(Console.ReadLine(), out int elu))
{
    Console.WriteLine("Viga! Sisesta täisarv.");
}
else if (elu == 0)
{
    Console.WriteLine("Elupunktid on otsas!");
}
else if (elu >= 1 && elu <= 29)
{
    Console.WriteLine("Oled vigane!");
}
else if (elu >= 30 && elu <= 69)
{
    Console.WriteLine("Vajad taastumist!");
}
else if (elu >= 70 && elu <= 100)
{
    Console.WriteLine("Valmis võitluseks!");
}
else
{
    Console.WriteLine("Viga! Number peab olema 0 kuni 100.");
}

TAHTEDE EEMALDAMINE, AINULT TAISARVUD
