namespace LINQ_PLAYGR_2;

class Program
{
    static void Main(string[] args)
    {
        var EuCountries = new List<string>{"Spain", "Portugal", "Germany" ,"Italy" , "Norway", "Netherlands", "Lithuania"};
        var EuCountryLarge = EuCountries.Where(p => p.Length > 6).OrderBy(p => p);
        Print("EU COUNTRIES ORDER BY: " , EuCountryLarge);      
        
        // Country with more characters :

        Console.ForegroundColor = ConsoleColor.Green;
        var EuCountryLength = EuCountries.Where(p => p.Length > 6)
            .OrderByDescending(p => p.Length).First();
        Console.WriteLine("Country with more characters: " + EuCountryLength);

        
        var EUcountryB =
            
        from p in EuCountries
        where p.Length > 6
        orderby p
        select p;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Print("Country Orden by - query : " , EUcountryB);
        Console.ResetColor();
    }


    static void Print(string Titel, IEnumerable<string> ie)
    {
        Console.WriteLine(Titel);
        ie.ToList().ForEach(p=>Console.WriteLine(p));
    }
}