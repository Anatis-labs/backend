using Backend.Entities;
using Backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("CORSPolicy")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        //public IEnumerable<string> Get()
        [HttpGet]
        public IEnumerable<User> Get()
        {
            using (var context = new ApplicationDbContext())
            {
                var users = context.Users.Include(a => a.userseminars).ToArray();
                return users;
            }
        }

        [HttpGet("{id}")]
        public IEnumerable<User> GetQuery([FromQuery] int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Users;
            }
        }

        // fetches User based on id in url
        [HttpGet("{id}")]
        public User Get(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var User = context.Users.Where(o => o.id == id).FirstOrDefault();
                if (User != null)
                    return User;
                else
                    return null;
            }
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] UserViewModel UserVM)
        {
            using (var context = new ApplicationDbContext())
            {
                var user = new User { Name = UserVM.Name, Description = UserVM.Description };
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
                var user = new User { id = id };
                context.Users.Attach(user);
                context.Users.Remove(user);
                context.SaveChanges();             
            }
        }
    }
}