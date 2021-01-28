using System.Collections.Generic;
using Ebs.Entities;

namespace Ebs.Interfaces
{
    public interface IRepository
    {
        List<People> ListPeople();
    }
}
