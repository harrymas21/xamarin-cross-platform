using izCarbo.Models;
using Java.Lang;
using System;
using System.Collections.Generic;

namespace izCarbo.Services
{
    public class ContactService : IContactService
    {
        public List<Contact> FetchContacts()
        {
            var contacts = new List<Contact>();

            for (int i = 0; i < 20; i++)
            {
                var k = i + 1;

                contacts.Add(new Contact { Id = k, Name = GetName(), Number = GetNumber() });
            }
            return contacts;
        }

        private string GetName()
        {
            int stringLength = 6;

            Random rd = new Random();

            const string allowedCharacters = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz";

            char[] chars = new char[stringLength];

            for (int i = 0; i < stringLength; i++)
            {
                chars[i] = allowedCharacters[rd.Next(0, allowedCharacters.Length)];
            }

            chars[0] = Character.ToUpperCase(chars[0]);

            return new string(chars);
        }

        private string GetNumber()
        {
            int stringLength = 9;

            Random rd = new Random();

            const string allowedCharacters = "0123456789";

            char[] chars = new char[stringLength];

            for (int i = 0; i < stringLength; i++)
            {
                chars[i] = allowedCharacters[rd.Next(0, allowedCharacters.Length)];
            }

            var numberPrefix = "+254";

            var randomCharacters = new string(chars);

            return numberPrefix + randomCharacters;
        }
    }
}
