namespace CodeMaster.Core.Entities
{
    public partial class AccountBank
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Keycode { get; set; }

        public Guid ExtCategoryId { get; set; }

        public short ActiveDuration { get; set; }

        public short LearningDuration { get; set; }

        public DateTime ExpiredTime { get; set; }

        public short Status { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public string FullTextSearch { get; set; }

        public virtual ExamToolCategory.ExamToolCategory ExtCategory { get; set; }
    }
}
