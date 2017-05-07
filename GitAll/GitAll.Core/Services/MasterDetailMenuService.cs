using GitAll.Core.Services.Interfaces;
using System.Collections.Generic;
using GitAll.Core.Model;
using GitAll.Core.I18NPortable;

namespace GitAll.Core.Services
{
    public class MasterDetailMenuService : IMasterDetailMenuService
    {
        private IMasterDetailActionsService _actionMasterDetailActionService;

        public MasterDetailMenuService()
        {
            _actionMasterDetailActionService = CoreApp.Get<MasterDetailActionsService>();
        }

        public MasterDetailMenuService(IMasterDetailActionsService actionMasterDetailService)
        {
            _actionMasterDetailActionService = actionMasterDetailService;
        }

        public List<MasterItemDetail> MenuOptions()
        {
            var options = new List<MasterItemDetail>();

            options.Add(new MasterItemDetail()
            {
                Icon = "fa-500px",
                Title = "Activity".Translate(),
                CommandClick = () => _actionMasterDetailActionService["Activity"].Invoke()
            });

            options.Add(new MasterItemDetail()
            {
                Icon = "fa-moon-o",
                Title = "Issues".Translate(),
                CommandClick = () => _actionMasterDetailActionService["Issues"].Invoke()
            });

            return options;
        }
    }
}
