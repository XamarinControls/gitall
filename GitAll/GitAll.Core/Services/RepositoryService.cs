using GitAll.Core.Services.Interfaces;
using System.Collections.Generic;
using GitAll.Core.Model;

namespace GitAll.Core.Services
{
    public class RepositoryService : IRepositoryService
    {
        public List<Repository> AvialableRepositories(Account account)
        {
            return new List<Repository>();
        }
    }
}
