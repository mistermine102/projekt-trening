namespace projekt_trening.UserControls
{
    partial class UC_calendar
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.calendar = new System.Windows.Forms.Label();
            this.calendar_container = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.calendar.AutoSize = true;
            this.calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calendar.Location = new System.Drawing.Point(336, 16);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(109, 25);
            this.calendar.TabIndex = 2;
            this.calendar.Text = "Kalendarz";
            // 
            // calendar_container
            // 
            this.calendar_container.Location = new System.Drawing.Point(3, 44);
            this.calendar_container.Name = "calendar_container";
            this.calendar_container.Size = new System.Drawing.Size(794, 329);
            this.calendar_container.TabIndex = 3;
            this.calendar_container.Paint += new System.Windows.Forms.PaintEventHandler(this.calendar_container_Paint);
            // 
            // UC_calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.calendar_container);
            this.Controls.Add(this.calendar);
            this.Name = "UC_calendar";
            this.Size = new System.Drawing.Size(800, 376);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label calendar;
        private System.Windows.Forms.FlowLayoutPanel calendar_container;
    }
}
