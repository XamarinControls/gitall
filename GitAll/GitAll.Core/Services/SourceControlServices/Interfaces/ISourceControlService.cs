using GitAll.Core.Model.SourceControl;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitAll.Core.Services.SourceControlServices.Interfaces
{
    public interface ISourceControlService
    {
        Task<List<Issue>> GetIssues(Project project);

        Task<List<Branch>> GetBranches(Project project);

        Task<List<Project>> GetProjects();

        Task<List<Commit>> GetCommits(Project project);

        Task<List<Milestone>> GetMilestones(Project project);

        Task<List<Label>> GetLabels(Project project);

        Task<List<User>> GetUsers(Project project);

        void AddComment(Issue issue, Comment comment);

    }
}
