namespace News.Entities
{
	public class Category
	{
		public int CategoryID { get; set; }
		public string CategoryName { get; set; }
		public List<New> News { get; set; }
	}
}
