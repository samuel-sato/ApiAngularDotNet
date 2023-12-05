using Microsoft.AspNetCore.Mvc;
using Model;
using Services;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly PersonService _service;
        public PersonController()
        {
            _service = new PersonService();
        }

        [HttpGet]
        public ActionResult <List<PersonModel>> Get()
        {
            return _service.ListAll();
        }

        [HttpGet("{id}")]
        public ActionResult<PersonModel> GetById(Guid id)
        {
            var person = _service.FindById(id);

            if (person == null)
                return NotFound();

            return person;
        }


        [HttpPost]
        public IActionResult Create(PersonModel personModel)
        {
            _service.Add(personModel);
            return CreatedAtAction(nameof(Get), new { Id = personModel.Id }, personModel);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var person = _service.FindById(id);

            if (person == null)
                return NotFound();

            _service.Delete(id);

            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, PersonModel person)
        {
            if (id != person.Id)
                return BadRequest();

            var personModel = _service.FindById(id);
            if (personModel is null)
                return NotFound();

            _service.Update(person);

            return NoContent();
        }
    }
}
