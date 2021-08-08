using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CineMania.Models
{
    public class Movie : IEnumerable
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage="Description should not exceed 200 characters")]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Release Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string ImageName { get; set; }
        [Required]
        public string Genre { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}