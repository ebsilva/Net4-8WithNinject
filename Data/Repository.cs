using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Entities;
using WebApplication3.Interfaces;

namespace WebApplication3.Data
{
    public class Repository : IRepository
    {
        private List<People> people = new List<People>();
        

        public Repository()
        {
            people.Add(new People { Id = 1, Nome = "Edson" });
            people.Add(new People { Id = 2, Nome = "Rai" });
            people.Add(new People { Id = 3, Nome = "Rafael" });
        }

        public List<People> ListPeople()
        {
            return people;
        }
    }
}