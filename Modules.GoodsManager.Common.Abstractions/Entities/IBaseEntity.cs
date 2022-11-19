using JetBrains.Annotations;

namespace Modules.GoodsManager.Common.Entities;

public interface IBaseEntity
{
    [NonNegativeValue]
    public long Id { get; }
}