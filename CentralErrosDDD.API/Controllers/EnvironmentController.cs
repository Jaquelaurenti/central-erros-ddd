using Microsoft.AspNetCore.Mvc;
using CentralErrosDDD.Application.Dtos;
using CentralErrosDDD.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace CentralErrosDDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EnvironmentController : ControllerBase
    {

        private readonly IApplicationServiceEnvironment applicationServiceEnvironment;


        public EnvironmentController(IApplicationServiceEnvironment applicationServiceEnvironment)
        {
            this.applicationServiceEnvironment = applicationServiceEnvironment;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceEnvironment.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceEnvironment.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] EnvironmentDTO env)
        {
            try
            {
                if (env == null)
                    return NotFound();

                applicationServiceEnvironment.Add(env);
                return Ok("Environment Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] EnvironmentDTO env)
        {
            try
            {
                if (env == null)
                    return NotFound();

                applicationServiceEnvironment.Update(env);
                return Ok("Environment Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] EnvironmentDTO env)
        {
            try
            {
                if (env == null)
                    return NotFound();

                applicationServiceEnvironment.Remove(env);
                return Ok("Environment Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}