using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entity;
using Logica;

namespace Presentacion
{
    public partial class FrmConsultar : Form
    {
        PersonaServicio servicio = new PersonaServicio();
        public FrmConsultar()
        {
            InitializeComponent();
        }

        private void btmVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipoContrato_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbTipoContrato.Text.Equals("Todos"))
                PintarTabla(servicio.RetornarTodo());
            else if (cmbTipoContrato.Text.Equals("Fecha por mes y año"))
            {
                DateTime fecha = this.dtpFechaPago.Value;
                PintarTabla(servicio.ConsultarAñoMes(fecha));
            } 
            else
                PintarTabla(servicio.ConsultarPagos(cmbTipoContrato.Text));



        }
        private void PintarTabla(List<Persona> personas)
        {
            dgvConsulta.DataSource = null;
            dgvConsulta.Rows.Clear();
            if (personas != null)
            {
                foreach (var item in personas)
                {
                    int n = dgvConsulta.Rows.Add();
                    dgvConsulta.Rows[n].Cells[0].Value = item.NIT;
                    dgvConsulta.Rows[n].Cells[1].Value = item.TipoContrato;
                    dgvConsulta.Rows[n].Cells[2].Value = item.NombreTercero;
                    dgvConsulta.Rows[n].Cells[3].Value = item.FechaPago;
                    dgvConsulta.Rows[n].Cells[4].Value = item.ValorPagado;
                }
            }
            
        }
         
    }
}
