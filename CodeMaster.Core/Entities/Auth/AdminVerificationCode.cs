namespace CodeMaster.Core.Entities.Auth
{
    public class AdminVerificationCode
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Code { get; set; }
        public string ServiceProvider { get; set; }
        public string Email { get; set; }
        public DateTime? ExpiresAtTime { get; set; }
        public bool IsUsed { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public short Type { get; set; }
    }
}
