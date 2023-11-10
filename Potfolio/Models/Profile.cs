namespace Potfolio.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Profile
    {
        [Key]
        public int ProfileId { get; set; }

        [Required]
        [ForeignKey("Id")]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Surname { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        [StringLength(100)]
        public string? Patronymic { get; set; }

        [StringLength(150)]
        public string? Contacts { get; set; }

        [StringLength(100)]
        public string? Photo {  get; set; }

        public string? AboutMe { get; set; }


        public User User { get; set; } = new User();
        public Resume Resume { get; set; } = new Resume();
    }
}
