using GitAll.Core.Model;
using System.Collections.Generic;

namespace GitAll.Core.Services.Interfaces
{
    public interface IMasterDetailMenuService
    {
        List<MasterItemDetail> MenuOptions();
    }
}
