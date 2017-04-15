using GitAll.Core.ViewModels.Base;
using Xamarin.Forms;

namespace GitAll.Forms.Views.Base
{
    public class BaseView : ContentPage
    {

        public BaseViewModel BaseViewModel
        {
            get
            {
                return (BaseViewModel)BindingContext;
            }
        }

        protected override void OnAppearing()
        {
            BaseViewModel.OnResume();
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            BaseViewModel.OnPause();
            base.OnDisappearing();            
        }        
    }
}
