using GitAll.Core.I18NPortable;
using GitAll.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitAll.Core.Services
{
    public class AppSettings : IAppSettings
    {
        public string MainTitle
        {
            get
            {
                return "MainTitle".Translate();
            }
            set
            {

            }
        }
    }
}
