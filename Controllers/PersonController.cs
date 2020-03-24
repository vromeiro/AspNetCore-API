using System;
using Microsoft.AspNetCore.Mvc;
using aspnet_api.Model;
using aspnet_api.Repository;

namespace aspnet_api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;
        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            try {
                var list = _personRepository.Get();
                return Ok(list);
            }
            catch (Exception e) {
                var callback = new
                {
                    message = "Could not finalize this request",
                    error = e.Message
                };
                return BadRequest(callback);
            }
        }

        [HttpGet("{guid}")]
        public IActionResult GetId(string guid)
        {
            try {
                var item = _personRepository.Get(guid);
                return Ok(item);
            }
            catch (Exception e) {
                var callback = new
                {
                    message = "Could not finalize this request",
                    error = e.Message
                };
                return BadRequest(callback);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Person person)
        {
            try {
                _personRepository.Post(person);
                var callback = new
                {
                    message = "Successfully"
                };
                return Ok(callback);
            } 
            catch (Exception e) {
                var callback = new
                {
                    message = "Could not finalize this request",
                    error = e.Message
                };
                return BadRequest(callback);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody]Person person)
        {
            try {
                _personRepository.Put(person);
                var callback = new
                {
                    message = "Successfully"
                };
                return Ok(callback);
            } 
            catch (Exception e) {
                var callback = new
                {
                    message = "Could not finalize this request",
                    error = e.Message
                };
                return BadRequest(callback);
            }
        }

        [HttpDelete("{guid}")]
        public IActionResult Delete(string guid)
        {
            try {
                _personRepository.Delete(guid);
                var callback = new
                {
                    message = "Successfully"
                };
                return Ok(callback);
            } 
            catch (Exception exception) {
                var callback = new
                {
                    message = "Could not finalize this request",
                    error = exception.Message
                };
                return BadRequest(callback);
            }
        }
    }
}