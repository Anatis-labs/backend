using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("CORSPolicy")]
    [ApiController]

    public class UserSeminarController : ControllerBase
    {
        // GET: api/<UserSeminarController>
        [HttpGet]
        public IEnumerable<UserSeminar> Get()
        {
            using (var context = new ApplicationDbContext())
            {
                var userseminars = context.userSeminars;
                return userseminars;
            }
        }

        // GET api/<UserSeminarController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        public class JSONPostRequest
        {
            public string name { get; set; }
            public string email { get; set; }
            public int seminarId { get; set; }
        }

        // POST api/<UserSeminarController>
        [HttpPost]
        public void Post([FromBody] JSONPostRequest userseminar)
        {
            string name = userseminar.name;
            string email = userseminar.email;
            int seminarId = userseminar.seminarId;
            

            var context = new ApplicationDbContext();
            var user = new User { Name = name, Email = email };
            var matchingUser = context.Users.ToList().Find(x => x.Name == name && x.Email == email);

            if (matchingUser == null)
            {              
                context.Users.Add(user);            
                context.SaveChanges();
                var addedUser = context.Users.ToList().Find(x => x.Name == name && x.Email == email);
                var userSeminar = new UserSeminar { seminarId = seminarId, userId = addedUser.id };
                context.userSeminars.Add(userSeminar);
                context.SaveChanges();
            }
            else
            {
                var userSeminar = new UserSeminar { seminarId = seminarId, userId = matchingUser.id};
                context.userSeminars.Add(userSeminar);
                context.SaveChanges();             
            }
        }







        //public void Post([FromBody] UserSeminarViewModel UserSeminarVM)
        //{
        //    using (var context = new ApplicationDbContext())
        //    {
        //        var userseminar = new UserSeminar { seminarId = UserSeminarVM.seminarId, userId = UserSeminarVM.userId };
        //        context.userSeminars.Add(userseminar);
        //        context.SaveChanges();
        //    }
        //}



        //public IEnumerable<UserSeminar> Post([FromBody] JSONPostRequest userJson)
        //{
        //    string name = userJson.name;
        //    string email = userJson.email;
        //    int seminarid = userJson.seminarid;

        //    var context = new ApplicationDbContext();
        //    var matchingStudent = context.Users.ToList().Find(x => x.Name == name && x.Email == email);
        //    if (matchingStudent == null)
        //    {
        //        var user = new User { Name = name, Email = email };
        //        context.Users.Add(user);
        //        context.SaveChanges();
        //        return Post(name, email, seminarid);
        //    }
        //    else
        //    {
        //        var userSeminar = new UserSeminar { seminarId = seminarid, userId = matchingStudent.id };
        //        context.userSeminars.Add(userSeminar);
        //        context.SaveChanges();
        //        return matchingStudent.ToString();
        //    }
        //}

        // PUT api/<UserSeminarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserSeminarController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
