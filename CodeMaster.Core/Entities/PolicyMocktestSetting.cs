namespace CodeMaster.Core.Entities
{
    public partial class PolicyMocktestSetting
    {
        public Guid Id { get; set; }

        public Guid? SoundTestFileId { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual ICollection<PolicyMocktestSettingTranslation> PolicyMocktestSettingTranslations { get; set; } = new List<PolicyMocktestSettingTranslation>();
    }
}
