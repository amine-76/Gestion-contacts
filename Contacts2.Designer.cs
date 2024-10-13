
namespace Gestion_de_contact
{
    partial class Contacts2
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
            components = new System.ComponentModel.Container();
            Label lb_np;
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            recherche = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            My_list_contacts = new ListBox();
            list_group = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lb_adresse = new Label();
            lb_nom_prenom = new Label();
            lb_group = new Label();
            lb_np = new Label();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lb_np
            // 
            lb_np.AutoSize = true;
            lb_np.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_np.Location = new Point(180, 254);
            lb_np.Name = "lb_np";
            lb_np.Size = new Size(196, 41);
            lb_np.TabIndex = 6;
            lb_np.Text = "Nom Prénom";
            lb_np.TextAlign = ContentAlignment.TopCenter;
            lb_np.Click += lb_np_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 451);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(recherche);
            groupBox2.Location = new Point(0, 383);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(392, 65);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Recherche : ";
            // 
            // recherche
            // 
            recherche.Location = new Point(81, 26);
            recherche.Name = "recherche";
            recherche.Size = new Size(229, 27);
            recherche.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(128, 348);
            button1.Name = "button1";
            button1.Size = new Size(147, 29);
            button1.TabIndex = 2;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(My_list_contacts);
            groupBox1.Controls.Add(lb_np);
            groupBox1.Controls.Add(list_group);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 342);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contacts";
            // 
            // My_list_contacts
            // 
            My_list_contacts.FormattingEnabled = true;
            My_list_contacts.Location = new Point(12, 60);
            My_list_contacts.Name = "My_list_contacts";
            My_list_contacts.Size = new Size(364, 244);
            My_list_contacts.TabIndex = 1;
            My_list_contacts.SelectedIndexChanged += My_list_contacts_SelectedIndexChanged;
            // 
            // list_group
            // 
            list_group.DropDownStyle = ComboBoxStyle.DropDownList;
            list_group.FormattingEnabled = true;
            list_group.Location = new Point(12, 26);
            list_group.Name = "list_group";
            list_group.Size = new Size(364, 28);
            list_group.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 194);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lb_adresse);
            panel2.Controls.Add(lb_nom_prenom);
            panel2.Controls.Add(lb_group);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(398, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 448);
            panel2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 349);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 10;
            label5.Text = "adress@mail.com";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 309);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 9;
            label4.Text = "07 01 02 03  ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 272);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 8;
            label3.Text = "adress@mail.com";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 349);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 7;
            label2.Text = "Ville : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 309);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 6;
            label1.Text = "Tél : ";
            label1.Click += label1_Click_1;
            // 
            // lb_adresse
            // 
            lb_adresse.AutoSize = true;
            lb_adresse.Location = new Point(35, 272);
            lb_adresse.Name = "lb_adresse";
            lb_adresse.Size = new Size(49, 20);
            lb_adresse.TabIndex = 5;
            lb_adresse.Text = "Mail : ";
            // 
            // lb_nom_prenom
            // 
            lb_nom_prenom.AutoSize = true;
            lb_nom_prenom.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_nom_prenom.Location = new Point(102, 206);
            lb_nom_prenom.Name = "lb_nom_prenom";
            lb_nom_prenom.Size = new Size(204, 41);
            lb_nom_prenom.TabIndex = 4;
            lb_nom_prenom.Text = "Nom Prénom ";
            lb_nom_prenom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_group
            // 
            lb_group.AutoSize = true;
            lb_group.Location = new Point(346, 172);
            lb_group.Name = "lb_group";
            lb_group.Size = new Size(58, 20);
            lb_group.TabIndex = 3;
            lb_group.Text = "Groupe";
            // 
            // Contacts2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Contacts2";
            Text = "Liste des contacts";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }





        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private ComboBox list_group;
        private Button button1;
        private ListBox My_list_contacts;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private TextBox recherche;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox1;
        private Label lb_np;
        private Panel panel2;
        private Label lb_nom_prenom;
        private Label lb_group;
        private Label label1;
        private Label lb_adresse;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
    }
}