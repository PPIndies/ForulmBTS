
namespace PJGSB
{
    partial class MenuA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuA));
            this.btn_deconnecter = new System.Windows.Forms.Button();
            this.btn_AjoutUtl = new System.Windows.Forms.Button();
            this.lbl_compte = new System.Windows.Forms.Label();
            this.btn_listUtlA = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_vehiPro = new System.Windows.Forms.Button();
            this.btn_listMission = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_deconnecter
            // 
            this.btn_deconnecter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_deconnecter.Image = ((System.Drawing.Image)(resources.GetObject("btn_deconnecter.Image")));
            this.btn_deconnecter.Location = new System.Drawing.Point(734, 12);
            this.btn_deconnecter.Name = "btn_deconnecter";
            this.btn_deconnecter.Size = new System.Drawing.Size(58, 61);
            this.btn_deconnecter.TabIndex = 2;
            this.btn_deconnecter.UseVisualStyleBackColor = true;
            this.btn_deconnecter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_AjoutUtl
            // 
            this.btn_AjoutUtl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AjoutUtl.Image = ((System.Drawing.Image)(resources.GetObject("btn_AjoutUtl.Image")));
            this.btn_AjoutUtl.Location = new System.Drawing.Point(84, 176);
            this.btn_AjoutUtl.Name = "btn_AjoutUtl";
            this.btn_AjoutUtl.Size = new System.Drawing.Size(314, 94);
            this.btn_AjoutUtl.TabIndex = 3;
            this.btn_AjoutUtl.UseVisualStyleBackColor = true;
            this.btn_AjoutUtl.Click += new System.EventHandler(this.btn_cr_utl_Click);
            // 
            // lbl_compte
            // 
            this.lbl_compte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_compte.AutoSize = true;
            this.lbl_compte.Location = new System.Drawing.Point(656, 12);
            this.lbl_compte.Name = "lbl_compte";
            this.lbl_compte.Size = new System.Drawing.Size(35, 13);
            this.lbl_compte.TabIndex = 4;
            this.lbl_compte.Text = "label1";
            // 
            // btn_listUtlA
            // 
            this.btn_listUtlA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_listUtlA.Image = ((System.Drawing.Image)(resources.GetObject("btn_listUtlA.Image")));
            this.btn_listUtlA.Location = new System.Drawing.Point(442, 176);
            this.btn_listUtlA.Name = "btn_listUtlA";
            this.btn_listUtlA.Size = new System.Drawing.Size(314, 94);
            this.btn_listUtlA.TabIndex = 5;
            this.btn_listUtlA.UseVisualStyleBackColor = true;
            this.btn_listUtlA.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_vehiPro
            // 
            this.btn_vehiPro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_vehiPro.Image = ((System.Drawing.Image)(resources.GetObject("btn_vehiPro.Image")));
            this.btn_vehiPro.Location = new System.Drawing.Point(84, 291);
            this.btn_vehiPro.Name = "btn_vehiPro";
            this.btn_vehiPro.Size = new System.Drawing.Size(314, 88);
            this.btn_vehiPro.TabIndex = 7;
            this.btn_vehiPro.UseVisualStyleBackColor = true;
            this.btn_vehiPro.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_listMission
            // 
            this.btn_listMission.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_listMission.Image = ((System.Drawing.Image)(resources.GetObject("btn_listMission.Image")));
            this.btn_listMission.Location = new System.Drawing.Point(442, 291);
            this.btn_listMission.Name = "btn_listMission";
            this.btn_listMission.Size = new System.Drawing.Size(314, 88);
            this.btn_listMission.TabIndex = 8;
            this.btn_listMission.UseVisualStyleBackColor = true;
            this.btn_listMission.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Menu Comptable";
            // 
            // MenuA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_listMission);
            this.Controls.Add(this.btn_vehiPro);
            this.Controls.Add(this.btn_listUtlA);
            this.Controls.Add(this.lbl_compte);
            this.Controls.Add(this.btn_AjoutUtl);
            this.Controls.Add(this.btn_deconnecter);
            this.Name = "MenuA";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.MenuA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_deconnecter;
        private System.Windows.Forms.Button btn_AjoutUtl;
        private System.Windows.Forms.Label lbl_compte;
        private System.Windows.Forms.Button btn_listUtlA;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_vehiPro;
        private System.Windows.Forms.Button btn_listMission;
        private System.Windows.Forms.Label label2;
    }
}