namespace Gestion_de_contact
{
    partial class MyContacts
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_hello = new Label();
            btn_start = new Button();
            SuspendLayout();
            // 
            // label_hello
            // 
            label_hello.AutoSize = true;
            label_hello.Font = new Font("Segoe UI", 20F);
            label_hello.Location = new Point(49, 80);
            label_hello.Name = "label_hello";
            label_hello.Size = new Size(858, 46);
            label_hello.TabIndex = 0;
            label_hello.Text = "Romane <3   >>> tout les prénoms de filles aux monde ";
            label_hello.Click += label_hello_Click;
            // 
            // btn_start
            // 
            btn_start.Location = new Point(280, 218);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(202, 50);
            btn_start.TabIndex = 1;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += Button1_Click;
            // 
            // MyContacts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1005, 450);
            Controls.Add(btn_start);
            Controls.Add(label_hello);
            Name = "MyContacts";
            Text = "Contacts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_hello;
        private Button btn_start;
    }
}
