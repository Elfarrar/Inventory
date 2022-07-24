using Microsoft.AspNetCore.Mvc;
using Model;
using Repository;
using System.Text.Json;

namespace Base.Controllers
{
    [ApiController]
    public abstract class BaseController<T> : MainController where T : Entity
    {
        private readonly IRepository<T> _db;
        public BaseController(IRepository<T> db)
        {
            _db = db;
        }

        [HttpGet]
        public virtual async Task<ActionResult> Index()
        {
            var result = await _db.Get(false);
            return CustomResponse(result);
        }

        [Route("details/{id}")]
        [HttpGet]
        public virtual async Task<ActionResult> Details(Guid id)
        {
            var result = await _db.GetById(id);
            return CustomResponse(result);
        }


        [Route("create")]
        [HttpPost]
        public virtual async Task<ActionResult> Create(T data)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            SerializeObject(data);

            var result = await _db.Create(data);

            return CustomResponse(data);
        }

        [Route("update")]
        [HttpPut]
        public virtual async Task<ActionResult> Update(T data)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            SerializeObject(data);

            var result = await _db.Update(data);

            return CustomResponse(data);
        }

        [Route("delete/{id}")]
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
