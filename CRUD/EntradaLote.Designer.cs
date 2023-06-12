namespace CRUD
{
    partial class Registrar_ENTRADA
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
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cboxProductos = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rbtnSecretaria = new System.Windows.Forms.RadioButton();
            this.rbtnRemediar = new System.Windows.Forms.RadioButton();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProducto.Location = new System.Drawing.Point(20, 40);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(75, 18);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProveedor.Location = new System.Drawing.Point(20, 160);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(89, 18);
            this.lblProveedor.TabIndex = 1;
            this.lblProveedor.Text = "Proveedor: ";
            // 
            // cboxProductos
            // 
            this.cboxProductos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxProductos.FormattingEnabled = true;
            this.cboxProductos.Location = new System.Drawing.Point(123, 40);
            this.cboxProductos.Name = "cboxProductos";
            this.cboxProductos.Size = new System.Drawing.Size(310, 26);
            this.cboxProductos.TabIndex = 2;
            this.cboxProductos.SelectedIndexChanged += new System.EventHandler(this.cboxProductos_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(358, 190);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 38);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rbtnSecretaria
            // 
            this.rbtnSecretaria.AutoSize = true;
            this.rbtnSecretaria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSecretaria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnSecretaria.Location = new System.Drawing.Point(123, 160);
            this.rbtnSecretaria.Name = "rbtnSecretaria";
            this.rbtnSecretaria.Size = new System.Drawing.Size(98, 22);
            this.rbtnSecretaria.TabIndex = 4;
            this.rbtnSecretaria.TabStop = true;
            this.rbtnSecretaria.Text = "Secretaría";
            this.rbtnSecretaria.UseVisualStyleBackColor = true;
            this.rbtnSecretaria.CheckedChanged += new System.EventHandler(this.rbtnSecretaria_CheckedChanged);
            // 
            // rbtnRemediar
            // 
            this.rbtnRemediar.AutoSize = true;
            this.rbtnRemediar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRemediar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnRemediar.Location = new System.Drawing.Point(223, 160);
            this.rbtnRemediar.Name = "rbtnRemediar";
            this.rbtnRemediar.Size = new System.Drawing.Size(95, 22);
            this.rbtnRemediar.TabIndex = 5;
            this.rbtnRemediar.TabStop = true;
            this.rbtnRemediar.Text = "Remediar";
            this.rbtnRemediar.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCantidad.Location = new System.Drawing.Point(20, 80);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(76, 18);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVencimiento.Location = new System.Drawing.Point(20, 120);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(98, 18);
            this.lblVencimiento.TabIndex = 8;
            this.lblVencimiento.Text = "Vencimiento:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(123, 80);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(71, 26);
            this.txtCantidad.TabIndex = 10;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimiento.Location = new System.Drawing.Point(123, 120);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(310, 26);
            this.dtpVencimiento.TabIndex = 11;
            // 
            // Registrar_ENTRADA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(471, 252);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.rbtnRemediar);
            this.Controls.Add(this.rbtnSecretaria);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboxProductos);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Registrar_ENTRADA";
            this.Text = "Registrar ENTRADA";
            this.Load += new System.EventHandler(this.Registrar_ENTRADA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cboxProductos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RadioButton rbtnSecretaria;
        private System.Windows.Forms.RadioButton rbtnRemediar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
    }
}