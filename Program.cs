using GameStore.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameDto> games = [
    new GameDto(1, 
                "The Legend of Zelda: Breath of the Wild", 
                "Action-Adventure", 
                1845.30m, 
                new DateOnly(2017, 3, 3)),
    new GameDto(2, 
                "Until Then", 
                "Adventure, Visual Novel", 
                615.00m, 
                new DateOnly(2024, 6, 25)),
    new GameDto(3, 
                "Sekiro: Shadows Die Twice", 
                "Action-Adventure", 
                1230.09m, 
                new DateOnly(2019, 3, 22)),
    new GameDto(4, 
                "God of War", 
                "Action", 
                1537.70m, 
                new DateOnly(2018, 4, 20)),
    new GameDto(5, 
                "Miside", 
                "Indie", 
                461.09m, 
                new DateOnly(2023, 11, 10))

];

// GET /games
app.MapGet("games", () => games);

// GET /games/1
app.MapGet("games/{id}", (int id) => games.Find(game => game.Id == id));

app.Run();
