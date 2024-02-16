namespace CodeMaster.Core.Entities
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NameNonAscii { get; set; }
        public string Description { get; set; }
        public Guid? CategoryId { get; set; }
        public string Content { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public bool? IsActive { get; set; }
        public string Author { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public virtual Category.Category Category { get; set; }
    }
}
