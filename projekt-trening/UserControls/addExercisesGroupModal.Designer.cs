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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sets_textbox = new System.Windows.Forms.TextBox();
            this.reps_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.selected_exercises_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa zestawu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // exercise_name_textbox
            // 
            this.exercise_name_textbox.Location = new System.Drawing.Point(304, 70);
            this.exercise_name_textbox.Name = "exercise_name_textbox";
            this.exercise_name_textbox.Size = new System.Drawing.Size(200, 20);
            this.exercise_name_textbox.TabIndex = 1;
            // 
            // add_exercises_group_btn
            // 
            this.add_exercises_group_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.add_exercises_group_btn.FlatAppearance.BorderSize = 0;
            this.add_exercises_group_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_exercises_group_btn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add_exercises_group_btn.ForeColor = System.Drawing.Color.White;
            this.add_exercises_group_btn.Location = new System.Drawing.Point(304, 408);
            this.add_exercises_group_btn.Name = "add_exercises_group_btn";
            this.add_exercises_group_btn.Size = new System.Drawing.Size(200, 30);
            this.add_exercises_group_btn.TabIndex = 2;
            this.add_exercises_group_btn.Text = "Dodaj zestaw";
            this.add_exercises_group_btn.UseVisualStyleBackColor = false;
            this.add_exercises_group_btn.Click += new System.EventHandler(this.add_exercises_group_btn_Click);
            // 
            // select_exercise_combobox
            // 
            this.select_exercise_combobox.FormattingEnabled = true;
            this.select_exercise_combobox.Location = new System.Drawing.Point(304, 154);
            this.select_exercise_combobox.Name = "select_exercise_combobox";
            this.select_exercise_combobox.Size = new System.Drawing.Size(200, 21);
            this.select_exercise_combobox.TabIndex = 3;
            // 
            // add_exercise_btn
            // 
            this.add_exercise_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.add_exercise_btn.FlatAppearance.BorderSize = 0;
            this.add_exercise_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_exercise_btn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add_exercise_btn.ForeColor = System.Drawing.Color.White;
            this.add_exercise_btn.Location = new System.Drawing.Point(304, 260);
            this.add_exercise_btn.Name = "add_exercise_btn";
            this.add_exercise_btn.Size = new System.Drawing.Size(197, 30);
            this.add_exercise_btn.TabIndex = 4;
            this.add_exercise_btn.Text = "Dodaj ćwiczenie do zestawu";
            this.add_exercise_btn.UseVisualStyleBackColor = false;
            this.add_exercise_btn.Click += new System.EventHandler(this.add_exercise_btn_Click);
            // 
            // selected_exercises_container
            // 
            this.selected_exercises_container.AutoScroll = true;
            this.selected_exercises_container.Controls.Add(this.label5);
            this.selected_exercises_container.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.selected_exercises_container.Location = new System.Drawing.Point(304, 299);
            this.selected_exercises_container.Name = "selected_exercises_container";
            this.selected_exercises_container.Size = new System.Drawing.Size(200, 103);
            this.selected_exercises_container.TabIndex = 5;
            this.selected_exercises_container.Paint += new System.Windows.Forms.PaintEventHandler(this.selected_exercises_container_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ilość serii";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ilość powtórzeń na serie";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // sets_textbox
            // 
            this.sets_textbox.Location = new System.Drawing.Point(304, 194);
            this.sets_textbox.Name = "sets_textbox";
            this.sets_textbox.Size = new System.Drawing.Size(200, 20);
            this.sets_textbox.TabIndex = 8;
            // 
            // reps_textbox
            // 
            this.reps_textbox.Location = new System.Drawing.Point(304, 233);
            this.reps_textbox.Name = "reps_textbox";
            this.reps_textbox.Size = new System.Drawing.Size(197, 20);
            this.reps_textbox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ćwiczenie";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.Location = new System.Drawing.Point(355, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(98, 19);
            this.title.TabIndex = 11;
            this.title.Text = "Dodaj zestaw";
            this.title.Click += new System.EventHandler(this.label6_Click);
            // 
            // addExercisesGroupModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label4);
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
            this.selected_exercises_container.ResumeLayout(false);
            this.selected_exercises_container.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label title;
    }
}