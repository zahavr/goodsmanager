using Modules.GoodsManager.Entities;

namespace Modules.GoodsManager.Infrastructure.Abstractions;

public interface ICategoryStore
{
    public void AddManyAsync(IReadOnlyList<Category> categories);

    public void AddAsync(Category category);

    // TODO: Implement filter.
    public void GetManyAsync();

    public void GetSingleById(long categoryId);
}