using CodeMaster.Core.Entities.LiveClass;

namespace CodeMaster.Core.Entities.Auth
{
    public class AdminUser
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public DateTime? BirthDay { get; set; }
        public bool IsActive { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public string FullTextSearch { get; set; }
        public bool? Deleted { get; set; }
        public short AccessFailedCount { get; set; }
        public virtual ICollection<AdminUserGroup> AdminUserGroups { get; set; } = new List<AdminUserGroup>();
        public virtual ICollection<LiveLessonDetailAdviser> LiveLessonDetailAdvisers { get; set; } = new List<LiveLessonDetailAdviser>();
        public virtual ICollection<LiveLessonDetail> LiveLessonDetails { get; set; } = new List<LiveLessonDetail>();
        public virtual ICollection<Course.Course> Courses { get; set; } = new List<Course.Course>();
    }
}
