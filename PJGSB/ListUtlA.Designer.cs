
namespace PJGSB
{
    partial class ListUtlA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListUtlA));
            this.label5 = new System.Windows.Forms.Label();
            this.btn_suppr = new System.Windows.Forms.Button();
            this.Radio_cpt = new System.Windows.Forms.RadioButton();
            this.Radio_utl = new System.Windows.Forms.RadioButton();
            this.txtBox_filtre = new System.Windows.Forms.TextBox();
            this.lbl_nom1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_pnom1 = new System.Windows.Forms.Label();
            this.list_utl = new System.Windows.Forms.ListBox();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_pnom = new System.Windows.Forms.Label();
            this.lbl_mdp = new System.Windows.Forms.Label();
            this.lbl_poste = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBox_mdp = new System.Windows.Forms.TextBox();
            this.btn_validemdp = new System.Windows.Forms.Button();
            this.lbl_ville = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbBox_filtre = new System.Windows.Forms.ComboBox();
            this.btn_deconnecter = new System.Windows.Forms.Button();
            this.lbl_compte = new System.Windows.Forms.Label();
            this.btn_retour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "ville";
            // 
            // btn_suppr
            // 
            this.btn_suppr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_suppr.Location = new System.Drawing.Point(460, 394);
            this.btn_suppr.Name = "btn_suppr";
            this.btn_suppr.Size = new System.Drawing.Size(207, 23);
            this.btn_suppr.TabIndex = 45;
            this.btn_suppr.Text = "Supprimer l\'utilisateur";
            this.btn_suppr.UseVisualStyleBackColor = true;
            this.btn_suppr.Click += new System.EventHandler(this.button2_Click);
            // 
            // Radio_cpt
            // 
            this.Radio_cpt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Radio_cpt.AutoSize = true;
            this.Radio_cpt.Location = new System.Drawing.Point(506, 260);
            this.Radio_cpt.Name = "Radio_cpt";
            this.Radio_cpt.Size = new System.Drawing.Size(74, 17);
            this.Radio_cpt.TabIndex = 40;
            this.Radio_cpt.TabStop = true;
            this.Radio_cpt.Text = "comptable";
            this.Radio_cpt.UseVisualStyleBackColor = true;
            // 
            // Radio_utl
            // 
            this.Radio_utl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Radio_utl.AutoSize = true;
            this.Radio_utl.Location = new System.Drawing.Point(421, 260);
            this.Radio_utl.Name = "Radio_utl";
            this.Radio_utl.Size = new System.Drawing.Size(69, 17);
            this.Radio_utl.TabIndex = 39;
            this.Radio_utl.TabStop = true;
            this.Radio_utl.Text = "utilisateur";
            this.Radio_utl.UseVisualStyleBackColor = true;
            // 
            // txtBox_filtre
            // 
            this.txtBox_filtre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBox_filtre.AutoCompleteCustomSource.AddRange(new string[] {
            "Prenom ",
            "Nom",
            "Ville",
            "Id",
            "poste"});
            this.txtBox_filtre.Location = new System.Drawing.Point(67, 101);
            this.txtBox_filtre.Name = "txtBox_filtre";
            this.txtBox_filtre.Size = new System.Drawing.Size(200, 20);
            this.txtBox_filtre.TabIndex = 38;
            this.txtBox_filtre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_nom1
            // 
            this.lbl_nom1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nom1.AutoSize = true;
            this.lbl_nom1.Location = new System.Drawing.Point(426, 68);
            this.lbl_nom1.Name = "lbl_nom1";
            this.lbl_nom1.Size = new System.Drawing.Size(27, 13);
            this.lbl_nom1.TabIndex = 37;
            this.lbl_nom1.Text = "nom";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "poste";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "mdp";
            // 
            // lbl_pnom1
            // 
            this.lbl_pnom1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_pnom1.AutoSize = true;
            this.lbl_pnom1.Location = new System.Drawing.Point(426, 101);
            this.lbl_pnom1.Name = "lbl_pnom1";
            this.lbl_pnom1.Size = new System.Drawing.Size(33, 13);
            this.lbl_pnom1.TabIndex = 34;
            this.lbl_pnom1.Text = "pnom";
            // 
            // list_utl
            // 
            this.list_utl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.list_utl.FormattingEnabled = true;
            this.list_utl.Location = new System.Drawing.Point(84, 128);
            this.list_utl.Name = "list_utl";
            this.list_utl.Size = new System.Drawing.Size(183, 290);
            this.list_utl.TabIndex = 33;
            this.list_utl.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbl_nom
            // 
            this.lbl_nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(531, 68);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(0, 13);
            this.lbl_nom.TabIndex = 48;
            // 
            // lbl_pnom
            // 
            this.lbl_pnom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_pnom.AutoSize = true;
            this.lbl_pnom.Location = new System.Drawing.Point(531, 101);
            this.lbl_pnom.Name = "lbl_pnom";
            this.lbl_pnom.Size = new System.Drawing.Size(0, 13);
            this.lbl_pnom.TabIndex = 49;
            // 
            // lbl_mdp
            // 
            this.lbl_mdp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_mdp.AutoSize = true;
            this.lbl_mdp.Location = new System.Drawing.Point(530, 185);
            this.lbl_mdp.Name = "lbl_mdp";
            this.lbl_mdp.Size = new System.Drawing.Size(0, 13);
            this.lbl_mdp.TabIndex = 50;
            // 
            // lbl_poste
            // 
            this.lbl_poste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_poste.AutoSize = true;
            this.lbl_poste.Location = new System.Drawing.Point(531, 140);
            this.lbl_poste.Name = "lbl_poste";
            this.lbl_poste.Size = new System.Drawing.Size(0, 13);
            this.lbl_poste.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Modifier le mot de passe";
            // 
            // txtBox_mdp
            // 
            this.txtBox_mdp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBox_mdp.Location = new System.Drawing.Point(567, 217);
            this.txtBox_mdp.Name = "txtBox_mdp";
            this.txtBox_mdp.Size = new System.Drawing.Size(100, 20);
            this.txtBox_mdp.TabIndex = 53;
            // 
            // btn_validemdp
            // 
            this.btn_validemdp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_validemdp.Location = new System.Drawing.Point(673, 214);
            this.btn_validemdp.Name = "btn_validemdp";
            this.btn_validemdp.Size = new System.Drawing.Size(75, 23);
            this.btn_validemdp.TabIndex = 54;
            this.btn_validemdp.Text = "Valider";
            this.btn_validemdp.UseVisualStyleBackColor = true;
            this.btn_validemdp.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_ville
            // 
            this.lbl_ville.AutoSize = true;
            this.lbl_ville.Location = new System.Drawing.Point(524, 303);
            this.lbl_ville.Name = "lbl_ville";
            this.lbl_ville.Size = new System.Drawing.Size(0, 13);
            this.lbl_ville.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(418, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "Nombre de mission effectuer";
            // 
            // cbBox_filtre
            // 
            this.cbBox_filtre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbBox_filtre.AutoCompleteCustomSource.AddRange(new string[] {
            "Prenom",
            "Nom",
            "Id",
            "Ville",
            "Poste",
            ""});
            this.cbBox_filtre.FormattingEnabled = true;
            this.cbBox_filtre.Location = new System.Drawing.Point(228, 101);
            this.cbBox_filtre.Name = "cbBox_filtre";
            this.cbBox_filtre.Size = new System.Drawing.Size(70, 21);
            this.cbBox_filtre.TabIndex = 57;
            // 
            // btn_deconnecter
            // 
            this.btn_deconnecter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_deconnecter.Image = ((System.Drawing.Image)(resources.GetObject("btn_deconnecter.Image")));
            this.btn_deconnecter.Location = new System.Drawing.Point(730, 12);
            this.btn_deconnecter.Name = "btn_deconnecter";
            this.btn_deconnecter.Size = new System.Drawing.Size(62, 58);
            this.btn_deconnecter.TabIndex = 58;
            this.btn_deconnecter.UseVisualStyleBackColor = true;
            this.btn_deconnecter.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbl_compte
            // 
            this.lbl_compte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_compte.AutoSize = true;
            this.lbl_compte.Location = new System.Drawing.Point(626, 17);
            this.lbl_compte.Name = "lbl_compte";
            this.lbl_compte.Size = new System.Drawing.Size(41, 13);
            this.lbl_compte.TabIndex = 59;
            this.lbl_compte.Text = "label13";
            // 
            // btn_retour
            // 
            this.btn_retour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_retour.Image = ((System.Drawing.Image)(resources.GetObject("btn_retour.Image")));
            this.btn_retour.Location = new System.Drawing.Point(12, 7);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(56, 53);
            this.btn_retour.TabIndex = 60;
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 61;
            this.label1.Text = "Liste des utilisateurs";
            // 
            // ListUtlA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.lbl_compte);
            this.Controls.Add(this.btn_deconnecter);
            this.Controls.Add(this.cbBox_filtre);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_ville);
            this.Controls.Add(this.btn_validemdp);
            this.Controls.Add(this.txtBox_mdp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_poste);
            this.Controls.Add(this.lbl_mdp);
            this.Controls.Add(this.lbl_pnom);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_suppr);
            this.Controls.Add(this.Radio_cpt);
            this.Controls.Add(this.Radio_utl);
            this.Controls.Add(this.txtBox_filtre);
            this.Controls.Add(this.lbl_nom1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_pnom1);
            this.Controls.Add(this.list_utl);
            this.Name = "ListUtlA";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ListUtlA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_suppr;
        private System.Windows.Forms.RadioButton Radio_cpt;
        private System.Windows.Forms.RadioButton Radio_utl;
        private System.Windows.Forms.TextBox txtBox_filtre;
        private System.Windows.Forms.Label lbl_nom1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_pnom1;
        private System.Windows.Forms.ListBox list_utl;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_pnom;
        private System.Windows.Forms.Label lbl_mdp;
        private System.Windows.Forms.Label lbl_poste;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBox_mdp;
        private System.Windows.Forms.Button btn_validemdp;
        private System.Windows.Forms.Label lbl_ville;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbBox_filtre;
        private System.Windows.Forms.Button btn_deconnecter;
        private System.Windows.Forms.Label lbl_compte;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.Label label1;
    }
}