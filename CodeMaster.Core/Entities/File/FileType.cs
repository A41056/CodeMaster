namespace CodeMaster.Core.Entities.File
{
    public partial class FileType
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public short Identifier { get; set; }

        public string DefaultStorageLocation { get; set; }

        public string FileExtensions { get; set; }

        public string FileNamePattern { get; set; }

        public long MaxSize { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual ICollection<File> Files { get; set; } = new List<File>();
    }
}
