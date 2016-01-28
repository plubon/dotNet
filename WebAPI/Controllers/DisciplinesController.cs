using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Model.Enitites;
using Repository;

namespace WebAPI.Controllers
{
    [EnableCors(origins: "http://digitalathletics.azurewebsites.net , http://localhost:17197", headers: "*", methods: "*")]
    [RoutePrefix("api/disciplines")]
    public class DisciplinesController : ApiController
    {
        readonly DisciplineRepository _repository = new DisciplineRepository();

        [Route("")]
        public IEnumerable<Discipline> GetAllDisciplines()
        {
            return _repository.GetAll();
        }

        [Route("{id:int}")]
        public IHttpActionResult GetDiscipline(int id)
        {
            var discipline = _repository.GetById(id);
            if (discipline == null)
            {
                return NotFound();
            }
            return Ok(discipline);
        }
    }
}
