using CodeMaster.Core.Entities.Mocktest;

namespace CodeMaster.Core.Entities
{
    public partial class GuidingMocktest
    {
        public Guid Id { get; set; }

        public Guid MocktestObjectId { get; set; }

        public Guid MocktestTypeId { get; set; }

        public Guid CategoryId { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public bool? IsMockExam { get; set; }

        public virtual Category.Category Category { get; set; }

        public virtual ICollection<GuidingMocktestTranslation> GuidingMocktestTranslations { get; set; } = new List<GuidingMocktestTranslation>();

        public virtual MocktestObject MocktestObject { get; set; }

        public virtual MocktestType MocktestType { get; set; }
    }
}
