using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController: ControllerBase
    {
        private readonly IPersonFacade _personFacade;
        public PersonController(IPersonFacade personFacade)
        {
            _personFacade = personFacade;
        }

        [HttpGet]
        public ActionResult<PersonResponse> GetPersons()
        {
            try
            {
                return _personFacade.GetAllPersons(); //fazer os includes. Ao clicar nela, haverá um botao para exibir so os phones, editar, etc
            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("Phones/{personId}")]
        public ActionResult<PersonPhoneResponse> GetPersonPhones(int personId)
        {
            try
            {
                return _personFacade.GetPersonPhones(personId);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
