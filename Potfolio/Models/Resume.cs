namespace Potfolio.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Resume
    {
        [Key]
        public int ResumeId { get; set; }

        [Required]
        public int ProfileId { get; set; }

        [Required]
        public string? Education { get; set; }

        [Required]
        public string? Awards { get; set; }

        [Required]
        public string? Jobs { get; set; }


        public Profile Profile { get; set; } = new Profile();
    }
}
