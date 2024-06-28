using family.API.contract;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

List<familyMembers> family = [
    new("sergi", 14, "7 oqtomberi"),
    new("eqvtime", 10 ,"21 ianvari")
    ];

    

app.MapGet("/family", () => family);


app.Run();
