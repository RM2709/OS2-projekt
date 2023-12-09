
namespace OS_Projekt
{
    partial class SimetricnaKriptografija
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
            this.buttonSifriraj = new System.Windows.Forms.Button();
            this.buttonDesifriraj = new System.Windows.Forms.Button();
            this.buttonStvoriKljuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSifriraj
            // 
            this.buttonSifriraj.Location = new System.Drawing.Point(14, 12);
            this.buttonSifriraj.Name = "buttonSifriraj";
            this.buttonSifriraj.Size = new System.Drawing.Size(181, 77);
            this.buttonSifriraj.TabIndex = 0;
            this.buttonSifriraj.Text = "Kriptiraj";
            this.buttonSifriraj.UseVisualStyleBackColor = true;
            this.buttonSifriraj.Click += new System.EventHandler(this.buttonSifriraj_Click);
            // 
            // buttonDesifriraj
            // 
            this.buttonDesifriraj.Location = new System.Drawing.Point(420, 12);
            this.buttonDesifriraj.Name = "buttonDesifriraj";
            this.buttonDesifriraj.Size = new System.Drawing.Size(175, 77);
            this.buttonDesifriraj.TabIndex = 1;
            this.buttonDesifriraj.Text = "Dekriptiraj";
            this.buttonDesifriraj.UseVisualStyleBackColor = true;
            this.buttonDesifriraj.Click += new System.EventHandler(this.buttonDesifriraj_Click);
            // 
            // buttonStvoriKljuc
            // 
            this.buttonStvoriKljuc.Location = new System.Drawing.Point(215, 12);
            this.buttonStvoriKljuc.Name = "buttonStvoriKljuc";
            this.buttonStvoriKljuc.Size = new System.Drawing.Size(181, 77);
            this.buttonStvoriKljuc.TabIndex = 2;
            this.buttonStvoriKljuc.Text = "Stvori ključ";
            this.buttonStvoriKljuc.UseVisualStyleBackColor = true;
            this.buttonStvoriKljuc.Click += new System.EventHandler(this.buttonStvoriKljuc_Click);
            // 
            // SimetricnaKriptografija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 111);
            this.Controls.Add(this.buttonStvoriKljuc);
            this.Controls.Add(this.buttonDesifriraj);
            this.Controls.Add(this.buttonSifriraj);
            this.Name = "SimetricnaKriptografija";
            this.Text = "SimetricnaKriptografija";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSifriraj;
        private System.Windows.Forms.Button buttonDesifriraj;
        private System.Windows.Forms.Button buttonStvoriKljuc;
    }
}