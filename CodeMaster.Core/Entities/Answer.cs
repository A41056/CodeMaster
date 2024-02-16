using CodeMaster.Core.Entities.Questionaire;
using CodeMaster.Core.Entities.WebUser;

namespace CodeMaster.Core.Entities
{
    public partial class Answer
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid QuestionId { get; set; }

        public Guid? ImageFileId { get; set; }

        public bool? CorrectMcq { get; set; }

        public string MatchingKey { get; set; }

        public string CorrectMatchingValues { get; set; }

        public string FakeSelectValues { get; set; }

        public int? SortOrder { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Question Question { get; set; }

        public virtual ICollection<WebUserChoose> WebUserChooses { get; set; } = new List<WebUserChoose>();
    }
}
