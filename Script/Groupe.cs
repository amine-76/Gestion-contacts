using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_contact.Script
{
    internal class Groupe
    {
        private string name;
        private List<Contact> listContacts;
        public Groupe() {
            this.name = "Undefined"; 
            listContacts = new List<Contact>();

        }
        public Groupe(string name)
        {
            this.name = name;
            this.listContacts = new List<Contact>();
           
        }
        public Groupe(string name, List<Contact> listContacts)
        {
            this.name = name;
            this.listContacts = listContacts;

        }

        public string Name { get { return name; } }
        public List<Contact> ListContacts { get => listContacts; private set => listContacts = value; }
        public override string ToString()
        {
            return name.ToString();  
        }
    }
    
}
