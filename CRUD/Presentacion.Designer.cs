namespace CRUD
{
    partial class Presentacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLblAlta = new System.Windows.Forms.LinkLabel();
            this.linkLblConsulta = new System.Windows.Forms.LinkLabel();
            this.linkLblCalendario = new System.Windows.Forms.LinkLabel();
            this.linkLblEntradas = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLblAlta
            // 
            this.linkLblAlta.ActiveLinkColor = System.Drawing.Color.DarkViolet;
            this.linkLblAlta.AutoSize = true;
            this.linkLblAlta.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblAlta.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLblAlta.Location = new System.Drawing.Point(58, 69);
            this.linkLblAlta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLblAlta.Name = "linkLblAlta";
            this.linkLblAlta.Size = new System.Drawing.Size(174, 24);
            this.linkLblAlta.TabIndex = 0;
            this.linkLblAlta.TabStop = true;
            this.linkLblAlta.Text = "Ingresar producto";
            this.linkLblAlta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblAlta_LinkClicked);
            // 
            // linkLblConsulta
            // 
            this.linkLblConsulta.ActiveLinkColor = System.Drawing.Color.DarkViolet;
            this.linkLblConsulta.AutoSize = true;
            this.linkLblConsulta.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblConsulta.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLblConsulta.Location = new System.Drawing.Point(58, 227);
            this.linkLblConsulta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLblConsulta.Name = "linkLblConsulta";
            this.linkLblConsulta.Size = new System.Drawing.Size(187, 24);
            this.linkLblConsulta.TabIndex = 1;
            this.linkLblConsulta.TabStop = true;
            this.linkLblConsulta.Text = "Consultar registros";
            this.linkLblConsulta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLblCalendario
            // 
            this.linkLblCalendario.ActiveLinkColor = System.Drawing.Color.DarkViolet;
            this.linkLblCalendario.AutoSize = true;
            this.linkLblCalendario.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblCalendario.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLblCalendario.Location = new System.Drawing.Point(58, 307);
            this.linkLblCalendario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLblCalendario.Name = "linkLblCalendario";
            this.linkLblCalendario.Size = new System.Drawing.Size(269, 24);
            this.linkLblCalendario.TabIndex = 2;
            this.linkLblCalendario.TabStop = true;
            this.linkLblCalendario.Text = "Calendario de vencimientos";
            this.linkLblCalendario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLblEntradas
            // 
            this.linkLblEntradas.ActiveLinkColor = System.Drawing.Color.DarkViolet;
            this.linkLblEntradas.AutoSize = true;
            this.linkLblEntradas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblEntradas.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLblEntradas.Location = new System.Drawing.Point(58, 146);
            this.linkLblEntradas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLblEntradas.Name = "linkLblEntradas";
            this.linkLblEntradas.Size = new System.Drawing.Size(175, 24);
            this.linkLblEntradas.TabIndex = 3;
            this.linkLblEntradas.TabStop = true;
            this.linkLblEntradas.Text = "Ingresar registros";
            this.linkLblEntradas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblEntradas_LinkClicked);
            // 
            // Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(723, 519);
            this.Controls.Add(this.linkLblEntradas);
            this.Controls.Add(this.linkLblCalendario);
            this.Controls.Add(this.linkLblConsulta);
            this.Controls.Add(this.linkLblAlta);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Presentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLblAlta;
        private System.Windows.Forms.LinkLabel linkLblConsulta;
        private System.Windows.Forms.LinkLabel linkLblCalendario;
        private System.Windows.Forms.LinkLabel linkLblEntradas;
    }
}

