using GitAll.Core;
using GitAll.Core.Services;
using GitAll.Core.ViewModels;
using GitAll.Forms.Views.Base;
using System;
using Xamarin.Forms;

namespace GitAll.Forms.Views
{
    public partial class MasterView : BaseView
    {
        public MasterView()
        {
            InitializeComponent();
            BindingContext = new MasterViewModel();            
        }

        
        
    }
}
