using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C_BookStoreBackEndAPI.Models
{
    [Table("authors")]
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("AuthorName")]
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Column("Biography")]
        [Required]
        [MaxLength(256)]
        public string Biography { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();

        // Parameterless constructor required by EF Core
        public Author() { }

        // Your custom constructor
        public Author(string aname, string bio)
        {
            Name = aname.ToUpper();
            Biography = bio;
        }
    }
}

