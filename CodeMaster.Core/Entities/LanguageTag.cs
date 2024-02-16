using CodeMaster.Core.Entities.Address;
using CodeMaster.Core.Entities.Category;
using CodeMaster.Core.Entities.Course;
using CodeMaster.Core.Entities.Dictionary;
using CodeMaster.Core.Entities.Discount;
using CodeMaster.Core.Entities.ExamToolCategory;
using CodeMaster.Core.Entities.Feedback;
using CodeMaster.Core.Entities.Mocktest;
using CodeMaster.Core.Entities.News;
using CodeMaster.Core.Entities.Notification;
using CodeMaster.Core.Entities.Questionaire;

namespace CodeMaster.Core.Entities
{
    public class LanguageTag
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
        public int SortOrder { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public virtual ICollection<AddressTranslation> AddressTranslations { get; set; } = new List<AddressTranslation>();

        public virtual ICollection<CategoryTranslation> CategoryTranslations { get; set; } = new List<CategoryTranslation>();

        public virtual ICollection<CourseDetailTranslation> CourseDetailTranslations { get; set; } = new List<CourseDetailTranslation>();

        public virtual ICollection<CoursePriceTranslation> CoursePriceTranslations { get; set; } = new List<CoursePriceTranslation>();

        public virtual ICollection<CourseTeacherTranslation> CourseTeacherTranslations { get; set; } = new List<CourseTeacherTranslation>();

        public virtual ICollection<CourseTranslation> CourseTranslations { get; set; } = new List<CourseTranslation>();

        public virtual ICollection<DictionaryTranslation> DictionaryTranslations { get; set; } = new List<DictionaryTranslation>();

        public virtual ICollection<DiscountTranslation> DiscountTranslations { get; set; } = new List<DiscountTranslation>();

        public virtual ICollection<ExtCategoryTranslation> ExtCategoryTranslations { get; set; } = new List<ExtCategoryTranslation>();

        public virtual ICollection<FeedbackTranslation> FeedbackTranslations { get; set; } = new List<FeedbackTranslation>();

        public virtual ICollection<GuidingMocktestTranslation> GuidingMocktestTranslations { get; set; } = new List<GuidingMocktestTranslation>();

        public virtual ICollection<MocktestTranslation> MocktestTranslations { get; set; } = new List<MocktestTranslation>();

        public virtual ICollection<NewsTranslation> NewsTranslations { get; set; } = new List<NewsTranslation>();

        public virtual ICollection<NotificationTranslation> NotificationTranslations { get; set; } = new List<NotificationTranslation>();

        public virtual ICollection<PolicyMocktestSettingTranslation> PolicyMocktestSettingTranslations { get; set; } = new List<PolicyMocktestSettingTranslation>();

        public virtual ICollection<QuestionTranslation> QuestionTranslations { get; set; } = new List<QuestionTranslation>();
    }
}
