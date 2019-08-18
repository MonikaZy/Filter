using System;
namespace Filter.Domain.Models
{
    public class CategoryItem
    {
        public CategoryItem()
        {
        }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
        public string[] platforms { get; set; }
        public string campaign { get; set; }
        public string content { get; set; }
    }

    // public string jsonCategory = JsonConvert.SerializeObject(platforms);
    // Product deserializedProduct = JsonConvert.DeserializeObject<Product>(jsonCategory);
}
