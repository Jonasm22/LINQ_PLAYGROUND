namespace LINQ_PLAYGR_SUBQUERY;

class Program
{
    static void Main(string[] args)
    {
        List<Course> courses = new List<Course>()
        {
            new Course
            {
                Id = "EN-prog 001",
                Title = "C# Scencial",
                Description = "Increase your Level to Professional",
                Duration = 1000,
                Level = 1,

            },
            new Course
            {
                Id = "EN-prog 002",
                Title = "C# Avanced 2",
                Description = "Increase your Level to Professional 2",
                Duration = 2000,
                Level = 2,

            },
            new Course
            {
                Id = "EN-prog 003",
                Title = "Big Data",
                Description = "Increase your Level to Professional in Big Data",
                Duration = 3000,
                Level = 3,

            },
            new Course
            {
                Id = "EN-prog 004",
                Title = "Machine Learning",
                Description = "Increase your Level to Professional in Machine Learning",
                Duration = 4000,
                Level = 4,

            },
            new Course
            {
                Id = "EN-prog 005",
                Title = "Java OOP",
                Description = "Increase your Level to Professional ",
                Duration = 5000,
                Level = 5,
            }
            
        };

        var courseFilter = courses.Where(c => c.Duration < 3000 && c.Title.Contains("C#"))
            .OrderBy(c => c.Level)
            .Select(c => new
            {
                title = c.Title,
                level = c.Level,
                tiempo = c.Duration
                
            });
        
        courseFilter.ToList().ForEach(c=> Console.WriteLine($"Titel: {c.title} \nLevel: {c.level} \nTime: {c.tiempo}\n"));
        
        


    }
    
}