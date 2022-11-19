using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Modules.GoodsManager.API.Controllers;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class GoodsCategoryController : BaseApiController
{
    [HttpGet]
    public IEnumerable<string> GetCategories()
    {
        return new List<string>() { "1", "2"};
    }
    
    [HttpGet]
    [Route("{categoryId}")]
    public string GetCategory([FromRoute][Required] string categoryId)
    {
        var list = new List<string>() { "1", "2"};
        return list.FirstOrDefault(t => t == categoryId);
    }
}