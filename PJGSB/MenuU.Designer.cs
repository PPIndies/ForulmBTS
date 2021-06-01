
namespace PJGSB
{
    partial class MenuU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuU));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cr_utl = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.5F);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connecter  a un compte utilisateur ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(729, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 60);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // btn_cr_utl
            // 
            this.btn_cr_utl.Image = ((System.Drawing.Image)(resources.GetObject("btn_cr_utl.Image")));
            this.btn_cr_utl.Location = new System.Drawing.Point(101, 121);
            this.btn_cr_utl.Name = "btn_cr_utl";
            this.btn_cr_utl.Size = new System.Drawing.Size(314, 255);
            this.btn_cr_utl.TabIndex = 6;
            this.btn_cr_utl.UseVisualStyleBackColor = true;
            this.btn_cr_utl.Click += new System.EventHandler(this.btn_cr_utl_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(444, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(314, 255);
            this.button2.TabIndex = 7;
            this.button2.Text = "Voir la liste des mission";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenuU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_cr_utl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "MenuU";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MenuU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cr_utl;
        private System.Windows.Forms.Button button2;
    }
}