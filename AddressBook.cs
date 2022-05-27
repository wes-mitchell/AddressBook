using System;
using System.Collections.Generic;

namespace AddressBook
{
  public class AddressBook
  {
    public Dictionary<string, Contact> Contact = new Dictionary<string, Contact>();
    
    public void AddContact(Contact contact)
    { 
        Contact.Add(contact.Email, contact); 
    }

    public Contact GetByEmail(string Email)
    {
      return Contact[Email];
    }
  }
}