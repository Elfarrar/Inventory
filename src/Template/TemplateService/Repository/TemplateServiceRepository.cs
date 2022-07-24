using Repository;
using Repository.Context;

namespace TemplateService.Repository
{
    public class TemplateServiceRepository : Repository<Model.TemplateService>, ITemplateServiceRepository
    {
        public TemplateServiceRepository(ApplicationContext db) : base(db) { }
    }
}
