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
            this.SuspendLayout();
            // 
            // linkLblAlta
            // 
            this.linkLblAlta.ActiveLinkColor = System.Drawing.Color.DarkViolet;
            this.linkLblAlta.AutoSize = true;
            this.linkLblAlta.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblAlta.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLblAlta.Location = new System.Drawing.Point(58, 68);
            this.linkLblAlta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLblAlta.Name = "linkLblAlta";
            this.linkLblAlta.Size = new System.Drawing.Size(161, 24);
            this.linkLblAlta.TabIndex = 0;
            this.linkLblAlta.TabStop = true;
            this.linkLblAlta.Text = "Alta de producto";
            this.linkLblAlta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblAlta_LinkClicked);
            // 
            // Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1366, 745);
            this.Controls.Add(this.linkLblAlta);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Presentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLblAlta;
    }
}

