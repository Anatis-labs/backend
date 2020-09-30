using Backend.Entities;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        //public IEnumerable<string> Get()
        public IEnumerable<string> GetQuery([FromQuery] int id = -1)
        {
            using (var context = new ApplicationDbContext())
            {
                var users = context.Set<User>();
                var result = new List<String>();
                foreach (var user in users)
                {
                    if (id == -1 || (id != -1 && id == user.id))
                    {
                        result.Add(user.Name, user);
                    }
                }
                return result;
            }

            /*using (var context = new ApplicationDbContext())
            {
                var users = context.Set<User>();
                var result = new List<String>();
                foreach (var user in users)
                {
                    result.Add(user.Name);
                }
                return result;
            }*/
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var users = context.Set<User>();
                var result = new List<String>();
                foreach (var user in users)
                {
                    if (user.id == id)
                    {
                        result.Add(user.Name);
                    }
                }
            }
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] UserViewModel UserVM)
        {
            using (var context = new ApplicationDbContext())
            {
                var user = new User { Name = UserVM.Name, description = UserVM.description };
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public void Post2([FromBody] UserViewModel UserVM)
        {

        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Users.Remove(context.Users.FirstOrDefault(u => u.id == id));
                context.SaveChanges();
            }

            /*using (var context = new ApplicationDbContext())
            {
                var user = context.Users
                .Where(u => u.id == id)
                .FirstOrDefault();

                context.Entry(user).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }*/
        }
    }
}