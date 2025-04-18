using CSharpFunctionalExtensions;
using GameLauncher.Dal.MsSQL.Entities.Author;
using GameLauncher.Dal.MsSQL.Entities.Connections;
using GameLauncher.Dal.MsSQL.Entities.GameInfo;

namespace GameLauncher.Dal.MsSQL.Entities.Game;

public class GameEntity: Entity
{
    public string Name { get; set; } = string.Empty;
    public string Rating { get; set; } = string.Empty; 
    public decimal Cost { get; set; }
    public GameInfoEntity Info { get; set; } = new();
    public AuthorEntity Author { get; set; } = new();
    public List<GameClassificationEntity> Classification { get; } = new();
}
