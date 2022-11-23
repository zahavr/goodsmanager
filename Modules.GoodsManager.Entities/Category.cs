using JetBrains.Annotations;
using Modules.GoodsManager.Common.Entities;
using Validation;

namespace Modules.GoodsManager.Entities;

public class Category :
    IBaseEntity,
    IChangedDates
{
    public Category([NotNull] string name)
    {
        Requires.NotNullOrEmpty(name, nameof(name));
        
        Name = name;
    }
    
    public long Id { get; }
    
    public DateTime UpdatedAt { get; private set; }
    
    public DateTime CreatedAt { get; }
    
    [NotNull]
    public string Name { get; }
    
    public void UpdateDateTo(DateTime date)
    {
        UpdatedAt = date;
    }
}