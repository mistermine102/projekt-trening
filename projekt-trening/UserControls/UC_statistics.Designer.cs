namespace projekt_trening.UserControls
{
    partial class UC_statistics
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
            this.statistics = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statistics
            // 
            this.statistics.AutoSize = true;
            this.statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statistics.Location = new System.Drawing.Point(373, 176);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(105, 25);
            this.statistics.TabIndex = 3;
            this.statistics.Text = "Statystyki";
            // 
            // UC_statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statistics);
            this.Name = "UC_statistics";
            this.Size = new System.Drawing.Size(800, 376);
            this.Load += new System.EventHandler(this.UC_statistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statistics;
    }
}
