using Microsoft.AspNetCore.Mvc;
//This using isn't used in this file: you can remove it
using System.Text.Json;
using Enitity;
using Service;
using Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers

{
    
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    
    {
        IUserService service;
        public UsersController(IUserService service)
        {
            this.service = service;
        }
        static string filePath = "users.txt";

        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Zehavi", "Rivka" };
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult< string > Get(int id)
        {
            User user = service.Get(id);    
            if(user==null)
                return NoContent();

            return Ok(user);
         
           
           
        }
        
        // POST api/<UsersController>
        [HttpPost]
        public ActionResult<User> Post([FromBody] User user)
        {
          //Where is the password check? The assignment asks that a weak password (score below 3) returns 400 and the user is not created: where is the password service called?
          service.Post(user);
            return CreatedAtAction(nameof(Get), new { id = user.id }, user);
        }

        [HttpPost("Login")]
        public ActionResult<User> Post([FromBody] LoginUser luser)
        {

            User user = service.Post(luser);
            if (user == null)
                return NoContent();

            return Ok(user);



        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        //The assignment asks PUT to return Ok(): change void to IActionResult and return Ok() at the end
        public void Put(int id ,[FromBody] User userToUpdate)
        {
            //Where is the password check before the update? The assignment asks that a weak password (score below 3) returns 400 and the user is not updated: where is the password service called?
            service.Put(id, userToUpdate);  
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
