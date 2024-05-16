
using (var context = new AppDbContext())
{
    // Database will be created if it does not exist
    await context.Database.EnsureCreatedAsync();

    var sqlScript = context.Database.GenerateCreateScript();

    await Task.Delay(30000);

    // Database will be deleted if it does exist
    await context.Database.EnsureDeletedAsync();
}




