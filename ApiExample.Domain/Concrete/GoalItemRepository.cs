using ApiExample.Domain.Abstract;
using ApiExample.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ApiExample.Domain.Concrete
{
    public class GoalItemRepository : IGoalItemRepository
    {
        private ApplicationDbContext _context;

        public GoalItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<GoalItem> GoalItems => _context.GoalItems;

        public void Create(GoalItem goalItem)
        {
            _context.GoalItems.Add(goalItem);

            try
            {
                _context.SaveChanges();
            }
            catch { throw; }
        }

        public void Delete(int id)
        {
            GoalItem goalItem = _context.GoalItems.FirstOrDefault(g => g.Id == id);

            if (goalItem == null)
            {
                throw new KeyNotFoundException($"Not found the GoalItrem with Id = {id}");
            }

            _context.Remove(goalItem);

            try
            {
                _context.SaveChanges();
            }
            catch { throw; }
        }

        public void Update(GoalItem goalItem)
        {
            _context.GoalItems.Update(goalItem);

            try
            {
                _context.SaveChanges();
            }
            catch { throw; }
        }
    }
}