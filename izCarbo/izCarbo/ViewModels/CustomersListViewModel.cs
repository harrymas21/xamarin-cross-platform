using izCarbo.Models;
using izCarbo.Services;
using System.Collections.ObjectModel;

namespace izCarbo
{
    class CustomersListViewModel : ViewModelBase
    {
        private readonly IContactService _contactService;

        public CustomersListViewModel()
        {
            _contactService = new ContactService();

            DisplayName = "izCarbo v1";

            WelcomeText = "Welcome to izCarbo";

            FetchContacts();
        }

        string _displayName;
        public string DisplayName
        {
            get { return _displayName; }
            set
            {
                SetProperty(ref _displayName, value);
            }
        }

        string _welcomeText;
        public string WelcomeText
        {
            get { return _welcomeText; }
            set
            {
                SetProperty(ref _welcomeText, value);
            }
        }

        ObservableCollection<Contact> _contacts;
        public ObservableCollection<Contact> Contacts
        {
            get
            {
                if (_contacts == null)
                    _contacts = new ObservableCollection<Contact>();
                return _contacts;
            }
            set
            {
                if (_contacts != value)
                {
                    _contacts = value;
                    SetProperty(ref _contacts, value);
                }
            }
        }

        private void FetchContacts()
        {
            Contacts = new ObservableCollection<Contact>(_contactService.FetchContacts());
        }
    }
}
