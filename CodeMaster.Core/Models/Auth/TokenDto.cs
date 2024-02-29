namespace CodeMaster.Core.Models.Auth;
public class TokenDto
{
    public string Token { get; set; }
    public string RefreshToken { get; set; }
    public DateTime ExpiredDate { get; set; }
    public UserLoginInfo UserInfo { get; set; }
}
