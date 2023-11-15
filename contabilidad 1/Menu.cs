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
    public partial class Menu : Form
    {
        
        
        public Menu()
        {
            InitializeComponent();
            
        }

        private void BotonLD_Click(object sender, EventArgs e)
        {
            try
            {
                LibroDiario libroDiario = new LibroDiario();
                Show(libroDiario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir Libro Diario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BotonLM_Click(object sender, EventArgs e)
        {
            LibroMayor libroMayor = new LibroMayor();
            Close();
            throw new System.NotImplementedException();
        }

        private void BotonPC_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}