using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace contabilidad_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonLD_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario (supongamos que se llama FormLibroDiario)
            Form2 form2 = new Form2();

            // Mostrar el nuevo formulario
            form2.Show();
            this.Hide();

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}