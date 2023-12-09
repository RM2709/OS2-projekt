
namespace OS_Projekt
{
    partial class Sazetak
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
            this.textBoxDatoteka = new System.Windows.Forms.TextBox();
            this.buttonSazetak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv datoteke:";
            // 
            // textBoxDatoteka
            // 
            this.textBoxDatoteka.Location = new System.Drawing.Point(12, 26);
            this.textBoxDatoteka.Name = "textBoxDatoteka";
            this.textBoxDatoteka.Size = new System.Drawing.Size(177, 20);
            this.textBoxDatoteka.TabIndex = 1;
            // 
            // buttonSazetak
            // 
            this.buttonSazetak.Location = new System.Drawing.Point(12, 72);
            this.buttonSazetak.Name = "buttonSazetak";
            this.buttonSazetak.Size = new System.Drawing.Size(177, 75);
            this.buttonSazetak.TabIndex = 2;
            this.buttonSazetak.Text = "Izračunaj sažetak";
            this.buttonSazetak.UseVisualStyleBackColor = true;
            this.buttonSazetak.Click += new System.EventHandler(this.buttonSazetak_Click);
            // 
            // Sazetak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 172);
            this.Controls.Add(this.buttonSazetak);
            this.Controls.Add(this.textBoxDatoteka);
            this.Controls.Add(this.label1);
            this.Name = "Sazetak";
            this.Text = "Sazetak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDatoteka;
        private System.Windows.Forms.Button buttonSazetak;
    }
}