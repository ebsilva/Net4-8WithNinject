﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication3.Entities;

namespace WebApplication3.Interfaces
{
    public interface IRepository
    {
        List<People> ListPeople();
    }
}