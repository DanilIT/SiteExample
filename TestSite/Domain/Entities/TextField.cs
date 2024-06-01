using System.ComponentModel.DataAnnotations;

namespace TestSite.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Name of a page (Title)")]
        public override string Title { get; set; } = "Informaition page";

        [Display(Name = "Content page")]
        public override string Text { get; set; } = "Content filling by admin";
    }
}
