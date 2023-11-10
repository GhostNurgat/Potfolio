namespace Potfolio.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Portfolio
    {
        [Key]
        public int PortfolioId { get; set; }

        [StringLength(100)]
        public string? MainScreen {  get; set; }

        [Required]
        [StringLength(100)]
        public string? Title { get; set; }

        public string? Description { get; set; }

        [Required, StringLength(100)]
        public string? RepUrl { get; set; }

        [StringLength(100)]
        public string? FileName { get; set; }

        [Required]
        public int Id { get; set; }

        public User User { get; set; } = new User();
    }
}
