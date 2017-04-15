using GitAll.Core.Model;
using System.Collections.Generic;

namespace GitAll.Core.Services.Interfaces
{
    public interface IRepositoryService
    {
        List<Repository> AvialableRepositories(Account account);
    }
}
