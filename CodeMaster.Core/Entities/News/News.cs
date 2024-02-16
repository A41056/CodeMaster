namespace CodeMaster.Core.Entities.News
{
    public partial class News
    {
        public Guid Id { get; set; }

        public string NameNonAscii { get; set; }

        public Guid? CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string MetaTitle { get; set; }

        public string MetaKeywords { get; set; }

        public string MetaDescription { get; set; }

        public bool? IsActive { get; set; }

        public bool IsHot { get; set; }

        public bool IsHome { get; set; }

        public int? SortOrder { get; set; }

        public string Author { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public string FullTextSearch { get; set; }

        public virtual Category.Category Category { get; set; }

        public virtual ICollection<File.File> Files { get; set; } = new List<File.File>();

        public virtual ICollection<NewsTranslation> NewsTranslations { get; set; } = new List<NewsTranslation>();
    }
}
