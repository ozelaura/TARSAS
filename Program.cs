List<string> osvenyek = new List<string>();
StreamReader srOsvenyek = null;
try
{
    srOsvenyek = new StreamReader("osvenyek.txt");
    string adat;
    while ((adat = srOsvenyek.ReadLine()) != null)
    {
        osvenyek.Add(adat);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Hiba történt az ösvények fájl olvasása közben: {ex.Message}");
}
finally
{
    if (srOsvenyek != null)
    {
        srOsvenyek.Close();
    }
}

List<int> dobasok = new List<int>();
StreamReader srDobasok = null;
try
{
    srDobasok = new StreamReader("dobasok.txt");
    string adat = srDobasok.ReadLine();
    dobasok = adat.Split().Select(int.Parse).ToList();
}
catch (Exception ex)
{
    Console.WriteLine($"Hiba történt a dobások fájl olvasása közben: {ex.Message}");
}
finally
{
    if (srDobasok != null)
    {
        srDobasok.Close();
    }
}

Console.WriteLine();
Console.WriteLine("2. feladat");
Console.WriteLine($"A dobások száma: {dobasok.Count}");
Console.WriteLine($"Az ösvények száma: {osvenyek.Count}");
Console.WriteLine();
Console.WriteLine("3. feladat");
int osvenyHossz = 0;
for (int i = 1; i < osvenyek.Count; i++)
{
    if (osvenyek[i].Length > osvenyek[osvenyHossz].Length)
    {
        osvenyHossz = i;
    }
}
Console.WriteLine($"Az egyik leghosszabb a {osvenyHossz + 1}. ösvény, hossza: {osvenyek[osvenyHossz].Length}");
Console.WriteLine();
Console.WriteLine("4. feladat");
Console.Write("Adja meg egy ösvény sorszámát: ");
int oszvenySzama = int.Parse(Console.ReadLine());
Console.Write("Adja meg a játékosok számát: ");
int jatekosSzama = int.Parse(Console.ReadLine());
string osveny = osvenyek[oszvenySzama - 1];
Console.WriteLine();
Console.WriteLine("5. feladat");
Dictionary<char, int> statisztika = new Dictionary<char, int>();
foreach (char betu in osveny)
{
    if (!statisztika.ContainsKey(betu))
    {
        statisztika[betu] = 0;
    }
    statisztika[betu]++;
}

foreach (var betukSzama in statisztika)
{
    Console.WriteLine($"{betukSzama.Key}: {betukSzama.Value} darab");
}

