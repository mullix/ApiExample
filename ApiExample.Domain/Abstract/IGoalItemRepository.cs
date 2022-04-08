using ApiExample.Domain.Entities;
using System.Linq;

namespace ApiExample.Domain.Abstract
{
    public interface IGoalItemRepository
    {
        IQueryable<GoalItem> GoalItems { get; }
        void Create(GoalItem goalItem);
        void Update(GoalItem goalItem);
        void Delete(int id);
    }
}