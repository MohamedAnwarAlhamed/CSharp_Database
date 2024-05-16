
using (var context = new AppDbContext())
{
    // delete wallet with id = 18
    var wallet = context.Wallets.Single(x => x.Id == 18);

    context.Wallets.Remove(wallet);

    context.SaveChanges();

}
Console.ReadKey();


