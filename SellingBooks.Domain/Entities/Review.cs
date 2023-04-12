using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SellingBooks.Domain.Entities
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public string VoterName { get; set; } = null!;
        public int NumStars { get; set; }
        public string Comment { get; set; } = null!;

        [ForeignKey("BookId")]
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
