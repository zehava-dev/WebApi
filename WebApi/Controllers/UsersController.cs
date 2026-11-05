using Microsoft.AspNetCore.Mvc;
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
        UserService service = new Service.UserService();
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
        public void Put(int id ,[FromBody] User userToUpdate)
        {
            service.Put(id, userToUpdate);  
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
