namespace Fiorello.ViewModels.Product
{
    public class ProductDetailVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<ProductImageVM> ProductImages { get; set; }


    }
}