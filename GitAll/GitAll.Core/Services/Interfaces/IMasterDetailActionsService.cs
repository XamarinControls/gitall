using System;

namespace GitAll.Core.Services.Interfaces
{
    public interface IMasterDetailActionsService
    {
        Action this[string key] { get; set; }
    }
}
