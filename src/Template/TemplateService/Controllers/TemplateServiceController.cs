using BaseAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using TemplateService.Repository;

namespace TemplateService.Controllers
{
    [ApiController]
    [Route("TemplateService")]
    public class TemplateServiceController : BaseController<Model.TemplateService>
    {
        public TemplateServiceController(ITemplateServiceRepository repository) : base(repository) { }
    }
}
