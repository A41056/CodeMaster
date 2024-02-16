namespace CodeMaster.Core.Entities.Course
{
    public class CoursePriceTranslation
    {
        public string LanguageCode { get; set; }
        public Guid CoursePriceId { get; set; }
        public string Name { get; set; }
        public virtual CoursePrice CoursePrice { get; set; }
        public virtual LanguageTag Language { get; set; }

    }
}
