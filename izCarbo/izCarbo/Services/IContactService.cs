using izCarbo.Models;
using System.Collections.Generic;

namespace izCarbo.Services
{
    public interface IContactService
    {
        List<Contact> FetchContacts();
    }
}
