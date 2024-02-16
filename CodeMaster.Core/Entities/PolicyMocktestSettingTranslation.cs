namespace CodeMaster.Core.Entities
{
    public partial class PolicyMocktestSettingTranslation
    {
        public Guid PolicyMocktestSettingId { get; set; }

        public string LanguageCode { get; set; }

        public string PolicyName { get; set; }

        public string PolicyContent { get; set; }

        public string GuidingName { get; set; }

        public string GuidingContent { get; set; }

        public string SoundName { get; set; }

        public string SoundContent { get; set; }

        public virtual LanguageTag Language { get; set; }

        public virtual PolicyMocktestSetting PolicyMocktestSetting { get; set; }
    }
}
