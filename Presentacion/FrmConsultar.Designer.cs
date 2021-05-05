
namespace Presentacion
{
    partial class FrmConsultar
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoContrato = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btmVolver = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.NIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTercero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de contrato";
            // 
            // cmbTipoContrato
            // 
            this.cmbTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoContrato.FormattingEnabled = true;
            this.cmbTipoContrato.Items.AddRange(new object[] {
            "Todos",
            "Servicios Públicos",
            "Compras a Proveedores",
            "Pagos a Contratistas",
            "Fecha por mes y año"});
            this.cmbTipoContrato.Location = new System.Drawing.Point(192, 44);
            this.cmbTipoContrato.Name = "cmbTipoContrato";
            this.cmbTipoContrato.Size = new System.Drawing.Size(212, 23);
            this.cmbTipoContrato.TabIndex = 3;
            this.cmbTipoContrato.SelectedIndexChanged += new System.EventHandler(this.cmbTipoContrato_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(697, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btmVolver
            // 
            this.btmVolver.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btmVolver.Location = new System.Drawing.Point(699, 403);
            this.btmVolver.Name = "btmVolver";
            this.btmVolver.Size = new System.Drawing.Size(89, 35);
            this.btmVolver.TabIndex = 6;
            this.btmVolver.Text = "Volver";
            this.btmVolver.UseVisualStyleBackColor = false;
            this.btmVolver.Click += new System.EventHandler(this.btmVolver_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NIT,
            this.TipoContrato,
            this.NombreTercero,
            this.FechaPago,
            this.ValorPagado});
            this.dgvConsulta.Location = new System.Drawing.Point(81, 88);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowTemplate.Height = 25;
            this.dgvConsulta.Size = new System.Drawing.Size(598, 270);
            this.dgvConsulta.TabIndex = 7;
            // 
            // NIT
            // 
            this.NIT.HeaderText = "NIT";
            this.NIT.Name = "NIT";
            this.NIT.Width = 50;
            // 
            // TipoContrato
            // 
            this.TipoContrato.HeaderText = "Tipo de Contrato";
            this.TipoContrato.Name = "TipoContrato";
            this.TipoContrato.Width = 111;
            // 
            // NombreTercero
            // 
            this.NombreTercero.HeaderText = "Nombre de tercero";
            this.NombreTercero.Name = "NombreTercero";
            this.NombreTercero.Width = 88;
            // 
            // FechaPago
            // 
            this.FechaPago.HeaderText = "Fecha de Pago";
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.Width = 76;
            // 
            // ValorPagado
            // 
            this.ValorPagado.HeaderText = "ValorPagado";
            this.ValorPagado.Name = "ValorPagado";
            this.ValorPagado.Width = 98;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(420, 44);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(232, 23);
            this.dtpFechaPago.TabIndex = 14;
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.btmVolver);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbTipoContrato);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultar";
            this.Text = "Consultar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoContrato;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btmVolver;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTercero;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorPagado;
    }
}