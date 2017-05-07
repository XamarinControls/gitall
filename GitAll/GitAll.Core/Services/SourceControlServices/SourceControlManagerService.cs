using GitAll.Core.Services.SourceControlServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitAll.Core.Model;
using GitAll.Core.Model.SourceControl;

namespace GitAll.Core.Services.SourceControlServices
{
    public class SourceControlManagerService : ISourceControlManagerService
    {
        public Task<List<Project>> AvialableProjects(Account account)
        {
            //TODO: Check account it's selected, change SourceControlService and retrieve projects are avialable.

            return Task.Run<List<Project>>(() => new List<Project>());
        }
    }
}
