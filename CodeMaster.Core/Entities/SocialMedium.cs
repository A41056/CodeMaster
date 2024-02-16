namespace CodeMaster.Core.Entities
{
    public partial class SocialMedium
    {
        public Guid Id { get; set; }

        public Guid? IconFileId { get; set; }

        public string Name { get; set; }

        public string LinkUrl { get; set; }

        public int? SortOrder { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }
    }
}
