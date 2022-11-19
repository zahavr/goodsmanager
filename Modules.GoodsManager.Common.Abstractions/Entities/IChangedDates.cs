namespace Modules.GoodsManager.Common.Entities;

public interface IChangedDates
{
    public DateTime UpdatedAt { get; }
    
    public DateTime CreatedAt { get; }

    public void UpdateDateTo(DateTime date);
}