using GameLauncher.Dal.MsSQL.Entities.Classification;
using GameLauncher.Dal.MsSQL.Entities.Game;

namespace GameLauncher.Dal.MsSQL.Entities.Connections;

public class GameClassificationEntity
{
    public ClassificationEntity Classification { get; set; } = new();
    public GameEntity Game { get; set; } = new();
    public long ClassificationId { get; set; }
    public long GameId { get; set; }

}
