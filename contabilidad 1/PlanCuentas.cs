using System;
using System.Windows.Forms;

namespace contabilidad_1
{
    public partial class PlanCuentas : Form
    {
        public Cuenta cuenta;
        public PlanData planData;
        
        public PlanCuentas()
        {
            InitializeComponent();
            planData = new PlanData();
            cuenta = new Cuenta();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cuenta.NombreCuenta = sender.ToString();
            
        }

        private void buttonActivo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (buttonActivo.Checked)
                {
                    cuenta.TipoCuenta = TipoCuenta.Activo;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir Libro Diario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonPasivo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (buttonActivo.Checked)
                {
                    cuenta.TipoCuenta = TipoCuenta.Pasivo;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir Libro Diario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRP_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (buttonActivo.Checked)
                {
                    cuenta.TipoCuenta = TipoCuenta.ResultadoPositivo;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir Libro Diario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRN_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (buttonActivo.Checked)
                {
                    cuenta.TipoCuenta = TipoCuenta.ResultadoNegativo;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir Libro Diario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPN_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (buttonActivo.Checked)
                {
                    cuenta.TipoCuenta = TipoCuenta.PatrimonioNeto;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir Libro Diario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cuenta.NombreCuenta) && cuenta.TipoCuenta != TipoCuenta.SinDefinir)
                {
                    Cuenta cuentaFinal = new Cuenta()
                    {
                        NombreCuenta = cuenta.NombreCuenta,
                        TipoCuenta = cuenta.TipoCuenta,
                        Id = cuenta.Id += 1
                    };

                    planData.planCuentas.Add(cuentaFinal);

                    LimpiarCuentaTemporal();

                    MessageBox.Show("Cambios guardados correctamente.", "Éxito", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se han realizado cambios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el Libro Diario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LimpiarCuentaTemporal()
        {
            cuenta.NombreCuenta = string.Empty;
            cuenta.TipoCuenta = TipoCuenta.SinDefinir;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            foreach (Cuenta cuenta in planData.planCuentas)
            {
                Console.WriteLine($"Nombre de la cuenta: {cuenta.NombreCuenta}, Tipo de cuenta: {cuenta.TipoCuenta}");
            }
        }
    }
}