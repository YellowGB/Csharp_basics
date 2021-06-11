
namespace GestStagiaire
{
    partial class FCreationStag
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.TxtSection = new System.Windows.Forms.TextBox();
            this.CmdValid = new System.Windows.Forms.Button();
            this.CmdFin = new System.Windows.Forms.Button();
            this.DtPNaissance = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Stagiaire :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Stagiaire :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom Stagiaire :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Section :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date Naissace :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(177, 67);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(196, 22);
            this.TxtId.TabIndex = 5;
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(177, 103);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(196, 22);
            this.TxtNom.TabIndex = 6;
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Location = new System.Drawing.Point(177, 139);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(196, 22);
            this.TxtPrenom.TabIndex = 7;
            // 
            // TxtSection
            // 
            this.TxtSection.Location = new System.Drawing.Point(177, 175);
            this.TxtSection.MaxLength = 5;
            this.TxtSection.Name = "TxtSection";
            this.TxtSection.Size = new System.Drawing.Size(196, 22);
            this.TxtSection.TabIndex = 8;
            // 
            // CmdValid
            // 
            this.CmdValid.Location = new System.Drawing.Point(100, 288);
            this.CmdValid.Name = "CmdValid";
            this.CmdValid.Size = new System.Drawing.Size(164, 41);
            this.CmdValid.TabIndex = 10;
            this.CmdValid.Text = "Enregistrer Stagiaire";
            this.CmdValid.UseVisualStyleBackColor = true;
            this.CmdValid.Click += new System.EventHandler(this.CmdValid_Click);
            // 
            // CmdFin
            // 
            this.CmdFin.Location = new System.Drawing.Point(312, 288);
            this.CmdFin.Name = "CmdFin";
            this.CmdFin.Size = new System.Drawing.Size(166, 41);
            this.CmdFin.TabIndex = 11;
            this.CmdFin.Text = "Terminer";
            this.CmdFin.UseVisualStyleBackColor = true;
            this.CmdFin.Click += new System.EventHandler(this.CmdFin_Click);
            // 
            // DtPNaissance
            // 
            this.DtPNaissance.Location = new System.Drawing.Point(177, 210);
            this.DtPNaissance.Name = "DtPNaissance";
            this.DtPNaissance.Size = new System.Drawing.Size(196, 22);
            this.DtPNaissance.TabIndex = 12;
            // 
            // FCreationStag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtPNaissance);
            this.Controls.Add(this.CmdFin);
            this.Controls.Add(this.CmdValid);
            this.Controls.Add(this.TxtSection);
            this.Controls.Add(this.TxtPrenom);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FCreationStag";
            this.Text = "Création d\'un stagiaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.TextBox TxtSection;
        private System.Windows.Forms.Button CmdValid;
        private System.Windows.Forms.Button CmdFin;
        private System.Windows.Forms.DateTimePicker DtPNaissance;
    }
}