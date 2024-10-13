namespace Gestion_de_contact
{
    partial class AjoutPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pct_ajout = new PictureBox();
            groupe_btn_ajout = new GroupBox();
            lb_lst_grp = new Label();
            liste_grp = new ComboBox();
            lb_aj_ville = new Label();
            tb_aj_ville = new TextBox();
            lb_aj_prenom = new Label();
            lb_aj_adress = new Label();
            lb_aj_mail = new Label();
            lb_aj_tel = new Label();
            lb_aj_nom = new Label();
            tb_aj_tel = new TextBox();
            tb_aj_mail = new TextBox();
            tb_aj_adress = new TextBox();
            tb_aj_prenom = new TextBox();
            tb_aj_nom = new TextBox();
            btn_aj_photo = new Button();
            btn_aj_contact = new Button();
            ((System.ComponentModel.ISupportInitialize)pct_ajout).BeginInit();
            groupe_btn_ajout.SuspendLayout();
            SuspendLayout();
            // 
            // pct_ajout
            // 
            pct_ajout.Location = new Point(12, 12);
            pct_ajout.Name = "pct_ajout";
            pct_ajout.Size = new Size(302, 225);
            pct_ajout.TabIndex = 0;
            pct_ajout.TabStop = false;
            // 
            // groupe_btn_ajout
            // 
            groupe_btn_ajout.Controls.Add(lb_lst_grp);
            groupe_btn_ajout.Controls.Add(liste_grp);
            groupe_btn_ajout.Controls.Add(lb_aj_ville);
            groupe_btn_ajout.Controls.Add(tb_aj_ville);
            groupe_btn_ajout.Controls.Add(lb_aj_prenom);
            groupe_btn_ajout.Controls.Add(lb_aj_adress);
            groupe_btn_ajout.Controls.Add(lb_aj_mail);
            groupe_btn_ajout.Controls.Add(lb_aj_tel);
            groupe_btn_ajout.Controls.Add(lb_aj_nom);
            groupe_btn_ajout.Controls.Add(tb_aj_tel);
            groupe_btn_ajout.Controls.Add(tb_aj_mail);
            groupe_btn_ajout.Controls.Add(tb_aj_adress);
            groupe_btn_ajout.Controls.Add(tb_aj_prenom);
            groupe_btn_ajout.Controls.Add(tb_aj_nom);
            groupe_btn_ajout.Location = new Point(12, 285);
            groupe_btn_ajout.Name = "groupe_btn_ajout";
            groupe_btn_ajout.Size = new Size(302, 295);
            groupe_btn_ajout.TabIndex = 1;
            groupe_btn_ajout.TabStop = false;
            // 
            // lb_lst_grp
            // 
            lb_lst_grp.AutoSize = true;
            lb_lst_grp.Location = new Point(22, 254);
            lb_lst_grp.Name = "lb_lst_grp";
            lb_lst_grp.Size = new Size(69, 20);
            lb_lst_grp.TabIndex = 13;
            lb_lst_grp.Text = "Groupe : ";
            // 
            // liste_grp
            // 
            liste_grp.DropDownStyle = ComboBoxStyle.DropDownList;
            liste_grp.FormattingEnabled = true;
            liste_grp.Location = new Point(93, 254);
            liste_grp.Name = "liste_grp";
            liste_grp.Size = new Size(191, 28);
            liste_grp.TabIndex = 12;
            // 
            // lb_aj_ville
            // 
            lb_aj_ville.AutoSize = true;
            lb_aj_ville.Location = new Point(42, 221);
            lb_aj_ville.Name = "lb_aj_ville";
            lb_aj_ville.Size = new Size(49, 20);
            lb_aj_ville.TabIndex = 11;
            lb_aj_ville.Text = "Ville : ";
            // 
            // tb_aj_ville
            // 
            tb_aj_ville.Location = new Point(93, 221);
            tb_aj_ville.Name = "tb_aj_ville";
            tb_aj_ville.Size = new Size(191, 27);
            tb_aj_ville.TabIndex = 10;
            // 
            // lb_aj_prenom
            // 
            lb_aj_prenom.AutoSize = true;
            lb_aj_prenom.Location = new Point(20, 66);
            lb_aj_prenom.Name = "lb_aj_prenom";
            lb_aj_prenom.Size = new Size(67, 20);
            lb_aj_prenom.TabIndex = 9;
            lb_aj_prenom.Text = "Prénom :";
            // 
            // lb_aj_adress
            // 
            lb_aj_adress.AutoSize = true;
            lb_aj_adress.Location = new Point(18, 102);
            lb_aj_adress.Name = "lb_aj_adress";
            lb_aj_adress.Size = new Size(68, 20);
            lb_aj_adress.TabIndex = 8;
            lb_aj_adress.Text = "Adresse :";
            // 
            // lb_aj_mail
            // 
            lb_aj_mail.AutoSize = true;
            lb_aj_mail.Location = new Point(29, 142);
            lb_aj_mail.Name = "lb_aj_mail";
            lb_aj_mail.Size = new Size(57, 20);
            lb_aj_mail.TabIndex = 7;
            lb_aj_mail.Text = "Email : ";
            // 
            // lb_aj_tel
            // 
            lb_aj_tel.AutoSize = true;
            lb_aj_tel.Location = new Point(42, 179);
            lb_aj_tel.Name = "lb_aj_tel";
            lb_aj_tel.Size = new Size(39, 20);
            lb_aj_tel.TabIndex = 6;
            lb_aj_tel.Text = "Tél : ";
            // 
            // lb_aj_nom
            // 
            lb_aj_nom.AutoSize = true;
            lb_aj_nom.Location = new Point(32, 30);
            lb_aj_nom.Name = "lb_aj_nom";
            lb_aj_nom.Size = new Size(49, 20);
            lb_aj_nom.TabIndex = 5;
            lb_aj_nom.Text = "Nom :";
            // 
            // tb_aj_tel
            // 
            tb_aj_tel.Location = new Point(93, 179);
            tb_aj_tel.Name = "tb_aj_tel";
            tb_aj_tel.Size = new Size(191, 27);
            tb_aj_tel.TabIndex = 4;
            // 
            // tb_aj_mail
            // 
            tb_aj_mail.Location = new Point(93, 142);
            tb_aj_mail.Name = "tb_aj_mail";
            tb_aj_mail.Size = new Size(191, 27);
            tb_aj_mail.TabIndex = 3;
            // 
            // tb_aj_adress
            // 
            tb_aj_adress.Location = new Point(93, 102);
            tb_aj_adress.Name = "tb_aj_adress";
            tb_aj_adress.Size = new Size(191, 27);
            tb_aj_adress.TabIndex = 2;
            // 
            // tb_aj_prenom
            // 
            tb_aj_prenom.Location = new Point(93, 63);
            tb_aj_prenom.Name = "tb_aj_prenom";
            tb_aj_prenom.Size = new Size(191, 27);
            tb_aj_prenom.TabIndex = 1;
            // 
            // tb_aj_nom
            // 
            tb_aj_nom.Location = new Point(93, 30);
            tb_aj_nom.Name = "tb_aj_nom";
            tb_aj_nom.Size = new Size(191, 27);
            tb_aj_nom.TabIndex = 0;
            // 
            // btn_aj_photo
            // 
            btn_aj_photo.Location = new Point(12, 243);
            btn_aj_photo.Name = "btn_aj_photo";
            btn_aj_photo.Size = new Size(302, 29);
            btn_aj_photo.TabIndex = 2;
            btn_aj_photo.Text = "Ajouter une photo";
            btn_aj_photo.UseVisualStyleBackColor = true;
            // 
            // btn_aj_contact
            // 
            btn_aj_contact.Location = new Point(12, 595);
            btn_aj_contact.Name = "btn_aj_contact";
            btn_aj_contact.Size = new Size(302, 29);
            btn_aj_contact.TabIndex = 3;
            btn_aj_contact.Text = "Ajouter le contact";
            btn_aj_contact.UseVisualStyleBackColor = true;
            btn_aj_contact.Click += btn_aj_contact_Click;
            // 
            // AjoutPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(326, 650);
            Controls.Add(btn_aj_contact);
            Controls.Add(btn_aj_photo);
            Controls.Add(groupe_btn_ajout);
            Controls.Add(pct_ajout);
            Name = "AjoutPage";
            Text = "Ajout de contact";
            ((System.ComponentModel.ISupportInitialize)pct_ajout).EndInit();
            groupe_btn_ajout.ResumeLayout(false);
            groupe_btn_ajout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pct_ajout;
        private GroupBox groupe_btn_ajout;
        private Label lb_aj_nom;
        private TextBox tb_aj_tel;
        private TextBox tb_aj_mail;
        private TextBox tb_aj_adress;
        private TextBox tb_aj_prenom;
        private TextBox tb_aj_nom;
        private Label lb_aj_prenom;
        private Label lb_aj_adress;
        private Label lb_aj_mail;
        private Label lb_aj_tel;
        private Button btn_aj_photo;
        private Button btn_aj_contact;
        private Label lb_aj_ville;
        private TextBox tb_aj_ville;
        private Label lb_lst_grp;
        private ComboBox liste_grp;
    }
}