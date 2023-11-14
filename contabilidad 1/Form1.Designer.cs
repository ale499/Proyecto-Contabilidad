namespace contabilidad_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BotonLD = new System.Windows.Forms.Button();
            this.BotonLM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonLD
            // 
            this.BotonLD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonLD.Location = new System.Drawing.Point(73, 150);
            this.BotonLD.Name = "BotonLD";
            this.BotonLD.Size = new System.Drawing.Size(240, 113);
            this.BotonLD.TabIndex = 0;
            this.BotonLD.Text = "Libro Diario";
            this.BotonLD.UseVisualStyleBackColor = false;
            this.BotonLD.Click += new System.EventHandler(this.BotonLD_Click);
            // 
            // BotonLM
            // 
            this.BotonLM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonLM.Location = new System.Drawing.Point(468, 152);
            this.BotonLM.Name = "BotonLM";
            this.BotonLM.Size = new System.Drawing.Size(240, 113);
            this.BotonLM.TabIndex = 1;
            this.BotonLM.Text = "Libro Mayor";
            this.BotonLM.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonLM);
            this.Controls.Add(this.BotonLD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button BotonLM;

        private System.Windows.Forms.Button BotonLD;

        #endregion
    }
}