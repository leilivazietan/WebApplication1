using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Contracts
{
   public interface IUserInfoReader
    {
        List<User> ReadFromExecl();
    }
}
