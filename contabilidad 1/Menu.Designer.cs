namespace contabilidad_1
{
    partial class Menu
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
            this.BotonLD = new System.Windows.Forms.Button();
            this.BotonLM = new System.Windows.Forms.Button();
            this.BotonPC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonLD
            // 
            this.BotonLD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonLD.Location = new System.Drawing.Point(128, 230);
            this.BotonLD.Margin = new System.Windows.Forms.Padding(4);
            this.BotonLD.Name = "BotonLD";
            this.BotonLD.Size = new System.Drawing.Size(153, 139);
            this.BotonLD.TabIndex = 0;
            this.BotonLD.Text = "Libro Diario";
            this.BotonLD.UseVisualStyleBackColor = false;
            this.BotonLD.Click += new System.EventHandler(this.BotonLD_Click);
            // 
            // BotonLM
            // 
            this.BotonLM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonLM.Location = new System.Drawing.Point(449, 230);
            this.BotonLM.Margin = new System.Windows.Forms.Padding(4);
            this.BotonLM.Name = "BotonLM";
            this.BotonLM.Size = new System.Drawing.Size(153, 139);
            this.BotonLM.TabIndex = 1;
            this.BotonLM.Text = "Libro Mayores";
            this.BotonLM.UseVisualStyleBackColor = false;
            this.BotonLM.Click += new System.EventHandler(this.BotonLM_Click);
            // 
            // BotonPC
            // 
            this.BotonPC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonPC.Location = new System.Drawing.Point(782, 230);
            this.BotonPC.Margin = new System.Windows.Forms.Padding(4);
            this.BotonPC.Name = "BotonPC";
            this.BotonPC.Size = new System.Drawing.Size(153, 139);
            this.BotonPC.TabIndex = 2;
            this.BotonPC.Text = "Plan de cuentas";
            this.BotonPC.UseVisualStyleBackColor = false;
            this.BotonPC.Click += new System.EventHandler(this.BotonPC_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BotonPC);
            this.Controls.Add(this.BotonLM);
            this.Controls.Add(this.BotonLD);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button BotonPC;

        private System.Windows.Forms.Button BotonLM;

        private System.Windows.Forms.Button BotonLD;

        #endregion
    }
}