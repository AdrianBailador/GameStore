using GameStore.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameDto> games = [
    new (
    1,
    "Tekken",
    "Fighting",
    19.99M,
    new DateOnly(1992,7,15)),
       new (
    2,
    "Gran Turismo",
    "Driver",
    49.99M,
    new DateOnly(1996,9,15)),

];

app.MapGet("games", () => games);

app.MapGet("/", () => "Hello World!, Hola Adri");

app.Run();
