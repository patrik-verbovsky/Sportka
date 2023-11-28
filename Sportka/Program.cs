const int pocetTipovanychCisel = 7;
const int pocetVyhernichCisel = 7;
int[] tipovanaCisla = new int[pocetTipovanychCisel];
int[] vyherneCisla = new int[pocetVyhernichCisel];
int uhodnutychCisel = 0;
Random random = new Random();

for (int i = 0; i < pocetTipovanychCisel; i++)
{
    vyherneCisla[i] = random.Next(1, 49);
    if (vyherneCisla.Contains(vyherneCisla[i]))
    {
        vyherneCisla[i] = random.Next(1, 49);
    }
}

Console.WriteLine("Sportka");
Console.WriteLine("===============================");
for (int i = 0; i < pocetVyhernichCisel; i++)
{
    Console.Write("Zadej " + (i+1) + ". číslo v rozsahu 1-49: ");
    int cislo;
    bool cisloJeOk = false;
    while (!cisloJeOk)
    {
        if (int.TryParse(Console.ReadLine(), out cislo))
        {
            if (cislo >= 1 && cislo <= 49)
            {
                if (!tipovanaCisla.Contains(cislo))
                {
                    tipovanaCisla[i] = cislo;
                    cisloJeOk = true;
                }
                else
                {
                    Console.Write("\nČíslo se opakuje. Zadej znovu: ");
                }
            }
            else
            {
                Console.Write("\nČíslo je mimo rozsah. Zadej znovu: ");
            }
        }
        else
        {
            Console.Write("\nNezadal jsi číslo. Zadej znovu: ");
        }
    }
}

for (int i = 0; i < pocetTipovanychCisel; i++)
{
    if (vyherneCisla.Contains(tipovanaCisla[i]))
    {
        uhodnutychCisel++;
    }
}

if (uhodnutychCisel >= 3 && uhodnutychCisel <= 7)
{
    Console.Clear();
    Console.WriteLine("Sportka\n============================================");
    Console.WriteLine("Uhodnul jsi " + uhodnutychCisel + "/7 čísel.");
    Console.WriteLine("Gratuluji, vyhrál jsi Sportku o 1 milión Kč!\n\nPress any key to continue . . .");
    Console.ReadKey();
}
else if (uhodnutychCisel <= 3 && uhodnutychCisel >= 0)
{
    Console.Clear();
    Console.WriteLine("Sportka\n=====================");
    Console.WriteLine("Uhodnul jsi " + uhodnutychCisel + "/7 čísel.");
    Console.WriteLine("Bohužel, prohrál jsi.\n\nPress any key to conntinue . . .");
    Console.ReadKey();
}