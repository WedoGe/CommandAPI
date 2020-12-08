using System.ComponentModel.DataAnnotations;

namespace CommandAPI.Models
{
    public class CommandItem
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Command { get; set; }
        [Required]
        [MaxLength(50)]
        public string HowTo { get; set; }
        [Required]
        public string Platform { get; set; }
    }
}