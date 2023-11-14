using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace contabilidad_1
{
    
    partial class Form2
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
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.Textolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Fecha
            // 
            this.Fecha.CalendarMonthBackground = System.Drawing.SystemColors.GrayText;
            this.Fecha.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Fecha.Location = new System.Drawing.Point(3, 26);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(193, 20);
            this.Fecha.TabIndex = 0;
            this.Fecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Textolabel
            // 
            this.Textolabel.Location = new System.Drawing.Point(51, 9);
            this.Textolabel.Name = "Textolabel";
            this.Textolabel.Size = new System.Drawing.Size(79, 14);
            this.Textolabel.TabIndex = 1;
            this.Textolabel.Text = "Ingrese Fecha";
            this.Textolabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Textolabel);
            this.Controls.Add(this.Fecha);
            this.Name = "Form2";
            this.Text = "Libro Diario";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label Textolabel;

        private System.Windows.Forms.DateTimePicker Fecha;

        #endregion
    }
}