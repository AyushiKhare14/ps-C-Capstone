using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C_BookStoreBackEndAPI.Models
{
    [Table("books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        [MaxLength(30)]
        public string Title { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateOnly PublicationDate { get; set; }

        [ForeignKey("GenreId")]
        public Genre? Genre { get; set; }

        public int GenreId { get; set; }

        [ForeignKey("AuthorId")]

        public Author? Author { get; set; }

        public int AuthorId { get; set; }

        public Book() {}

        public Book(string bname, decimal pri, DateOnly pubDate)
        {
            Title = bname.ToUpper();
            Price = pri;
            PublicationDate = pubDate;
        }
    }
}
