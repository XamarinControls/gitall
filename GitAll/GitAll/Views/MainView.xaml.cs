﻿using GitAll.Forms.Views.Base;
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
using System.Globalization;
using GitAll.Core.ViewModels;

namespace GitAll.Forms.Views
{
    
    public partial class MainView : MasterDetailPage
    {
        public MainView()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();

            Master = new MasterView();
            Detail = new ActivityView();                        
        }
    }

  
}
