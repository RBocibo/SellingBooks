using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SellingBooks.Domain.Entities
{
    public class PriceOffer
    {
        [Key]
        public int PriceOfferId { get; set; }
        public decimal NewPrice { get; set; }
        public string PromotionalText { get; set; } = null!;

        [ForeignKey("BookId")]
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
