const int pocetTipovanychCisel = 6;
const int pocetVyhernichCisel = 7;
int[] tipovanaCisla = new int[pocetTipovanychCisel];
int[] vyherneCisla = new int[pocetVyhernichCisel];
int uhodnutychCisel = 0;
bool opakovat = true;
Random random = new Random();
while (opakovat)
{
    for (int n = 0; n < pocetTipovanychCisel; n++)
    {
        tipovanaCisla[n] = 0;
    }
    for (int n = 0; n < pocetVyhernichCisel; n++)
    {
        vyherneCisla[n] = 0;
    }
    uhodnutychCisel = 0;
    for (int i = 0; i < pocetVyhernichCisel; i++)
    {
        vyherneCisla[i] = random.Next(1, 49);
        if (vyherneCisla.Contains(vyherneCisla[i]))
        {
            vyherneCisla[i] = random.Next(1, 49);
        }
    }

    Console.WriteLine("Sportka");
    Console.WriteLine("===============================");
    for (int i = 0; i < pocetTipovanychCisel; i++)
    {
        Console.Write("Zadej " + (i + 1) + ". číslo v rozsahu 1-49: ");
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

    if (uhodnutychCisel >= 3 && uhodnutychCisel <= 6)
    {
        Console.Clear();
        Console.WriteLine("Sportka\n============================================");
        Console.WriteLine("Tipovaná čísla: " + String.Join(", ", tipovanaCisla));
        Console.WriteLine("Výherní čísla: " + String.Join(", ", vyherneCisla));
        Console.WriteLine("\nUhodnul jsi " + uhodnutychCisel + "/6 čísel.\n");
        Console.WriteLine("Gratuluji, vyhrál jsi Sportku o 1 milión Kč!\n\nChceš hrát znova? (a/n): ");
        string odpoved = Console.ReadLine();
        string converted_odpoved = odpoved.ToUpper();
        if (converted_odpoved == "A")
        {
            opakovat = true;
            Console.WriteLine("Spouštím ti novou hru...");
            Console.Clear();
        }
        else if (converted_odpoved == "N")
        {
            opakovat = false;
            Console.WriteLine("Vypínám hru...");
            Console.Clear();
        }
    }
    else if (uhodnutychCisel <= 3 && uhodnutychCisel >= 0)
    {
        Console.Clear();
        Console.WriteLine("Sportka\n=====================");
        Console.WriteLine("Tipovaná čísla: " + String.Join(", ", tipovanaCisla));
        Console.WriteLine("Výherní čísla: " + String.Join(", ", vyherneCisla));
        Console.WriteLine("\nUhodnul jsi " + uhodnutychCisel + "/6 čísel.");
        Console.WriteLine("Bohužel, prohrál jsi.\n\nChceš hrát znova? (a/n): ");
        string odpoved = Console.ReadLine();
        string converted_odpoved = odpoved.ToUpper();
        if (converted_odpoved == "A")
        {
            opakovat = true;
            Console.WriteLine("Spouštím ti novou hru...");
            Console.Clear();
        }
        else if (converted_odpoved == "N")
        {
            opakovat = false;
            Console.WriteLine("Vypínám hru...");
            Console.Clear();
        }
    }
}