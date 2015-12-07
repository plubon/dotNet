using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model.Enitites;
using Repository;

namespace WebAPI.Controllers
{
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
