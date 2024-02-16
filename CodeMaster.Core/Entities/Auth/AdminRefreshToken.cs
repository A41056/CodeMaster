namespace CodeMaster.Core.Entities.Auth
{
    public class AdminRefreshToken
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Token { get; set; }
        public Guid JwtId { get; set; }
        public bool IsUsed { get; set; }
        public DateTime ExpiredAt { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
