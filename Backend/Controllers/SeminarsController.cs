﻿using System;
using System.Collections.Generic;
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
    public class SeminarsController : ControllerBase
    {
        // GET: api/<SeminarsController>
        [HttpGet]
        public IEnumerable<Seminar> Get()
        {
            using (var context = new ApplicationDbContext())
            {
                var seminars = context.Seminars.Include(s => s.userseminar).ToArray();
                return seminars;
            }
        }


        public IEnumerable<Seminar> GetQuery([FromQuery] int id = -1)
        {
            using (var context = new ApplicationDbContext())
            {
                           
                return context.Seminars;
            }
        }

            // GET api/<SeminarsController>/5
            [HttpGet("{id}")]
        public string Get(int id)
        {

            return "value";
        }

        // POST api/<SeminarsController>
        [HttpPost]
        public void Post([FromBody] SeminarViewModel SeminarVM)
        {
            using (var context = new ApplicationDbContext())
            {
                var seminar = new Seminar { Title = SeminarVM.Title, Description = SeminarVM.Description };
                context.Seminars.Add(seminar);
                context.SaveChanges();
            }
        }

        // PUT api/<SeminarsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SeminarsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var seminars = new Seminar { id = id };
                context.Seminars.Attach(seminars);
                context.Seminars.Remove(seminars);
                context.SaveChanges();
            }
        }
    }
}
