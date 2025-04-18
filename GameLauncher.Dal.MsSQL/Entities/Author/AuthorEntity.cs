using CSharpFunctionalExtensions;
using GameLauncher.Dal.MsSQL.Entities.Game;

namespace GameLauncher.Dal.MsSQL.Entities.Author;

public class AuthorEntity: Entity
{
    public string Name { get; set; } = string.Empty;
    public List<GameEntity> Games { get; set; } = new List<GameEntity>();
}
