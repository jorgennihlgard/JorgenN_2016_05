using System.ComponentModel.DataAnnotations;
using System.Data;

namespace JorgenN.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required,Display(Name = "Product Name")]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public string ProductText { get; set; }
        [Required, Custom,MaxLength(5, ErrorMessage = "Måste vara 5 tecken"),MinLength(5, ErrorMessage = "Måste vara 5 tecken")]
        public string ProductNumber { get; set; }
        [Required,Range(1,1000)]
        public double Price { get; set; }
        [Required,Range(1,1000)]
        public int ProductInStock { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }

    }
}