using System.ComponentModel;

namespace contabilidad_1
{
    partial class PlanCuentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonActivo = new System.Windows.Forms.RadioButton();
            this.buttonPasivo = new System.Windows.Forms.RadioButton();
            this.buttonRP = new System.Windows.Forms.RadioButton();
            this.buttonRN = new System.Windows.Forms.RadioButton();
            this.buttonPN = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo:";
            // 
            // buttonActivo
            // 
            this.buttonActivo.AutoSize = true;
            this.buttonActivo.Location = new System.Drawing.Point(141, 182);
            this.buttonActivo.Name = "buttonActivo";
            this.buttonActivo.Size = new System.Drawing.Size(65, 20);
            this.buttonActivo.TabIndex = 8;
            this.buttonActivo.TabStop = true;
            this.buttonActivo.Text = "Activo";
            this.buttonActivo.UseVisualStyleBackColor = true;
            this.buttonActivo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonPasivo
            // 
            this.buttonPasivo.AutoSize = true;
            this.buttonPasivo.Location = new System.Drawing.Point(141, 208);
            this.buttonPasivo.Name = "buttonPasivo";
            this.buttonPasivo.Size = new System.Drawing.Size(70, 20);
            this.buttonPasivo.TabIndex = 9;
            this.buttonPasivo.TabStop = true;
            this.buttonPasivo.Text = "Pasivo";
            this.buttonPasivo.UseVisualStyleBackColor = true;
            this.buttonPasivo.CheckedChanged += new System.EventHandler(this.buttonPasivo_CheckedChanged);
            // 
            // buttonRP
            // 
            this.buttonRP.AutoSize = true;
            this.buttonRP.Location = new System.Drawing.Point(141, 234);
            this.buttonRP.Name = "buttonRP";
            this.buttonRP.Size = new System.Drawing.Size(141, 20);
            this.buttonRP.TabIndex = 10;
            this.buttonRP.TabStop = true;
            this.buttonRP.Text = "Resultado Positivo";
            this.buttonRP.UseVisualStyleBackColor = true;
            this.buttonRP.CheckedChanged += new System.EventHandler(this.buttonRP_CheckedChanged);
            // 
            // buttonRN
            // 
            this.buttonRN.AutoSize = true;
            this.buttonRN.Location = new System.Drawing.Point(141, 260);
            this.buttonRN.Name = "buttonRN";
            this.buttonRN.Size = new System.Drawing.Size(148, 20);
            this.buttonRN.TabIndex = 11;
            this.buttonRN.TabStop = true;
            this.buttonRN.Text = "Resultado Negativo";
            this.buttonRN.UseVisualStyleBackColor = true;
            this.buttonRN.CheckedChanged += new System.EventHandler(this.buttonRN_CheckedChanged);
            // 
            // buttonPN
            // 
            this.buttonPN.AutoSize = true;
            this.buttonPN.Location = new System.Drawing.Point(141, 286);
            this.buttonPN.Name = "buttonPN";
            this.buttonPN.Size = new System.Drawing.Size(124, 20);
            this.buttonPN.TabIndex = 12;
            this.buttonPN.TabStop = true;
            this.buttonPN.Text = "Patrimonio Neto";
            this.buttonPN.UseVisualStyleBackColor = true;
            this.buttonPN.CheckedChanged += new System.EventHandler(this.buttonPN_CheckedChanged);
            // 
            // PlanCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 635);
            this.Controls.Add(this.buttonPN);
            this.Controls.Add(this.buttonRN);
            this.Controls.Add(this.buttonRP);
            this.Controls.Add(this.buttonPasivo);
            this.Controls.Add(this.buttonActivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "PlanCuentas";
            this.Text = "PlanCuentas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RadioButton buttonPasivo;
        private System.Windows.Forms.RadioButton buttonRP;
        private System.Windows.Forms.RadioButton buttonRN;
        private System.Windows.Forms.RadioButton buttonPN;

        private System.Windows.Forms.RadioButton buttonActivo;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}