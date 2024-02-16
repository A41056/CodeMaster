namespace CodeMaster.Core.Entities
{
    public partial class Setting
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public int Type { get; set; }

        public int DataType { get; set; }

        public Guid? ImageFileId { get; set; }

        public int? SortOrder { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }
    }
}
