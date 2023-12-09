
namespace OS_Projekt
{
    partial class DigitalniPotpis
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
            this.buttonPotpisi = new System.Windows.Forms.Button();
            this.buttonProvjeriPotpis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPotpisi
            // 
            this.buttonPotpisi.Location = new System.Drawing.Point(12, 12);
            this.buttonPotpisi.Name = "buttonPotpisi";
            this.buttonPotpisi.Size = new System.Drawing.Size(156, 68);
            this.buttonPotpisi.TabIndex = 0;
            this.buttonPotpisi.Text = "Digitalno potpiši datoteku";
            this.buttonPotpisi.UseVisualStyleBackColor = true;
            this.buttonPotpisi.Click += new System.EventHandler(this.buttonPotpisi_Click);
            // 
            // buttonProvjeriPotpis
            // 
            this.buttonProvjeriPotpis.Location = new System.Drawing.Point(183, 12);
            this.buttonProvjeriPotpis.Name = "buttonProvjeriPotpis";
            this.buttonProvjeriPotpis.Size = new System.Drawing.Size(156, 68);
            this.buttonProvjeriPotpis.TabIndex = 1;
            this.buttonProvjeriPotpis.Text = "Provjeri digitalni potpis";
            this.buttonProvjeriPotpis.UseVisualStyleBackColor = true;
            this.buttonProvjeriPotpis.Click += new System.EventHandler(this.buttonProvjeriPotpis_Click);
            // 
            // DigitalniPotpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 97);
            this.Controls.Add(this.buttonProvjeriPotpis);
            this.Controls.Add(this.buttonPotpisi);
            this.Name = "DigitalniPotpis";
            this.Text = "DigitalniPotpis";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPotpisi;
        private System.Windows.Forms.Button buttonProvjeriPotpis;
    }
}