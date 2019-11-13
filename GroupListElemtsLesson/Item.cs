namespace GroupListElemtsLesson
{
	public class Item
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }

		public override string ToString()
		{
			return $"{Id} - {Name} - ${Price}";
		}
	}
}
