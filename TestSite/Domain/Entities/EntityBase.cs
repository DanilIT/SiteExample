using System;
using System.ComponentModel.DataAnnotations;

namespace TestSite.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Name(Ttle)")]
        public virtual string Title { get; set; }

        [Display(Name = "Short description")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Description")]
        public virtual string Text { get; set; }

        [Display(Name = "Title pic")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "SEO Title")]
        public string Metatitle { get; set; }

        [Display(Name = "SEO Description")]
        public string MetaDescription { get; set; }

        [Display(Name = "SEO Keywords")]
        public string MetaKeywords{ get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
