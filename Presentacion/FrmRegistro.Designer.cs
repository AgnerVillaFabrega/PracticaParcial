
namespace Presentacion
{
    partial class FrmRegistro
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
            this.components = new System.ComponentModel.Container();
            this.cmbTipoContrato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.txtNombreTercero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorPagado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btmRegitrar = new System.Windows.Forms.Button();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btmVolver = new System.Windows.Forms.Button();
            this.ErrorProviderRegistro = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoContrato
            // 
            this.cmbTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoContrato.FormattingEnabled = true;
            this.cmbTipoContrato.Items.AddRange(new object[] {
            "Servicios Públicos",
            "Compras a Proveedores",
            "Pagos a Contratistas",
            ""});
            this.cmbTipoContrato.Location = new System.Drawing.Point(307, 59);
            this.cmbTipoContrato.Name = "cmbTipoContrato";
            this.cmbTipoContrato.Size = new System.Drawing.Size(232, 23);
            this.cmbTipoContrato.TabIndex = 5;
            this.cmbTipoContrato.Validating += new System.ComponentModel.CancelEventHandler(this.cmbTipoContrato_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de contrato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "NIT";
            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(307, 123);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(232, 23);
            this.txtNIT.TabIndex = 7;
            this.txtNIT.Validating += new System.ComponentModel.CancelEventHandler(this.txtNIT_Validating);
            // 
            // txtNombreTercero
            // 
            this.txtNombreTercero.Location = new System.Drawing.Point(307, 185);
            this.txtNombreTercero.Name = "txtNombreTercero";
            this.txtNombreTercero.Size = new System.Drawing.Size(232, 23);
            this.txtNombreTercero.TabIndex = 9;
            this.txtNombreTercero.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombreTercero_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre de tercero";
            // 
            // txtValorPagado
            // 
            this.txtValorPagado.Location = new System.Drawing.Point(307, 312);
            this.txtValorPagado.Name = "txtValorPagado";
            this.txtValorPagado.Size = new System.Drawing.Size(232, 23);
            this.txtValorPagado.TabIndex = 11;
            this.txtValorPagado.Validating += new System.ComponentModel.CancelEventHandler(this.txtValorPagado_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor pagado";
            // 
            // btmRegitrar
            // 
            this.btmRegitrar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btmRegitrar.Location = new System.Drawing.Point(597, 380);
            this.btmRegitrar.Name = "btmRegitrar";
            this.btmRegitrar.Size = new System.Drawing.Size(107, 32);
            this.btmRegitrar.TabIndex = 12;
            this.btmRegitrar.Text = "Registrar";
            this.btmRegitrar.UseVisualStyleBackColor = false;
            this.btmRegitrar.Click += new System.EventHandler(this.btmRegitrar_Click);
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(307, 253);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(232, 23);
            this.dtpFechaPago.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha del pago";
            // 
            // btmVolver
            // 
            this.btmVolver.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btmVolver.Location = new System.Drawing.Point(495, 380);
            this.btmVolver.Name = "btmVolver";
            this.btmVolver.Size = new System.Drawing.Size(81, 32);
            this.btmVolver.TabIndex = 15;
            this.btmVolver.Text = "Volver";
            this.btmVolver.UseVisualStyleBackColor = false;
            this.btmVolver.Click += new System.EventHandler(this.btmVolver_Click);
            // 
            // ErrorProviderRegistro
            // 
            this.ErrorProviderRegistro.ContainerControl = this;
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.btmVolver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.btmRegitrar);
            this.Controls.Add(this.txtValorPagado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreTercero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNIT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoContrato);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistro";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoContrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.TextBox txtNombreTercero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorPagado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btmRegitrar;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btmVolver;
        private System.Windows.Forms.ErrorProvider ErrorProviderRegistro;
    }
}