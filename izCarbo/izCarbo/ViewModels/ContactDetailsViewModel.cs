using izCarbo.Models;
using izCarbo.Services;

namespace izCarbo
{
    public class ContactDetailsViewModel : ViewModelBase
    {
        private readonly IContactService _contactService;

        public ContactDetailsViewModel(int id)
        {
            _contactService = new ContactService();

            Id = id;
        }

        Contact _contact;
        public Contact Contact
        {
            get
            {
                if (_contact == null)
                    _contact = new Contact();
                return _contact;
            }
            set
            {
                if (_contact != value)
                {
                    _contact = value;
                    OnPropertyChanged("Contact");
                }
            }
        }

        int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged("Id");

                    FetchContact();
                }
            }
        }

        public void FetchContact()
        {
            Contact = _contactService.FetchContacts().Find(x => x.Id == Id);
        }
    }
}
