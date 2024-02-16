namespace CodeMaster.Core.Entities.Mocktest
{
    public partial class MocktestObject
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int SortOrder { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual ICollection<GuidingMocktest> GuidingMocktests { get; set; } = new List<GuidingMocktest>();

        public virtual ICollection<Mocktest> Mocktests { get; set; } = new List<Mocktest>();
    }
}
