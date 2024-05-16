
var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

IDbConnection db = new SqlConnection(configuration.GetSection("constr").Value);

var walletToInsert = new Wallet { Holder = "Sarah", Balance = 10000m };

var sql = "INSERT INTO Wallets (Holder, Balance) " +
          "VALUES (@Holder, @Balance)";

db.Execute(sql,
    new
    {
        Holder = walletToInsert.Holder,
        Balance = walletToInsert.Balance
    });

Console.ReadKey();


