using MVC_Intro.Entities;

namespace MVC_Intro.Data
{
	public class ProductRepository
	{
		private List<Product> _products = new List<Product>(){
			new Product() { ImgSrc = "product-img-1.jpg", Name = "Strawberry", Price = 85},
			new Product() { ImgSrc = "product-img-2.jpg", Name = "Berry", Price = 70},
			new Product() { ImgSrc = "product-img-3.jpg", Name = "Lemon", Price = 35},
			new Product() { ImgSrc = "product-img-4.jpg", Name = "Avocado", Price = 50},
			new Product() { ImgSrc = "product-img-5.jpg", Name = "Green Apple", Price = 45},
			new Product() { ImgSrc = "product-img-6.jpg", Name = "Strawberry", Price = 80},
		};

		public List<Product> GetProducts()
		{
			return _products;
		}
	}
}
