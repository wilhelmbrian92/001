namespace CRUD
{
    partial class Calendario
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
            this.calendarioVencimientos = new System.Windows.Forms.MonthCalendar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // calendarioVencimientos
            // 
            this.calendarioVencimientos.BackColor = System.Drawing.SystemColors.Window;
            this.calendarioVencimientos.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.calendarioVencimientos.Location = new System.Drawing.Point(100, 75);
            this.calendarioVencimientos.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.calendarioVencimientos.Name = "calendarioVencimientos";
            this.calendarioVencimientos.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(698, 539);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(46, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "< Volver";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.calendarioVencimientos);
            this.Name = "Calendario";
            this.Text = "Calendario";
            this.Load += new System.EventHandler(this.Calendario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarioVencimientos;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}