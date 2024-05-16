using (var context = new AppDbContext())
{
    var coursesOverviews = context.CourseOverviews.ToList();
    foreach (var courseOverview in coursesOverviews)
    {
        Console.WriteLine(courseOverview);
    }
}
Console.ReadKey();


