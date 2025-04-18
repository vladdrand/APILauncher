using CSharpFunctionalExtensions;
using GameLauncher.Dal.MsSQL.Entities.Connections;

namespace GameLauncher.Dal.MsSQL.Entities.Classification;

public class ClassificationEntity: Entity
{
    public string Name { get; set; } = string.Empty;
    public List<GameClassificationEntity> Games { get; set; } = new List<GameClassificationEntity>();
}
