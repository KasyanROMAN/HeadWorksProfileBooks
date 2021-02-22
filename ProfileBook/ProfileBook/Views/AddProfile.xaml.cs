using ProfileBook.Model;
using System;
using Xamarin.Forms;

namespace ProfileBook.Views
{
    public partial class AddProfile : ContentPage
    {
        public AddProfile()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            friendsList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DataProfile selectedFriend = (DataProfile)e.SelectedItem;
            ChangePage friendPage = new ChangePage();
            friendPage.BindingContext = selectedFriend;
            await Navigation.PushAsync(friendPage);
        }
        // обработка нажатия кнопки добавления
        private async void CreateFriend(object sender, EventArgs e)
        {
            DataProfile friend = new DataProfile();
            ChangePage friendPage = new ChangePage();
            friendPage.BindingContext = friend;
            await Navigation.PushAsync(friendPage);
        }
    }
}

