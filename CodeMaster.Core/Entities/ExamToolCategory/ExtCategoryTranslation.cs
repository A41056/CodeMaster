namespace CodeMaster.Core.Entities.ExamToolCategory
{
    public partial class ExtCategoryTranslation
    {
        public string LanguageCode { get; set; }

        public Guid ExtCategoryId { get; set; }

        public string CourseGuide { get; set; }

        public virtual ExamToolCategory ExtCategory { get; set; }

        public virtual LanguageTag Language { get; set; }
    }
}
