using CodeMaster.Core.Entities.Questionaire;

namespace CodeMaster.Core.Entities.WebUser
{
    public partial class WebUserPracticeHistory
    {
        public Guid Id { get; set; }

        public Guid WebUserId { get; set; }

        public Guid QuestionnaireId { get; set; }

        public Guid StepId { get; set; }

        public Guid? QuestionId { get; set; }

        public DateTime? DateViewed { get; set; }

        public short QuestionnaireType { get; set; }

        public Guid? RecordFileId { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Questionnaire Questionnaire { get; set; }

        public virtual Step Step { get; set; }

        public virtual WebUser WebUser { get; set; }
    }
}
