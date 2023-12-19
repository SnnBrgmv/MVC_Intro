namespace MVC_Intro.Entities
{
	public class Product
	{
		private static int _id=1;
		public Product(){
			Id = _id;
			_id++;
		}
		public int Id { get; set; }
		public string ImgSrc { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }

	}
}
