namespace projekt_trening.UserControls
{
    partial class UC_exercises
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
            this.label1 = new System.Windows.Forms.Label();
            this.Ćwiczenai = new System.Windows.Forms.Label();
            this.exercises_container = new System.Windows.Forms.FlowLayoutPanel();
            this.add_exercise_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Ćwiczenai
            // 
            this.Ćwiczenai.AutoSize = true;
            this.Ćwiczenai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ćwiczenai.Location = new System.Drawing.Point(357, 13);
            this.Ćwiczenai.Name = "Ćwiczenai";
            this.Ćwiczenai.Size = new System.Drawing.Size(110, 25);
            this.Ćwiczenai.TabIndex = 1;
            this.Ćwiczenai.Text = "Ćwiczenia";
            // 
            // exercises_container
            // 
            this.exercises_container.AutoScroll = true;
            this.exercises_container.Location = new System.Drawing.Point(3, 45);
            this.exercises_container.Name = "exercises_container";
            this.exercises_container.Size = new System.Drawing.Size(794, 328);
            this.exercises_container.TabIndex = 3;
            // 
            // add_exercise_btn
            // 
            this.add_exercise_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.add_exercise_btn.FlatAppearance.BorderSize = 0;
            this.add_exercise_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_exercise_btn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add_exercise_btn.ForeColor = System.Drawing.Color.White;
            this.add_exercise_btn.Location = new System.Drawing.Point(678, 8);
            this.add_exercise_btn.Name = "add_exercise_btn";
            this.add_exercise_btn.Size = new System.Drawing.Size(90, 30);
            this.add_exercise_btn.TabIndex = 4;
            this.add_exercise_btn.Text = "Dodaj";
            this.add_exercise_btn.UseVisualStyleBackColor = false;
            this.add_exercise_btn.Click += new System.EventHandler(this.add_exercise_btn_Click);
            // 
            // UC_exercises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.add_exercise_btn);
            this.Controls.Add(this.exercises_container);
            this.Controls.Add(this.Ćwiczenai);
            this.Controls.Add(this.label1);
            this.Name = "UC_exercises";
            this.Size = new System.Drawing.Size(800, 376);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Ćwiczenai;
        private System.Windows.Forms.FlowLayoutPanel exercises_container;
        private System.Windows.Forms.Button add_exercise_btn;
    }
}
