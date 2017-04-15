using GitAll.Core.ViewModels;
using GitAll.Forms.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GitAll.Forms.Views
{    
    public partial class ActivityView : BaseView
    {
        public ActivityView()
        {
            InitializeComponent();
            BindingContext = new ActivityViewModel();
        }
    }
}
