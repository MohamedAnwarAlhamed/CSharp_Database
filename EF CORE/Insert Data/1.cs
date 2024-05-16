
var wallet = new Wallet
{
    Holder = "Salah",
    Balance = 1200m
};

using (var context = new AppDbContext())
{
    context.Wallets.Add(wallet);
    context.SaveChanges();
}

Console.ReadKey();


