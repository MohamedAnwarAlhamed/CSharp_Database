
using (var context = new AppDbContext())
{
    foreach (var wallet in context.Wallets)
    {
        Console.WriteLine(wallet);
    }
}

Console.ReadKey();


