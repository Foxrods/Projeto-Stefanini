using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonPhoneController: ControllerBase
    {
        private readonly IPersonPhoneFacade _personPhoneFacade;
        public PersonPhoneController(IPersonPhoneFacade personPhoneFacade)
        {
            _personPhoneFacade = personPhoneFacade;
        }

        [HttpPost]
        public IActionResult InsertPersonPhone([FromBody] PersonPhoneRequest personPhone)
        {
            try
            {
                _personPhoneFacade.InsertPersonPhone(personPhone);
                return Ok(new { mensagem = "Inserido com sucesso" });
            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut]
        public IActionResult EditPersonPhone([FromBody] PersonPhoneRequest personPhone)
        {
            try
            {
                _personPhoneFacade.EditPersonPhone(personPhone);
                return Ok(new { mensagem = "Editado com sucesso" });
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePersonPhone(int id)
        {
            try
            {
                _personPhoneFacade.DeletePersonPhone(id);
                return Ok(new { mensagem = "Deletado com sucesso" });
            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
            
        }
    }
}
