using (var context = new AppDbContext())
{
    foreach (var section in context.Sections)
    {
        Console.WriteLine($"{section.Id}\t{section.SectionName}\t{section.DateRange}\t{section.TimeSlot}");
    }
}

Console.ReadKey();


