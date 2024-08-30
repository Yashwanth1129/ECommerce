using System.ComponentModel.DataAnnotations;

namespace ECommerce.API.Models.Domain
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
