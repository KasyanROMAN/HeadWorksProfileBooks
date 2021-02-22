using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProfileBook.ViewModels
{
    public class ChangePageViewModel : BindableBase
    {
        private string _title;
        private readonly INavigationService _navigationServies;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }

        }
        private DelegateCommand _navigationCommand;
        public DelegateCommand NavigateCommand => _navigationCommand ?? (_navigationCommand = new DelegateCommand(ExcuteNavigateCommand));

        public ChangePageViewModel(INavigationService navigationCommand)

        {
            Title = "Users SignIn";
            _navigationServies = navigationCommand;
        }
        async void ExcuteNavigateCommand()
        {
           
        }
    }
}
