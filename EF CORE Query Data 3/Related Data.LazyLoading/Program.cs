
using (var context = new AppDbContext())
{
    var sectionId = 1;

    var section = context.Sections
        .FirstOrDefault(x => x.Id == sectionId);

    foreach (var participant in section.Participants)
        Console.WriteLine($"[{participant.Id}] {participant.FName} {participant.LName}");

}

Console.ReadKey();



