using System.ComponentModel.DataAnnotations;

namespace TestSite.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Fill the name of service")]
        [Display(Name = "Name of the service")]
        public override string Title { get; set; }

        [Display(Name = "Name of a page (Title)")]
        public override string Subtitle { get; set; }

        [Display(Name = "Полное описание услуги")]
        public override string Text { get; set; }
    }
}
