using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMaster.Core.Models.Auth;
public class UserLoginInfo
{
    public List<string> Permisions { get; set; }
    public string UserName { get; set; }
    public Guid UserId { get; set; }
}
