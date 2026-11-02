 IF ja ELSE – kõige olulisem
if kontrollib, kas tingimus on tõene. else käivitub siis, kui tingimus pole tõene.


int vanus = 16;

if (vanus >= 18)
{
    Console.WriteLine("Oled täisealine");
}
else
{
    Console.WriteLine("Oled alaealine");
}


else if võimaldab kontrollida rohkem tingimusi:

int punktid = 75;

if (punktid >= 90)
{
    Console.WriteLine("Hinne 5");
}
else if (punktid >= 75)
{
    Console.WriteLine("Hinne 4");
}
else if (punktid >= 50)
{
    Console.WriteLine("Hinne 3");
}
else
{
    Console.WriteLine("Hinne 2");
}



Märk | Tähendus | Näide |
|---|---|---|
| == | Võrdub | arv == 5 |
| != | Ei võrdu | arv != 5 |
| > | Suurem kui | arv > 5 |
| < | Väiksem kui | arv < 5 |
| >= | Suurem või võrdne | arv >= 5 |
| <= | Väiksem või võrdne | arv <= 5 |
| && | JA – mõlemad tingimused | arv > 0 && arv < 10 |
| || | VÕI – vähemalt üks tingimus | arv < 0 || arv > 10 |
| ! | EI – vastupidine tõeväärtus | !valmis |
Ära aja segamini: = annab muutujale väärtuse, == võrdleb kahte väärtust.



SWITCH ja CASE
switch võrdleb muutujat erinevate case-idega. Igal case-il võib olla oma tegevus.

Console.WriteLine("Sisesta värv:");
string varv = Console.ReadLine();

switch (varv)
{
    case "punane":
        Console.WriteLine("Valisid punase");
        break;

    case "sinine":
        Console.WriteLine("Valisid sinise");
        break;

    case "roheline":
        Console.WriteLine("Valisid rohelise");
        break;

    default:
        Console.WriteLine("Tundmatu värv");
        break;
}


Pea meeles:
switch (varv) – mida kontrollitakse.
case "punane": – kontrollitav väärtus ja sellele vastav tegevus.
break; – lõpetab selle case-i.
default: – käivitub, kui ükski case ei sobi.



Meetodi väljakutsumine SWITCH-is
Kuna teie varasemas ülesandes oli meetodi väljakutsumine oluline, siis jäta see ka meelde.


switch (valik)
{
    case "auh":
        Skibidimethod();
        break;

    default:
        Console.WriteLine("Vale valik!");
        break;
}

Meetod tuleb kirjutada Main-meetodist väljapoole, aga Program-klassi sisse:

static void Skibidimethod()
{
    Console.WriteLine("Auh!");
}

Siin eeldame, et valik on varem loodud string-muutuja.



Kuidas aru saada, mida ülesandes kasutada?
| Kui õpetaja palub... | Kasuta |
|---|---|
| Kontrolli, kas vanus on üle 18 | if |
| Kui pole üle 18, tee midagi muud | else |
| Kontrolli mitut vanusevahemikku | else if |
| Kontrolli mitut kindlat valikut | switch ja case |
| Kontrolli, kas kaks tingimust kehtivad | && |
| Kontrolli, kas vähemalt üks kehtib | || |
| Küsi täisarvu | int.Parse(Console.ReadLine()) |
| Käivita eraldi funktsioon | Meetodi väljakutsumine |
















