using MVC_Intro.Data;
using MVC_Intro.Entities;

namespace MVC_Intro.Models
{
	public class ShopIndexVM
	{
		public int ID { get; set; }
		public string ImgSrc { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public List<Product> Products { get; set; } = new List<Product>();

		public ShopIndexVM()
		{
			ProductRepository productRepository = new ProductRepository();
			Products.AddRange(productRepository.GetProducts());
		}

		
	}

}
