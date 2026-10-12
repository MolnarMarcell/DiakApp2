using DiakApp;

List<Diak> diak = new List<Diak>();
int hibasSorokSzama = 0;

var sorok = File.ReadAllLines(
    @"C:\Users\13d\Documents\MolnarMarcell\asztalialkalmazas\DiakApp\bin\debug\net10.0\eredmenyek.csv"
);

foreach (var sor in sorok.Skip(1))
{
    if (string.IsNullOrWhiteSpace(sor))
    {
        continue;
    }

    string[] elemek = sor.Split(';');

    if (elemek.Length != 3)
    {
        hibasSorokSzama++;
        continue;
    }


    if (string.IsNullOrWhiteSpace(elemek[0]) ||
        string.IsNullOrWhiteSpace(elemek[1]))
    {
        hibasSorokSzama++;
        continue;
    }


    if (!int.TryParse(elemek[2], out int pontszam))
    {
        hibasSorokSzama++;
        continue;
    }

    Diak diakPeldany = new Diak(elemek[0].Trim(),elemek[1].Trim(), pontszam);

    diak.Add(diakPeldany);
}

Console.WriteLine($"Sikeresen beolvasott diákok: {diak.Count}");
Console.WriteLine($"Hibás sorok száma: {hibasSorokSzama}");

foreach (Diak tanulo in diak)
{
    Console.WriteLine(tanulo.toString());
}