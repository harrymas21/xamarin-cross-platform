using izCarbo.Models;
using Xamarin.Forms;

namespace izCarbo
{
    public partial class ContactDetailsPage : ContentPage
    {
        public ContactDetailsPage(int contactId)
        {
            InitializeComponent();

            var viewModel = new ContactDetailsViewModel(contactId);

            BindingContext = viewModel;
        }
    }
}