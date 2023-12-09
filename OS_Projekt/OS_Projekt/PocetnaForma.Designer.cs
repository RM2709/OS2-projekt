
namespace OS_Projekt
{
    partial class PocetnaForma
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
            this.buttonSimetricna = new System.Windows.Forms.Button();
            this.buttonAsimetricna = new System.Windows.Forms.Button();
            this.buttonSazetak = new System.Windows.Forms.Button();
            this.buttonDigitalniPotpis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSimetricna
            // 
            this.buttonSimetricna.Location = new System.Drawing.Point(12, 12);
            this.buttonSimetricna.Name = "buttonSimetricna";
            this.buttonSimetricna.Size = new System.Drawing.Size(200, 75);
            this.buttonSimetricna.TabIndex = 0;
            this.buttonSimetricna.Text = "Simetrična kriptografija";
            this.buttonSimetricna.UseVisualStyleBackColor = true;
            this.buttonSimetricna.Click += new System.EventHandler(this.buttonSimetricna_Click);
            // 
            // buttonAsimetricna
            // 
            this.buttonAsimetricna.Location = new System.Drawing.Point(12, 93);
            this.buttonAsimetricna.Name = "buttonAsimetricna";
            this.buttonAsimetricna.Size = new System.Drawing.Size(200, 75);
            this.buttonAsimetricna.TabIndex = 1;
            this.buttonAsimetricna.Text = "Asimetrična kriptografija";
            this.buttonAsimetricna.UseVisualStyleBackColor = true;
            this.buttonAsimetricna.Click += new System.EventHandler(this.buttonAsimetricna_Click);
            // 
            // buttonSazetak
            // 
            this.buttonSazetak.Location = new System.Drawing.Point(12, 174);
            this.buttonSazetak.Name = "buttonSazetak";
            this.buttonSazetak.Size = new System.Drawing.Size(200, 75);
            this.buttonSazetak.TabIndex = 2;
            this.buttonSazetak.Text = "Sažetak poruke";
            this.buttonSazetak.UseVisualStyleBackColor = true;
            this.buttonSazetak.Click += new System.EventHandler(this.buttonSazetak_Click);
            // 
            // buttonDigitalniPotpis
            // 
            this.buttonDigitalniPotpis.Location = new System.Drawing.Point(12, 255);
            this.buttonDigitalniPotpis.Name = "buttonDigitalniPotpis";
            this.buttonDigitalniPotpis.Size = new System.Drawing.Size(200, 75);
            this.buttonDigitalniPotpis.TabIndex = 3;
            this.buttonDigitalniPotpis.Text = "Digitalni potpis";
            this.buttonDigitalniPotpis.UseVisualStyleBackColor = true;
            this.buttonDigitalniPotpis.Click += new System.EventHandler(this.buttonDigitalniPotpis_Click);
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 359);
            this.Controls.Add(this.buttonDigitalniPotpis);
            this.Controls.Add(this.buttonSazetak);
            this.Controls.Add(this.buttonAsimetricna);
            this.Controls.Add(this.buttonSimetricna);
            this.Name = "PocetnaForma";
            this.Text = "Početna forma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSimetricna;
        private System.Windows.Forms.Button buttonAsimetricna;
        private System.Windows.Forms.Button buttonSazetak;
        private System.Windows.Forms.Button buttonDigitalniPotpis;
    }
}

