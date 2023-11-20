namespace projekt_trening.UserControls
{
    partial class addExercisesGroupModal
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
            this.label1 = new System.Windows.Forms.Label();
            this.exercise_name_textbox = new System.Windows.Forms.TextBox();
            this.add_exercises_group_btn = new System.Windows.Forms.Button();
            this.select_exercise_combobox = new System.Windows.Forms.ComboBox();
            this.add_exercise_btn = new System.Windows.Forms.Button();
            this.selected_exercises_container = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sets_textbox = new System.Windows.Forms.TextBox();
            this.reps_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa zestawu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // exercise_name_textbox
            // 
            this.exercise_name_textbox.Location = new System.Drawing.Point(304, 41);
            this.exercise_name_textbox.Name = "exercise_name_textbox";
            this.exercise_name_textbox.Size = new System.Drawing.Size(200, 20);
            this.exercise_name_textbox.TabIndex = 1;
            // 
            // add_exercises_group_btn
            // 
            this.add_exercises_group_btn.Location = new System.Drawing.Point(304, 415);
            this.add_exercises_group_btn.Name = "add_exercises_group_btn";
            this.add_exercises_group_btn.Size = new System.Drawing.Size(200, 23);
            this.add_exercises_group_btn.TabIndex = 2;
            this.add_exercises_group_btn.Text = "Dodaj zestaw";
            this.add_exercises_group_btn.UseVisualStyleBackColor = true;
            this.add_exercises_group_btn.Click += new System.EventHandler(this.add_exercises_group_btn_Click);
            // 
            // select_exercise_combobox
            // 
            this.select_exercise_combobox.FormattingEnabled = true;
            this.select_exercise_combobox.Location = new System.Drawing.Point(307, 110);
            this.select_exercise_combobox.Name = "select_exercise_combobox";
            this.select_exercise_combobox.Size = new System.Drawing.Size(200, 21);
            this.select_exercise_combobox.TabIndex = 3;
            // 
            // add_exercise_btn
            // 
            this.add_exercise_btn.Location = new System.Drawing.Point(304, 236);
            this.add_exercise_btn.Name = "add_exercise_btn";
            this.add_exercise_btn.Size = new System.Drawing.Size(200, 23);
            this.add_exercise_btn.TabIndex = 4;
            this.add_exercise_btn.Text = "Dodaj ćwiczenie do zestawu";
            this.add_exercise_btn.UseVisualStyleBackColor = true;
            this.add_exercise_btn.Click += new System.EventHandler(this.add_exercise_btn_Click);
            // 
            // selected_exercises_container
            // 
            this.selected_exercises_container.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.selected_exercises_container.Location = new System.Drawing.Point(304, 287);
            this.selected_exercises_container.Name = "selected_exercises_container";
            this.selected_exercises_container.Size = new System.Drawing.Size(200, 103);
            this.selected_exercises_container.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ilość serii";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ilość powtórzeń na serie";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // sets_textbox
            // 
            this.sets_textbox.Location = new System.Drawing.Point(307, 163);
            this.sets_textbox.Name = "sets_textbox";
            this.sets_textbox.Size = new System.Drawing.Size(200, 20);
            this.sets_textbox.TabIndex = 8;
            // 
            // reps_textbox
            // 
            this.reps_textbox.Location = new System.Drawing.Point(307, 210);
            this.reps_textbox.Name = "reps_textbox";
            this.reps_textbox.Size = new System.Drawing.Size(197, 20);
            this.reps_textbox.TabIndex = 9;
            // 
            // addExercisesGroupModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reps_textbox);
            this.Controls.Add(this.sets_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selected_exercises_container);
            this.Controls.Add(this.add_exercise_btn);
            this.Controls.Add(this.select_exercise_combobox);
            this.Controls.Add(this.add_exercises_group_btn);
            this.Controls.Add(this.exercise_name_textbox);
            this.Controls.Add(this.label1);
            this.Name = "addExercisesGroupModal";
            this.Text = "addExercisesGroupModal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox exercise_name_textbox;
        private System.Windows.Forms.Button add_exercises_group_btn;
        private System.Windows.Forms.ComboBox select_exercise_combobox;
        private System.Windows.Forms.Button add_exercise_btn;
        private System.Windows.Forms.FlowLayoutPanel selected_exercises_container;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sets_textbox;
        private System.Windows.Forms.TextBox reps_textbox;
    }
}