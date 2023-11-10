namespace Potfolio.Models
{
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser<int>
    {
        public Profile Profile { get; set; } = new Profile();
        public List<Portfolio> Portfolios {  get; set; } = new List<Portfolio>();
    }
}
