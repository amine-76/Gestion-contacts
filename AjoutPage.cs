using Gestion_de_contact.Script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_contact
{
    public partial class AjoutPage : Form
    {
        public AjoutPage()
        {
            InitializeComponent();
            loadGroup();
        }

        private void loadGroup()
        {
            this.liste_grp.Items.Clear();
            this.liste_grp.Items.AddRange(Global.listGroups.ToArray());
            if (this.liste_grp.Items.Count > 0)
            {
                this.liste_grp.SelectedIndex = 0;
            }
        }

        private void btn_aj_contact_Click(object sender, EventArgs e)
        {
            // Récupération des valeurs en entrée
            string firstName = this.tb_aj_prenom.Text;
            string lastName = this.tb_aj_nom.Text;
            string adresse = this.tb_aj_adress.Text;
            string mail = this.tb_aj_mail.Text;
            string tel = this.tb_aj_tel.Text;
            string ville = this.tb_aj_ville.Text;
            Group group = (Group)this.liste_grp.SelectedItem;
        }
    }
}
