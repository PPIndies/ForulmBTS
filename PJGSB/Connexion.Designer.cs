
namespace PJGSB
{
    partial class Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_connecter = new System.Windows.Forms.Button();
            this.txtBox_id = new System.Windows.Forms.TextBox();
            this.txtBox_mdp = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 2;
            // 
            // btn_connecter
            // 
            this.btn_connecter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_connecter.Font = new System.Drawing.Font("Microsoft YaHei", 18F);
            this.btn_connecter.Location = new System.Drawing.Point(331, 401);
            this.btn_connecter.Name = "btn_connecter";
            this.btn_connecter.Size = new System.Drawing.Size(182, 49);
            this.btn_connecter.TabIndex = 3;
            this.btn_connecter.Text = "Se connecter";
            this.btn_connecter.UseVisualStyleBackColor = true;
            this.btn_connecter.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox_id
            // 
            this.txtBox_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBox_id.Location = new System.Drawing.Point(395, 316);
            this.txtBox_id.Name = "txtBox_id";
            this.txtBox_id.Size = new System.Drawing.Size(360, 20);
            this.txtBox_id.TabIndex = 4;
            // 
            // txtBox_mdp
            // 
            this.txtBox_mdp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBox_mdp.Location = new System.Drawing.Point(395, 360);
            this.txtBox_mdp.Name = "txtBox_mdp";
            this.txtBox_mdp.Size = new System.Drawing.Size(360, 20);
            this.txtBox_mdp.TabIndex = 5;
            this.txtBox_mdp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(249, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBox_mdp);
            this.Controls.Add(this.txtBox_id);
            this.Controls.Add(this.btn_connecter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Connexion";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_connecter;
        private System.Windows.Forms.TextBox txtBox_id;
        private System.Windows.Forms.TextBox txtBox_mdp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

