using System;
using System.Collections.Generic;

namespace ApiExample.Domain.Entities
{
    public class Goal
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int Status { get; set; }

        public List<GoalItem> GoalItems { get; set; }
    }
}