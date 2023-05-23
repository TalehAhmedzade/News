namespace News.Entities
{
	public class New
	{
		public int NewID { get; set; }
		public string NewName { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
	}
}
