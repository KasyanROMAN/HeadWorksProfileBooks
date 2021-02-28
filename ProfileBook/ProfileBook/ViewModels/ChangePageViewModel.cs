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
 
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }

        }
    
    }
}
