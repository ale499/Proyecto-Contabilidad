using System;
using System.Windows.Forms;

namespace contabilidad_1
{
    public partial class PlanCuentas : Form
    {
        public Cuenta cuenta;
        public PlanCuentas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cuenta.NombreCuenta = sender.ToString();
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked) {
                string texto = radioButton.Text;
                
            }
        }

        private void buttonActivo_CheckedChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void buttonPasivo_CheckedChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void buttonRP_CheckedChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void buttonRN_CheckedChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void buttonPN_CheckedChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}