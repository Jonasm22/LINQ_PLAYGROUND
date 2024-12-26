namespace LINQ_PLAYGROUND;

class Program
{
    static void Main(string[] args)
    {
       var EuCountries = new List<string>{"Spain", "Portugal", "Germany" ,"Italy" , "Sweeden"};
       var EuCountryLinq = EuCountries.Where(p => p.Length>6);
       
       Console.WriteLine("Sintaxis basada en methodos");
       EuCountryLinq.ToList().ForEach(p => Console.WriteLine(p));
       var EuCountryLinqB  = 
           from p in EuCountries
           where p.Length>6 
           select p;
       Console.WriteLine("Sintaxis basada en Consultas");
       EuCountryLinqB.ToList().ForEach(p => Console.WriteLine(p));
       
               
       
       
    }
}