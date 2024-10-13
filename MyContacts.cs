using Gestion_de_contact.Script;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System.Media;

namespace Gestion_de_contact
{
    public partial class MyContacts : Form
    {
        public MyContacts()
        {
            InitializeComponent();
        }
       

        private void label_hello_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\\Users\\Amine\\OneDrive\\Bureau\\Projet C#\\Gestion-de-contact\\Media\\bruit.wav");
            soundPlayer.Play();
            //Contacts2 contacts = new Contacts2();
            //contacts.ShowDialog();
            AjoutPage ajoutPage = new AjoutPage();
            ajoutPage.ShowDialog();
        }

     
    }
}
