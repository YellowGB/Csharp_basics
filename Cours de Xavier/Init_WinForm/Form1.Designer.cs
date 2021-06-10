
namespace Init_WinForm
{
    partial class Form1
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
            this.CmdFermer = new System.Windows.Forms.Button();
            this.LblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CmdFermer
            // 
            this.CmdFermer.Location = new System.Drawing.Point(594, 382);
            this.CmdFermer.Name = "CmdFermer";
            this.CmdFermer.Size = new System.Drawing.Size(171, 23);
            this.CmdFermer.TabIndex = 0;
            this.CmdFermer.Text = "Fermer la fenêtre";
            this.CmdFermer.UseVisualStyleBackColor = true;
            this.CmdFermer.Click += new System.EventHandler(this.CmdFermer_Click);
            // 
            // LblTime
            // 
            this.LblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.Location = new System.Drawing.Point(212, 136);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(355, 115);
            this.LblTime.TabIndex = 1;
            this.LblTime.Text = "label1";
            this.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.CmdFermer);
            this.Name = "Form1";
            this.Text = "Mon Horloge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdFermer;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Timer timer1;
    }
}

