namespace CodeMaster.Core.Entities.Feedback
{
    public partial class FeedbackTranslation
    {
        public string LanguageCode { get; set; }

        public Guid FeedbackId { get; set; }

        public string Position { get; set; }

        public string Content { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Feedback Feedback { get; set; }

        public virtual LanguageTag Language { get; set; }
    }
}
