using CSharpFunctionalExtensions;
using GameLauncher.Dal.MsSQL.Entities.Game;

namespace GameLauncher.Dal.MsSQL.Entities.GameInfo;

public class GameInfoEntity : Entity
{
    public string Description { get; set; } = string.Empty;
    public string SystemRequirements { get; set; } = string.Empty;
    public GameEntity Game { get; set; } = new();
}
