using CodeMaster.Core.Entities.Mocktest;

namespace CodeMaster.Core.Entities
{
    public partial class KeycodeChoose
    {
        public string Keycode { get; set; }

        public Guid MocktestPartId { get; set; }

        public Guid AnswerId { get; set; }

        public Guid QuestionId { get; set; }

        public string AnswerText { get; set; }

        public bool CorrectAnswer { get; set; }

        public Guid? MatchingQuestionId { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual MocktestKeyCode KeycodeNavigation { get; set; }
    }
}
