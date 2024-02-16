using CodeMaster.Core.Entities.Questionaire;

namespace CodeMaster.Core.Entities
{
    public partial class LeftSection
    {
        public Guid Id { get; set; }

        public Guid QuestionnaireId { get; set; }

        public int? SortOrder { get; set; }

        public string Title { get; set; }

        public Guid? AudioFileId { get; set; }

        public Guid? ImageFileId { get; set; }

        public string TextScript { get; set; }

        public string TextContent { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Questionnaire Questionnaire { get; set; }
    }
}
