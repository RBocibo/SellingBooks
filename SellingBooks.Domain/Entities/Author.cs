using System.ComponentModel.DataAnnotations;

namespace SellingBooks.Domain.Entities
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; } = null!;
    }
}
