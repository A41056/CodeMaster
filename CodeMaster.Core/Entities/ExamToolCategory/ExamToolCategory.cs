namespace CodeMaster.Core.Entities.ExamToolCategory
{
    public partial class ExamToolCategory
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsKeycodeType { get; set; }

        public string UrlLearning { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public string FullTextSearch { get; set; }

        public virtual ICollection<AccountBank> AccountBanks { get; set; } = new List<AccountBank>();

        public virtual ICollection<ExtCategoryTranslation> ExtCategoryTranslations { get; set; } = new List<ExtCategoryTranslation>();
    }
}
