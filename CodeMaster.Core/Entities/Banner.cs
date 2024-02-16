namespace CodeMaster.Core.Entities
{
    public class Banner
    {
        public Guid Id { get; set; }
        public Guid? ImageFileId { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string LinkUrl { get; set; }
        public int? SortOrder { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public string FullTextSearch { get; set; }
    }
}
