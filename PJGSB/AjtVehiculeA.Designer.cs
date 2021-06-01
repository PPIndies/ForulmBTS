
namespace PJGSB
{
    partial class AjtVehiculeA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjtVehiculeA));
            this.btn_retour = new System.Windows.Forms.Button();
            this.lbl_compte = new System.Windows.Forms.Label();
            this.btn_deconnecter = new System.Windows.Forms.Button();
            this.txtbox_nbr_chevaux = new System.Windows.Forms.TextBox();
            this.txtbox_nom_vehi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list_vehi = new System.Windows.Forms.ListBox();
            this.btn_cree = new System.Windows.Forms.Button();
            this.btn_suppr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_retour
            // 
            this.btn_retour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_retour.Image = ((System.Drawing.Image)(resources.GetObject("btn_retour.Image")));
            this.btn_retour.Location = new System.Drawing.Point(8, 7);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(60, 51);
            this.btn_retour.TabIndex = 74;
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.button5_Click);
            // 
            // lbl_compte
            // 
            this.lbl_compte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_compte.AutoSize = true;
            this.lbl_compte.Location = new System.Drawing.Point(622, 17);
            this.lbl_compte.Name = "lbl_compte";
            this.lbl_compte.Size = new System.Drawing.Size(41, 13);
            this.lbl_compte.TabIndex = 73;
            this.lbl_compte.Text = "label13";
            // 
            // btn_deconnecter
            // 
            this.btn_deconnecter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_deconnecter.Image = ((System.Drawing.Image)(resources.GetObject("btn_deconnecter.Image")));
            this.btn_deconnecter.Location = new System.Drawing.Point(733, 7);
            this.btn_deconnecter.Name = "btn_deconnecter";
            this.btn_deconnecter.Size = new System.Drawing.Size(55, 51);
            this.btn_deconnecter.TabIndex = 72;
            this.btn_deconnecter.UseVisualStyleBackColor = true;
            this.btn_deconnecter.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtbox_nbr_chevaux
            // 
            this.txtbox_nbr_chevaux.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbox_nbr_chevaux.Location = new System.Drawing.Point(313, 207);
            this.txtbox_nbr_chevaux.Name = "txtbox_nbr_chevaux";
            this.txtbox_nbr_chevaux.Size = new System.Drawing.Size(100, 20);
            this.txtbox_nbr_chevaux.TabIndex = 70;
            this.txtbox_nbr_chevaux.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtbox_nom_vehi
            // 
            this.txtbox_nom_vehi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbox_nom_vehi.Location = new System.Drawing.Point(313, 171);
            this.txtbox_nom_vehi.Name = "txtbox_nom_vehi";
            this.txtbox_nom_vehi.Size = new System.Drawing.Size(100, 20);
            this.txtbox_nom_vehi.TabIndex = 69;
            this.txtbox_nom_vehi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Nom du vehicule";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Nombre de chevaux fiscaux";
            // 
            // list_vehi
            // 
            this.list_vehi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.list_vehi.FormattingEnabled = true;
            this.list_vehi.Location = new System.Drawing.Point(570, 80);
            this.list_vehi.Name = "list_vehi";
            this.list_vehi.Size = new System.Drawing.Size(152, 316);
            this.list_vehi.TabIndex = 64;
            this.list_vehi.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_cree
            // 
            this.btn_cree.Enabled = false;
            this.btn_cree.Location = new System.Drawing.Point(338, 269);
            this.btn_cree.Name = "btn_cree";
            this.btn_cree.Size = new System.Drawing.Size(75, 23);
            this.btn_cree.TabIndex = 75;
            this.btn_cree.Text = "Crée";
            this.btn_cree.UseVisualStyleBackColor = true;
            this.btn_cree.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_suppr
            // 
            this.btn_suppr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_suppr.Location = new System.Drawing.Point(206, 269);
            this.btn_suppr.Name = "btn_suppr";
            this.btn_suppr.Size = new System.Drawing.Size(75, 23);
            this.btn_suppr.TabIndex = 76;
            this.btn_suppr.Text = "Supprimé";
            this.btn_suppr.UseVisualStyleBackColor = true;
            this.btn_suppr.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 24);
            this.label2.TabIndex = 77;
            this.label2.Text = "Ajouter nouveau véhicule";
            // 
            // AjtVehiculeA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_suppr);
            this.Controls.Add(this.btn_cree);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.lbl_compte);
            this.Controls.Add(this.btn_deconnecter);
            this.Controls.Add(this.txtbox_nbr_chevaux);
            this.Controls.Add(this.txtbox_nom_vehi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_vehi);
            this.Name = "AjtVehiculeA";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.Label lbl_compte;
        private System.Windows.Forms.Button btn_deconnecter;
        private System.Windows.Forms.TextBox txtbox_nbr_chevaux;
        private System.Windows.Forms.TextBox txtbox_nom_vehi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_vehi;
        private System.Windows.Forms.Button btn_cree;
        private System.Windows.Forms.Button btn_suppr;
        private System.Windows.Forms.Label label2;
    }
}