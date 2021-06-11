
namespace GestStagiaire
{
    partial class F_Choix
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
            this.CbStagiaire = new System.Windows.Forms.ComboBox();
            this.CmdValid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CbStagiaire
            // 
            this.CbStagiaire.FormattingEnabled = true;
            this.CbStagiaire.Location = new System.Drawing.Point(51, 31);
            this.CbStagiaire.Name = "CbStagiaire";
            this.CbStagiaire.Size = new System.Drawing.Size(286, 24);
            this.CbStagiaire.TabIndex = 0;
            this.CbStagiaire.SelectedIndexChanged += new System.EventHandler(this.CbStagiaire_SelectedIndexChanged);
            // 
            // CmdValid
            // 
            this.CmdValid.Location = new System.Drawing.Point(121, 89);
            this.CmdValid.Name = "CmdValid";
            this.CmdValid.Size = new System.Drawing.Size(161, 44);
            this.CmdValid.TabIndex = 1;
            this.CmdValid.Text = "Valider";
            this.CmdValid.UseVisualStyleBackColor = true;
            // 
            // F_Choix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 158);
            this.Controls.Add(this.CmdValid);
            this.Controls.Add(this.CbStagiaire);
            this.Name = "F_Choix";
            this.Text = "Choix du stagiaire";
            this.Load += new System.EventHandler(this.F_Choix_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CbStagiaire;
        private System.Windows.Forms.Button CmdValid;
    }
}