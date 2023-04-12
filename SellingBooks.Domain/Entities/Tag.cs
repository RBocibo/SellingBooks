using System.ComponentModel.DataAnnotations;

namespace SellingBooks.Domain.Entities
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }
    }
}
