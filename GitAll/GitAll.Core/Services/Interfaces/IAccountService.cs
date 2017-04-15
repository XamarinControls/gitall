using GitAll.Core.Model;
using System.Collections.Generic;

namespace GitAll.Core.Services.Interfaces
{
    public interface IAccountService
    {
        List<Account> AvialableAccounts();
    }
}
