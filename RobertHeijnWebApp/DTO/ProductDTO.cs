using BusinessLogic.Entities;

namespace RobertHeijnWebApp.DTO
{
    public class ProductDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }
        public Category SubCategory { get; set; }
        public ProductDTO()
        {

        }

        public ProductDTO(int id,string name, decimal price, string unit)
        {
            ID = id;
            Name = name;
            Price = price;
            Unit = unit;
        }
        public ProductDTO(int id)
        {
            ID=id;
        }
    }
}
