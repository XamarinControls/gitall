using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitAll.Core.I18NPortable
{
    public class PortableLanguage
    {
        public string Locale { get; set; }
        public string DisplayName { get; set; }
        public override string ToString() => DisplayName;
    }
}
