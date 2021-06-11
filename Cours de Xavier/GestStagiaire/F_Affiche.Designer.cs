
namespace GestStagiaire
{
    partial class F_Affiche
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
            this.DtPNaissance = new System.Windows.Forms.DateTimePicker();
            this.CmdFin = new System.Windows.Forms.Button();
            this.TxtSection = new System.Windows.Forms.TextBox();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DtPNaissance
            // 
            this.DtPNaissance.Location = new System.Drawing.Point(325, 237);
            this.DtPNaissance.Name = "DtPNaissance";
            this.DtPNaissance.Size = new System.Drawing.Size(196, 22);
            this.DtPNaissance.TabIndex = 24;
            // 
            // CmdFin
            // 
            this.CmdFin.Location = new System.Drawing.Point(340, 320);
            this.CmdFin.Name = "CmdFin";
            this.CmdFin.Size = new System.Drawing.Size(166, 41);
            this.CmdFin.TabIndex = 23;
            this.CmdFin.Text = "Terminer";
            this.CmdFin.UseVisualStyleBackColor = true;
            this.CmdFin.Click += new System.EventHandler(this.CmdFin_Click);
            // 
            // TxtSection
            // 
            this.TxtSection.Location = new System.Drawing.Point(325, 202);
            this.TxtSection.MaxLength = 5;
            this.TxtSection.Name = "TxtSection";
            this.TxtSection.Size = new System.Drawing.Size(196, 22);
            this.TxtSection.TabIndex = 21;
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Location = new System.Drawing.Point(325, 166);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(196, 22);
            this.TxtPrenom.TabIndex = 20;
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(325, 130);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(196, 22);
            this.TxtNom.TabIndex = 19;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(325, 94);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(196, 22);
            this.TxtId.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Date Naissace :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Section :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Prénom Stagiaire :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nom Stagiaire :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "N° Stagiaire :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // F_Affiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtPNaissance);
            this.Controls.Add(this.CmdFin);
            this.Controls.Add(this.TxtSection);
            this.Controls.Add(this.TxtPrenom);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_Affiche";
            this.Text = "Affichage du stagiaire N°";
            this.Load += new System.EventHandler(this.F_Affiche_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtPNaissance;
        private System.Windows.Forms.Button CmdFin;
        private System.Windows.Forms.TextBox TxtSection;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}