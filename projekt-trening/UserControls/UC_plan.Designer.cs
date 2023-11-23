namespace projekt_trening.UserControls
{
    partial class UC_plan
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
            this.Ćwiczenia = new System.Windows.Forms.Label();
            this.exercises_groups_container = new System.Windows.Forms.FlowLayoutPanel();
            this.add_exercises_group_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ćwiczenia
            // 
            this.Ćwiczenia.AutoSize = true;
            this.Ćwiczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ćwiczenia.Location = new System.Drawing.Point(360, 11);
            this.Ćwiczenia.Name = "Ćwiczenia";
            this.Ćwiczenia.Size = new System.Drawing.Size(55, 25);
            this.Ćwiczenia.TabIndex = 2;
            this.Ćwiczenia.Text = "Plan";
            // 
            // exercises_groups_container
            // 
            this.exercises_groups_container.Location = new System.Drawing.Point(3, 39);
            this.exercises_groups_container.Name = "exercises_groups_container";
            this.exercises_groups_container.Size = new System.Drawing.Size(794, 334);
            this.exercises_groups_container.TabIndex = 3;
            this.exercises_groups_container.Paint += new System.Windows.Forms.PaintEventHandler(this.exercises_groups_container_Paint);
            // 
            // add_exercises_group_btn
            // 
            this.add_exercises_group_btn.Location = new System.Drawing.Point(684, 10);
            this.add_exercises_group_btn.Name = "add_exercises_group_btn";
            this.add_exercises_group_btn.Size = new System.Drawing.Size(75, 23);
            this.add_exercises_group_btn.TabIndex = 4;
            this.add_exercises_group_btn.Text = "Dodaj zestaw ćwiczeń";
            this.add_exercises_group_btn.UseVisualStyleBackColor = true;
            this.add_exercises_group_btn.Click += new System.EventHandler(this.add_exercises_group_btn_Click);
            // 
            // UC_plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.add_exercises_group_btn);
            this.Controls.Add(this.exercises_groups_container);
            this.Controls.Add(this.Ćwiczenia);
            this.Name = "UC_plan";
            this.Size = new System.Drawing.Size(800, 376);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ćwiczenia;
        private System.Windows.Forms.FlowLayoutPanel exercises_groups_container;
        private System.Windows.Forms.Button add_exercises_group_btn;
    }
}
