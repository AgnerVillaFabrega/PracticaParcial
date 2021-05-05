
namespace Presentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btmConsultar = new System.Windows.Forms.Button();
            this.btmRegitrar = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btmConsultar);
            this.panel1.Controls.Add(this.btmRegitrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 450);
            this.panel1.TabIndex = 0;
            // 
            // btmConsultar
            // 
            this.btmConsultar.Location = new System.Drawing.Point(12, 129);
            this.btmConsultar.Name = "btmConsultar";
            this.btmConsultar.Size = new System.Drawing.Size(99, 40);
            this.btmConsultar.TabIndex = 1;
            this.btmConsultar.Text = "Consultar";
            this.btmConsultar.UseVisualStyleBackColor = true;
            this.btmConsultar.Click += new System.EventHandler(this.btmConsultar_Click);
            // 
            // btmRegitrar
            // 
            this.btmRegitrar.Location = new System.Drawing.Point(12, 35);
            this.btmRegitrar.Name = "btmRegitrar";
            this.btmRegitrar.Size = new System.Drawing.Size(99, 40);
            this.btmRegitrar.TabIndex = 0;
            this.btmRegitrar.Text = "Registrar";
            this.btmRegitrar.UseVisualStyleBackColor = true;
            this.btmRegitrar.Click += new System.EventHandler(this.btmRegitrar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(146, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(654, 450);
            this.panelContenedor.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btmConsultar;
        private System.Windows.Forms.Button btmRegitrar;
        private System.Windows.Forms.Panel panelContenedor;
    }
}

