// W sklepie ze sprzętem AGD oferowana jest sprzedaż ratalna. Napisz program
//umożliwiający wyliczenie wysokości miesięcznej raty za zakupiony sprzęt. Danymi
//wejściowymi dla programu są:
//• cena towaru(od 100 zł do 10 tyś.zł),
//• liczba rat(od 6 do 48).
//Kredyt jest oprocentowany w zależności od liczby rat:
//• od 6–12 wynosi 2.5 % ,
//• od 13–24 wynosi 5 %,
//• od 25–48 wynosi 10 %.
//Obliczona miesięczna rata powinna zawierać również odsetki. Program powinien
//sprawdzać, czy podane dane mieszczą się w określonych powyżej zakresach, a w
//przypadku błędu pytać prosić użytkownika ponownie o podanie danych.

//zloopowane ma byc to:

//Console.WriteLine("Podaj cenę towaru od 100 do 100 tys. zł:"); PODAJ
//cena = float.Parse(Console.ReadLine()) ZCZYTAJ

//jeśli to, co zczytałeś przed chwilą, czyli:
//to: "cena = float.Parse(Console.ReadLine())"
//nie mieści się w przedziale <100;100tys>

//Console.WriteLine("Podaj cenę towaru od 100 do 100 tys. zł:");
//float cena = float.Parse(Console.ReadLine());
//Console.WriteLine(" ");

//while (cena < 100 || cena > 100000)
//{
//    if (cena < 100)
//    {
//        Console.WriteLine("Za mała cena towaru");
//        Console.WriteLine(" ");
//    }
//    else
//    {
//        Console.WriteLine("Za duża cena towaru");
//        Console.WriteLine(" ");
//    }
//    Console.WriteLine("Podaj cenę towaru od 100 do 100 tys. zł:");
//    cena = float.Parse(Console.ReadLine());
//    Console.WriteLine(" ");
//}
Console.Title = "AGD"; // ------------- tytuł programu

float cena;
do//robi to dopóki po while jest prawdziwe, zawiera się w tym co napisałam wnnawiasie
{
    Console.WriteLine("Podaj cenę towaru od 100 do 100 tys. zł:");
    Console.WriteLine();
    cena = float.Parse(Console.ReadLine());
} while (cena < 100 || cena > 100000);

float rata;
do
{
    Console.WriteLine("Podaj liczbe rat od 6 do 48:");
    rata = float.Parse(Console.ReadLine());
    Console.WriteLine(" ");
    if (rata < 6) 
        Console.WriteLine("TY CHUJU CO TY KURWA KREDYT W MNIEJ NIŻ PÓŁ ROKU CHCESZ PŁACIĆ");
    else if (rata > 48) 
        Console.WriteLine("NIE MA KURWA KREDYTÓW NA WIĘCEJ NIŻ 4 LATA BIEDAKU");
} while (rata < 6 || rata > 48);



Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("Wysokość Twojej miesięcznej raty to: ");
Console.Write("jakies gowno");
Console.ForegroundColor = ConsoleColor.White;

if (rata >= 6 && rata <= 12)
{
    Console.WriteLine(String.Format("{0:0.00}\n", (cena * 0.025 + cena) / rata));
}

else if (rata >= 13 && rata <= 24)
{
    Console.WriteLine(String.Format("{0:0.00}\n", (cena * 0.05 + cena) / rata));
}
else
{
    Console.WriteLine(String.Format("{0:0.00}\n", (cena * 0.1 + cena) / rata));
}

Console.WriteLine("Kurwa, Kaja, ale żeś Słonko zajebisty kod odjebała ;*");