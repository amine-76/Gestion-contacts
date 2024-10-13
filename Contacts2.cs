using Gestion_de_contact.Script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_contact
{
    public partial class Contacts2 : Form
    {
        public Contacts2()
        {
            InitializeComponent();
            loadGroup();

        }
        private void loadGroup()
        {
            this.list_group.Items.Clear();
            this.list_group.Items.Add("Tout");
            this.list_group.Items.AddRange(Global.listGroups.ToArray());
            this.list_group.SelectedIndex = 0;
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lb_np_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjoutPage pageAjout = new AjoutPage();
            DialogResult dr = pageAjout.ShowDialog();
            if (dr == DialogResult.OK) {
                
            }
        }

        private void My_list_contacts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }



}
