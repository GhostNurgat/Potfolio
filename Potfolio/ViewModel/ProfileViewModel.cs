namespace DigitalPotfolio.ViewModel
{
    using System.ComponentModel.DataAnnotations;

    public class ProfileViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите Фамилию")]
        [Display(Name = "Фамилия")]
        public string? Surname { get; set; }

        [Required(ErrorMessage = "Введите Имя")]
        [Display(Name = "Имя")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Введите Отчество")]
        [Display(Name = "Отчество")]
        public string? Patronymic { get; set; }

        [Display(Name = "Контакты")]
        public string? Contacts { get; set; }

        [Display(Name = "Фото")]
        public string? Photo {  get; set; }

        [Display(Name = "Обо мне")]
        public string? AboutMe { get; set; }
    }
}
