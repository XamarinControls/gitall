using GitAll.Core.Model;
using GitAll.Core.Model.SourceControl;
using GitAll.Core.Services;
using GitAll.Core.Services.SourceControlServices;
using GitAll.Core.Utils;
using GitAll.Core.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace GitAll.Core.ViewModels
{
    public class MasterViewModel : BaseViewModel
    {
        public MasterViewModel()
        {
            Items = new ObservableCollection<MasterItemDetail>(
                CoreApp.Get<MasterDetailMenuService>().MenuOptions());

            AccountList = new ObservableCollection<Account>(
                CoreApp.Get<AccountService>().AvialableAccounts());

            ProjectList = new ObservableCollection<Project>();
        }


        private ObservableCollection<MasterItemDetail> _items;

        public ObservableCollection<MasterItemDetail> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }

        private MasterItemDetail _itemSelected;


        public MasterItemDetail ItemSelected
        {
            get { return _itemSelected; }
            set
            {
                if(_itemSelected != value)
                {
                    value.CommandClick?.Invoke();
                }
                SetProperty(ref _itemSelected, value);
            }
        }


        private string _accountImage;

        public string AccountImage
        {
            get { return _accountImage; }
            set { SetProperty(ref _accountImage, value); }
        }

        private string _repositoryImage;

        public string RepositoryImage
        {
            get { return _repositoryImage; }
            set { SetProperty(ref _repositoryImage, value); }
        }

        private ObservableCollection<Account> _accountList;

        public ObservableCollection<Account> AccountList
        {
            get { return _accountList; }
            set { SetProperty(ref _accountList, value); }
        }

        private Account _accountSelected;

        public Account AccountSelected
        {
            get { return _accountSelected; }
            set
            {
                if(_accountSelected != value)
                {
                    RefillRepository();
                }
                SetProperty(ref _accountSelected, value);
            }
        }


        private ObservableCollection<Project> _projectList;

        public ObservableCollection<Project> ProjectList
        {
            get { return _projectList; }
            set { SetProperty(ref _projectList, value); }
        }

        private Project _repositorySelected;

        public Project RepositorySelected
        {
            get { return _repositorySelected; }
            set
            {                
                SetProperty(ref _repositorySelected, value);
            }
        }

        private async void RefillRepository()
        {
            ProjectList.Clear();
            
            ProjectList.AddRange(
                await CoreApp.Get<SourceControlManagerService>().AvialableProjects(_accountSelected));            
        }        
    }
}
