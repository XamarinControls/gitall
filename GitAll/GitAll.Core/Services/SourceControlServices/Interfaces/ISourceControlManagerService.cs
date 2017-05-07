using GitAll.Core.Model;
using GitAll.Core.Model.SourceControl;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitAll.Core.Services.SourceControlServices.Interfaces
{
    public interface ISourceControlManagerService
    {
        Task<List<Project>> AvialableProjects(Account account);
    }
}
