using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ebs.Entities;
using Ebs.Interfaces;

namespace Ebs.Data
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