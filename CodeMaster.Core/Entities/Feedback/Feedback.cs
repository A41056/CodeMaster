namespace CodeMaster.Core.Entities.Feedback
{
    public partial class Feedback
    {
        public Guid Id { get; set; }

        public Guid? ImageFileId { get; set; }

        public string Name { get; set; }

        public int? SortOrder { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual ICollection<FeedbackTranslation> FeedbackTranslations { get; set; } = new List<FeedbackTranslation>();
    }
}
