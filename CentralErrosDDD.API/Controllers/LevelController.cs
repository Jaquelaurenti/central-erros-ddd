using Microsoft.AspNetCore.Mvc;
using CentralErrosDDD.Application.Dtos;
using CentralErrosDDD.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace CentralErrosDDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LevelController : ControllerBase
    {

        private readonly IApplicationServiceLevel applicationServiceLevel;


        public LevelController(IApplicationServiceLevel applicationServiceLevel)
        {
            this.applicationServiceLevel = applicationServiceLevel;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceLevel.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceLevel.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] LevelDTO level)
        {
            try
            {
                if (level == null)
                    return NotFound();

                applicationServiceLevel.Add(level);
                return Ok("Level Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] LevelDTO level)
        {
            try
            {
                if (level == null)
                    return NotFound();

                applicationServiceLevel.Update(level);
                return Ok("Level Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] LevelDTO level)
        {
            try
            {
                if (level == null)
                    return NotFound();

                applicationServiceLevel.Remove(level);
                return Ok("Level Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}