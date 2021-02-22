using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProfileBook.ViewModels
{
    public class RegistrationPageViewModel : BindableBase
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

        public RegistrationPageViewModel(INavigationService navigationCommand)

        {
            Title = "Users SignIn";
            _navigationServies = navigationCommand;
        }
        async void ExcuteNavigateCommand()
        {
            await _navigationServies.NavigateAsync("AddProfile");
        }
    }
}
