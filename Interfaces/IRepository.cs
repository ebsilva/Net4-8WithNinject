using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ebs.Entities;

namespace Ebs.Interfaces
{
    public interface IRepository
    {
        List<People> ListPeople();
    }
}
