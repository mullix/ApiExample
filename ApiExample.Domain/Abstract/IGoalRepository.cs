using ApiExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiExample.Domain.Abstract
{
    public interface IGoalRepository
    {
        IQueryable<Goal> Goals { get; }
        void Create(Goal goal);
        void Update(Goal goal);
        void Delete(int id);
    }
}