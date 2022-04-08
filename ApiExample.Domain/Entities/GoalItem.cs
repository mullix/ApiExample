namespace ApiExample.Domain.Entities
{
    public class GoalItem
    {		
		public int Id { get; set; }
		
		public string Name { get; set; }
		
		public string Description { get; set; }
		
		public string Value { get; set; }
	
		public int GoalId { get; set; }
		public Goal Goal { get; set; }
	}
}