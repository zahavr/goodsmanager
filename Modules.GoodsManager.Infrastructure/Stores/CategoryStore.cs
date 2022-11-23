using Modules.GoodsManager.Entities;
using Modules.GoodsManager.Infrastructure.Abstractions;

namespace Modules.GoodsManager.Infrastructure.Stores;

internal class CategoryStore : ICategoryStore
{
    // TODO: Implement realization
    public void AddManyAsync(IReadOnlyList<Category> categories)
    {
        throw new NotImplementedException();
    }

    public void AddAsync(Category category)
    {
        throw new NotImplementedException();
    }

    public void GetManyAsync()
    {
        throw new NotImplementedException();
    }

    public void GetSingleById(long categoryId)
    {
        throw new NotImplementedException();
    }
}