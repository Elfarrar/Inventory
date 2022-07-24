using Category.Data;
using Repository;

namespace Category.Repository
{
    public class CategoryRepository : Repository<Model.Category>, ICategoryRepository
    {
        public CategoryRepository(CategoryContext db, IHttpContextAccessor userContext) : base(db, userContext) { }
    }
}
