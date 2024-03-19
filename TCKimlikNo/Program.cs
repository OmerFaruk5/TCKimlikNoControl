// See https://aka.ms/new-console-template for more information
long tckno = 15088377548;
if (tckno >= 10000000000 && tckno <= 99999999999)
{
    long B1, B2, B3, B4, B5, B6, B7, B8, B9;
    long testTck = tckno / 100;
    B9 = testTck % 10; testTck = testTck / 10;
    B8 = testTck % 10; testTck = testTck / 10;
    B7 = testTck % 10; testTck = testTck / 10;
    B6 = testTck % 10; testTck = testTck / 10;
    B5 = testTck % 10; testTck = testTck / 10;
    B4 = testTck % 10; testTck = testTck / 10;
    B3 = testTck % 10; testTck = testTck / 10;
    B2 = testTck % 10; testTck = testTck / 10;
    B1 = testTck % 10; testTck = testTck / 10;

    long S10 = (((B1 + B3 + B5 + B7 + B9) * 7) - (B2 + B4 + B6 + B8)) % 10;
    long S11 = (B1 + B2 + B3 + B4 + B5 + B6 + B7 + B8 + B9 + S10) % 10;
    Console.WriteLine(tckno % 100 + "==" + (S10 * 10 + S11));
    if (tckno % 100 == (S10 * 10 + S11))
    {
        Console.WriteLine(tckno + "uyumludur.");
    }
    else
    {
        Console.WriteLine(tckno + "uyumsuzdur.");
    }
}
else
{
    Console.WriteLine(tckno + "uyumsuzdur.Basamak sayısı 11 olmalıdır.");
}
