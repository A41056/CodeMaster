using CodeMaster.Core.Entities.Course;
using CodeMaster.Core.Entities.LiveClass;

namespace CodeMaster.Core.Entities.Mocktest
{
    public partial class Mocktest
    {
        public Guid Id { get; set; }

        public Guid MocktestTypeId { get; set; }

        public Guid MocktestObjectId { get; set; }

        public int SortOrder { get; set; }

        public short Status { get; set; }

        public short VersionStatus { get; set; }

        public short ScoreType { get; set; }

        public string Tags { get; set; }

        public DateTime? PublishedAt { get; set; }

        public string LinkUrlViewMore { get; set; }

        public string TextViewMore { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public string FullTextSearch { get; set; }

        public virtual ICollection<CourseTest> CourseTests { get; set; } = new List<CourseTest>();

        public virtual ICollection<LiveClassDetailTest> LiveClassDetailTests { get; set; } = new List<LiveClassDetailTest>();

        public virtual ICollection<MocktestCoursePrice> MocktestCoursePrices { get; set; } = new List<MocktestCoursePrice>();

        public virtual MocktestObject MocktestObject { get; set; }

        public virtual ICollection<MocktestSection> MocktestSections { get; set; } = new List<MocktestSection>();

        public virtual ICollection<MocktestTranslation> MocktestTranslations { get; set; } = new List<MocktestTranslation>();

        public virtual MocktestType MocktestType { get; set; }
    }
}
