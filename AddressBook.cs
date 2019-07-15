using System;
using System.Collections.Generic;
using System.Linq;

namespace address_book
{
    public class AddressBook
    {
        private List<Contact> _contactList;
        public List<Contact> ContactList
        {
            get
            {
                return _contactList;
            }
            set
            {
                _contactList = value;
            }
        }

        public AddressBook()
        {
            _contactList = new List<Contact>();
        }
        public void AddContact(Contact contact)
        {
            _contactList.Add(contact);
        }

        public Contact GetByEmail(string email)
        {
            var contact = _contactList.First(x => x.Email == email);
            return contact;
        }

    }
}