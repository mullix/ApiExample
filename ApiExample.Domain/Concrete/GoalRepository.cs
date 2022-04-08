using ApiExample.Domain.Abstract;
using ApiExample.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ApiExample.Domain.Concrete
{
    public class GoalRepository : IGoalRepository
    {
        private ApplicationDbContext _context;

        public GoalRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Goal> Goals => _context.Goals;

        public void Create(Goal goal)
        {
            _context.Goals.Add(goal);
            try
            {
                _context.SaveChanges();
            }
            catch { throw; }
        }

        public void Delete(int id)
        {
            Goal goal = _context.Goals.FirstOrDefault(g => g.Id == id);

            if (goal == null)
            {
                throw new KeyNotFoundException($"Not found the goal with id = {id}");
            }

            _context.Goals.Remove(goal);

            try
            {
                _context.SaveChanges();
            }
            catch { throw; }
        }

        public void Update(Goal goal)
        {
            _context.Goals.Update(goal);

            try
            {
                _context.SaveChanges();
            }
            catch { throw; }
        }
    }
}