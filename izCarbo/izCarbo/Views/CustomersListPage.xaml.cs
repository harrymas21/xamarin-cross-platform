using izCarbo.Models;
using Xamarin.Forms;

namespace izCarbo
{
    public partial class CustomersListPage : ContentPage
	{
        public CustomersListPage()
        {
            InitializeComponent();

            BindingContext = new CustomersListViewModel();
        }

        private async void SelectedContact(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;

            await Navigation.PushAsync(new ContactDetailsPage(((Contact)e.SelectedItem).Id));
        }
    }
}