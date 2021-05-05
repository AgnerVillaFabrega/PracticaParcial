using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entity;
using Logica;

namespace Presentacion
{
    public partial class FrmRegistro : Form
    {
        PersonaServicio servicio = new PersonaServicio();
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btmVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtNIT_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txtNIT.Text))
            //{
            //    ErrorProviderRegistro.SetError(txtNIT, "Campo vacio");
            //}
            //else
            //{
            //    ErrorProviderRegistro.SetError(txtNIT, "");
            //}
        }

        private void txtNombreTercero_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txtNombreTercero.Text))
            //{
            //    ErrorProviderRegistro.SetError(txtNombreTercero, "Campo vacio");
            //}
            //else
            //{
            //    ErrorProviderRegistro.SetError(txtNombreTercero, "");
            //}
        }

        private void cmbTipoContrato_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(cmbTipoContrato.Text))
            //{
            //    ErrorProviderRegistro.SetError(cmbTipoContrato, "Campo vacio");
            //}
            //else
            //{
            //    ErrorProviderRegistro.SetError(cmbTipoContrato, "");
            //}
        }
        private void txtValorPagado_Validating(object sender, CancelEventArgs e)
        {
            //bool succes = decimal.TryParse(txtValorPagado.Text, out decimal x);
            //if (string.IsNullOrEmpty(txtValorPagado.Text))
            //{
            //    ErrorProviderRegistro.SetError(txtValorPagado, "Campo vacio");
            //}
            //else if (!succes)
            //{
            //    ErrorProviderRegistro.SetError(txtValorPagado, "Ingrese datos numericos");
            //}
            //else
            //{
            //    ErrorProviderRegistro.SetError(txtValorPagado, "");
            //}
        }


        #region Validaciones
        public bool ValidarCampoVacio(Control objeto, ErrorProvider errorProvider)
        {
            bool error = false;
            foreach (var item in objeto.Controls)
            {
                if (item is TextBox)
                {
                    TextBox obj = (TextBox)item;

                    if (obj.Text.Equals("") || obj.Text.Equals("Escribir..."))
                    {
                        errorProvider.SetError(obj, "No Puede Estar Vacio");
                        error = true;
                    }
                    else
                    {
                        errorProvider.SetError(obj, "");
                        error = false;
                    }
                }
                if (item is ComboBox)
                {
                    ComboBox box = (ComboBox)item;
                    if (box.Text.Equals("") || box.Text.Equals("Escribir..."))
                    {
                        errorProvider.SetError(box, "No Puede Estar Vacio");
                        error = true;
                    }
                    else
                    {
                        errorProvider.SetError(box, "");
                        error = false;
                    }
                }
            }
            return error;
        }
        public bool ValidarCampoCaracter(TextBox textBox, ErrorProvider errorProvider)
        {
            bool error = false;

            if (!textBox.Text.All(char.IsLetter))
            {
                errorProvider.SetError(textBox, "Debe Digitar Solo Caracteres");
                error = true;
            }
            else
            {
                errorProvider.SetError(textBox, "");
                error = false;
            }
            return error;
        }
        public bool ValidarCampoNumero(TextBox textBox, ErrorProvider errorProvider)
        {
            try
            {
                decimal.Parse(textBox.Text);
                errorProvider.SetError(textBox, "");
                return true;
            }
            catch
            {
                errorProvider.SetError(textBox, "Debe Digitar Solo Numeros");
                return false;
            }
        }
        #endregion
        public Persona CrearPersona()
        {
            Persona persona = new Persona()
            {
                TipoContrato = cmbTipoContrato.Text,
                NIT = decimal.Parse(txtNIT.Text),
                NombreTercero = txtNombreTercero.Text, 
                FechaPago = DateTime.Parse(dtpFechaPago.Text),
                ValorPagado = decimal.Parse(txtValorPagado.Text)
            };

            return persona;
        }
        
        public void LimpiarCampos(Control control)
        {
            foreach (var obj in control.Controls)
            {
                if (obj is TextBox)
                {
                    ((TextBox)obj).Clear();
                }

                if (obj is ComboBox)
                {
                    ((ComboBox)obj).Text = "";
                }
            }
        }
       
        private void btmRegitrar_Click(object sender, EventArgs e)
        {
            ValidarCampoVacio(this,ErrorProviderRegistro);
            ValidarCampoCaracter(txtNombreTercero, ErrorProviderRegistro);
            ValidarCampoNumero(txtValorPagado, ErrorProviderRegistro);

            if (ValidarCampoVacio(this, ErrorProviderRegistro)== true &&
                 ValidarCampoCaracter(txtNombreTercero, ErrorProviderRegistro)==true&&
                  ValidarCampoNumero(txtValorPagado, ErrorProviderRegistro)== true)
            {
                Console.WriteLine("Error");
            }
            else
            {
                MessageBox.Show( servicio.Guardar(CrearPersona()));
                LimpiarCampos(this); 

            }
        }
       
    }
}
