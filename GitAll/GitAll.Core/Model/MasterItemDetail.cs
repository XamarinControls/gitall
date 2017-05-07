using System;
using System.Windows.Input;

namespace GitAll.Core.Model
{
    public class MasterItemDetail
    {
        public string Icon { get; set; }
        public string Title { get; set; }

        public Action CommandClick { get; set; }
    }
}
