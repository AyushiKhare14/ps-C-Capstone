using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C_BookStoreBackEndAPI.Models
{
    [Table ("genres")]
    public class Genre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        [MaxLength(20)]
        public string GenreName { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book> ();

        public Genre() { }
        public Genre(string gname)
        {
            GenreName = gname.ToUpper();
        }

    }
}
