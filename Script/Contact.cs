using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_contact.Script
{
    internal class Contact
    {
        private string name;
        private string lastname;
        private string email;
        private string phone;
        private string city;
        private Image image;
        private string adress;
        
        public string firstName {  get => firstName ; private set => name = value; }
        public string lastName { get => lastName ; private set => lastName = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Phone { get => phone ;  set => phone = value; }
        public string City { get => city ; set => city = value; }
        public Image Image { get => image ; set => image = value; } 
        public string Email { get => email; set => email = value; }

        
        public Contact(string name, string lastname, string email, string phone, string city, Image image, string adress)
        {
            this.name = name;
            this.lastname = lastname;
            this.email = email;
            this.phone = phone;
            this.city = city;
            this.image = image;
            this.adress = adress;
            this.name = name;
            this.lastName = lastName;
            this.phone = phone;
            this.city = city;
            this.image = image;
            this.email = email;
        }

        public override string ToString()
        {
            return "First name : "+name+" \n"+ "Last name : "+ lastname;
        }
    }
}

