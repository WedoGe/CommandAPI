using System.ComponentModel.DataAnnotations;

namespace CommandAPI.Mmodels
{
    public class Command
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string HowTo { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        public string Platform { get; set; }
    }
}