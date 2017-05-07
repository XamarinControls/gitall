using GitAll.Core.ViewModels;
using GitAll.Forms.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GitAll.Forms.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IssuesView : BaseView
    {
        public IssuesView()
        {
            InitializeComponent();
            BindingContext = new IssuesViewModel();
        }
    }
}
