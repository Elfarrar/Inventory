using BaseAPI.Configuration.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model;
using Repository;
using System.Text.Json;

namespace BaseAPI.Controllers
{
    [ApiController]
    public abstract class BaseController<T> : MainController where T : Entity
    {
        private readonly IRepository<T> _db;
        
        public BaseController(IRepository<T> db)
        {
            _db = db;
        }

        [AllowAnonymous]
        [HttpGet]
        public virtual async Task<ActionResult> Index()
        {
            var result = await _db.Get(false);
            return CustomResponse(result);
        }

        [Route("details/{id}")]
        [ClaimsAuthorize("CRUD", "Read")]
        [HttpGet]
        public virtual async Task<ActionResult> Details(Guid id)
        {
            var result = await _db.GetById(id);
            return CustomResponse(result);
        }


        [Route("create")]
        [ClaimsAuthorize("CRUD", "Create")]
        [HttpPost]
        public virtual async Task<ActionResult> Create(T data)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            SerializeObject(data);

            var result = await _db.Create(data);

            return CustomResponse(data);
        }

        [Route("update")]
        [ClaimsAuthorize("CRUD", "Update")]
        [HttpPut]
        public virtual async Task<ActionResult> Update(T data)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            SerializeObject(data);

            var result = await _db.Update(data);

            return CustomResponse(data);
        }

        [Route("delete/{id}")]
        [ClaimsAuthorize("CRUD", "Delete")]
        [HttpDelete]
        public virtual async Task<ActionResult> Delete(Guid id)
        {
            var data = await _db.GetById(id);
            data.IsDeleted = true;

            SerializeObject(data);

            var deleted = await _db.Delete(data);


            return CustomResponse(true);
        }

        private void SerializeObject(T data)
        {
            data.SerializedObject = JsonSerializer.Serialize(data);
        }
    }
}
