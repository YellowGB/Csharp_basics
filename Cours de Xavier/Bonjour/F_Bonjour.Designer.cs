
namespace Bonjour
{
    partial class F_Bonjour
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
            this.LblBonjour = new System.Windows.Forms.Label();
            this.CmdFr = new System.Windows.Forms.Button();
            this.CmdEn = new System.Windows.Forms.Button();
            this.CmdDe = new System.Windows.Forms.Button();
            this.CmdFin = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblBonjour
            // 
            this.LblBonjour.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBonjour.Location = new System.Drawing.Point(300, 98);
            this.LblBonjour.Name = "LblBonjour";
            this.LblBonjour.Size = new System.Drawing.Size(185, 120);
            this.LblBonjour.TabIndex = 0;
            this.LblBonjour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmdFr
            // 
            this.CmdFr.Location = new System.Drawing.Point(148, 270);
            this.CmdFr.Name = "CmdFr";
            this.CmdFr.Size = new System.Drawing.Size(92, 38);
            this.CmdFr.TabIndex = 1;
            this.CmdFr.Text = "Français";
            this.CmdFr.UseVisualStyleBackColor = true;
            this.CmdFr.Click += new System.EventHandler(this.CmdFr_Click);
            // 
            // CmdEn
            // 
            this.CmdEn.Location = new System.Drawing.Point(337, 270);
            this.CmdEn.Name = "CmdEn";
            this.CmdEn.Size = new System.Drawing.Size(92, 38);
            this.CmdEn.TabIndex = 2;
            this.CmdEn.Text = "Anglais";
            this.CmdEn.UseVisualStyleBackColor = true;
            this.CmdEn.Click += new System.EventHandler(this.CmdEn_Click);
            // 
            // CmdDe
            // 
            this.CmdDe.Location = new System.Drawing.Point(533, 270);
            this.CmdDe.Name = "CmdDe";
            this.CmdDe.Size = new System.Drawing.Size(92, 38);
            this.CmdDe.TabIndex = 3;
            this.CmdDe.Text = "Allemand";
            this.CmdDe.UseVisualStyleBackColor = true;
            this.CmdDe.Click += new System.EventHandler(this.CmdDe_Click);
            // 
            // CmdFin
            // 
            this.CmdFin.Location = new System.Drawing.Point(337, 350);
            this.CmdFin.Name = "CmdFin";
            this.CmdFin.Size = new System.Drawing.Size(92, 38);
            this.CmdFin.TabIndex = 4;
            this.CmdFin.Text = "Terminer";
            this.CmdFin.UseVisualStyleBackColor = true;
            this.CmdFin.Click += new System.EventHandler(this.CmdFin_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // F_Bonjour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdFin);
            this.Controls.Add(this.CmdDe);
            this.Controls.Add(this.CmdEn);
            this.Controls.Add(this.CmdFr);
            this.Controls.Add(this.LblBonjour);
            this.Name = "F_Bonjour";
            this.Text = "Bonjour";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblBonjour;
        private System.Windows.Forms.Button CmdFr;
        private System.Windows.Forms.Button CmdEn;
        private System.Windows.Forms.Button CmdDe;
        private System.Windows.Forms.Button CmdFin;
        private System.Windows.Forms.Timer timer1;
    }
}

