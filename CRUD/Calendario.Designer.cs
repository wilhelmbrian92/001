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
            this.SuspendLayout();
            // 
            // calendarioVencimientos
            // 
            this.calendarioVencimientos.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.calendarioVencimientos.Location = new System.Drawing.Point(100, 75);
            this.calendarioVencimientos.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.calendarioVencimientos.Name = "calendarioVencimientos";
            this.calendarioVencimientos.TabIndex = 0;

            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.calendarioVencimientos);
            this.Name = "Calendario";
            this.Text = "Calendario";
            this.Load += new System.EventHandler(this.Calendario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarioVencimientos;
    }
}