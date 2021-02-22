using ProfileBook.Model;
using System;
using Xamarin.Forms;

namespace ProfileBook.Views
{
    public partial class ChangePage : ContentPage
    {
        public ChangePage()
        {
            InitializeComponent();
        }
        private void SaveFriend(object sender, EventArgs e)
        {
            var friend = (DataProfile)BindingContext;
            if (!String.IsNullOrEmpty(friend.Name))
            {
                App.Database.SaveItem(friend);
            }
            this.Navigation.PopAsync();
        }
        private void DeleteFriend(object sender, EventArgs e)
        {
            var friend = (DataProfile)BindingContext;
            App.Database.DeleteItem(friend.Id);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}
