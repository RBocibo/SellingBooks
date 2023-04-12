using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SellingBooks.Domain.Entities
{
    public class BookAuthor
    {
        [Key]
        [ForeignKey("BookId")]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [Key]
        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
