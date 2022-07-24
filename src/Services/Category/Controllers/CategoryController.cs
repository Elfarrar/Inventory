using BaseAPI.Controllers;
using Category.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Category.Controllers
{
    [ApiController]
    [Route("Category")]
    public class CategoryController : BaseController<Model.Category>
    {
        public CategoryController(ICategoryRepository repository) : base(repository) { }
    }
}
