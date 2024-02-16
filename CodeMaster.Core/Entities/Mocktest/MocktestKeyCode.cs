namespace CodeMaster.Core.Entities.Mocktest
{
    public partial class MocktestKeyCode
    {
        public string Code { get; set; }

        public Guid MocktestId { get; set; }

        public Guid? WebUserId { get; set; }

        public Guid? CourseId { get; set; }

        public Guid? OrderId { get; set; }

        public Guid? CoursePriceId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime? StartedDoingExamDate { get; set; }

        public DateTime? SubmittedDate { get; set; }

        public string ClientIp { get; set; }

        public string Browser { get; set; }

        public long? TimeRemaining { get; set; }

        public DateTime? MocktestPublishedAt { get; set; }

        public short Type { get; set; }

        public string ChallengeName { get; set; }

        public string IdentificationNumber { get; set; }

        public Guid? Cookie { get; set; }

        public string FullName { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public string FullTextSearch { get; set; }

        public bool? ExpiredTriggerNotification { get; set; }

        public virtual ICollection<KeycodeChoose> KeycodeChooses { get; set; } = new List<KeycodeChoose>();

        public virtual KeycodeResult KeycodeResult { get; set; }

        public bool? IsAutoGenerate { get; set; }

        public bool? IsDelete { get; set; }

        public string RegistrationToken { get; set; }
    }
}
