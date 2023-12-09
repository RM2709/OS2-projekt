
namespace OS_Projekt
{
    partial class AsimetricnaKriptografija
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
            this.buttonStvoriKljuceve = new System.Windows.Forms.Button();
            this.buttonDesifriraj = new System.Windows.Forms.Button();
            this.buttonSifriraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStvoriKljuceve
            // 
            this.buttonStvoriKljuceve.Location = new System.Drawing.Point(213, 12);
            this.buttonStvoriKljuceve.Name = "buttonStvoriKljuceve";
            this.buttonStvoriKljuceve.Size = new System.Drawing.Size(181, 77);
            this.buttonStvoriKljuceve.TabIndex = 5;
            this.buttonStvoriKljuceve.Text = "Stvori ključeve";
            this.buttonStvoriKljuceve.UseVisualStyleBackColor = true;
            this.buttonStvoriKljuceve.Click += new System.EventHandler(this.buttonStvoriKljuceve_Click);
            // 
            // buttonDesifriraj
            // 
            this.buttonDesifriraj.Location = new System.Drawing.Point(418, 12);
            this.buttonDesifriraj.Name = "buttonDesifriraj";
            this.buttonDesifriraj.Size = new System.Drawing.Size(175, 77);
            this.buttonDesifriraj.TabIndex = 4;
            this.buttonDesifriraj.Text = "Dekriptiraj";
            this.buttonDesifriraj.UseVisualStyleBackColor = true;
            this.buttonDesifriraj.Click += new System.EventHandler(this.buttonDesifriraj_Click);
            // 
            // buttonSifriraj
            // 
            this.buttonSifriraj.Location = new System.Drawing.Point(12, 12);
            this.buttonSifriraj.Name = "buttonSifriraj";
            this.buttonSifriraj.Size = new System.Drawing.Size(181, 77);
            this.buttonSifriraj.TabIndex = 3;
            this.buttonSifriraj.Text = "Kriptiraj";
            this.buttonSifriraj.UseVisualStyleBackColor = true;
            this.buttonSifriraj.Click += new System.EventHandler(this.buttonSifriraj_Click);
            // 
            // AsimetricnaKriptografija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 101);
            this.Controls.Add(this.buttonStvoriKljuceve);
            this.Controls.Add(this.buttonDesifriraj);
            this.Controls.Add(this.buttonSifriraj);
            this.Name = "AsimetricnaKriptografija";
            this.Text = "AsimetricnaKriptografija";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStvoriKljuceve;
        private System.Windows.Forms.Button buttonDesifriraj;
        private System.Windows.Forms.Button buttonSifriraj;
    }
}