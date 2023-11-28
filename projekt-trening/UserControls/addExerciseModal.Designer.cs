namespace projekt_trening.UserControls
{
    partial class addExerciseModal
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
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.desc_textbox = new System.Windows.Forms.TextBox();
            this.img_url_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.target_muscles_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.add_exercise_btn = new System.Windows.Forms.Button();
            this.form_container = new System.Windows.Forms.FlowLayoutPanel();
            this.form_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj nowe ćwiczenie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(3, 62);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(249, 20);
            this.name_textbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Opis";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // desc_textbox
            // 
            this.desc_textbox.Location = new System.Drawing.Point(3, 101);
            this.desc_textbox.Multiline = true;
            this.desc_textbox.Name = "desc_textbox";
            this.desc_textbox.Size = new System.Drawing.Size(249, 85);
            this.desc_textbox.TabIndex = 4;
            // 
            // img_url_textbox
            // 
            this.img_url_textbox.Location = new System.Drawing.Point(3, 205);
            this.img_url_textbox.Name = "img_url_textbox";
            this.img_url_textbox.Size = new System.Drawing.Size(249, 20);
            this.img_url_textbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Link do zdjęcia";
            // 
            // target_muscles_textbox
            // 
            this.target_muscles_textbox.Location = new System.Drawing.Point(3, 244);
            this.target_muscles_textbox.Name = "target_muscles_textbox";
            this.target_muscles_textbox.Size = new System.Drawing.Size(249, 20);
            this.target_muscles_textbox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ćwiczonie mięśnie (oddzielone przecinkami)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // add_exercise_btn
            // 
            this.add_exercise_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.add_exercise_btn.FlatAppearance.BorderSize = 0;
            this.add_exercise_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_exercise_btn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add_exercise_btn.ForeColor = System.Drawing.Color.White;
            this.add_exercise_btn.Location = new System.Drawing.Point(3, 270);
            this.add_exercise_btn.Name = "add_exercise_btn";
            this.add_exercise_btn.Size = new System.Drawing.Size(249, 36);
            this.add_exercise_btn.TabIndex = 9;
            this.add_exercise_btn.Text = "Dodaj";
            this.add_exercise_btn.UseVisualStyleBackColor = false;
            this.add_exercise_btn.Click += new System.EventHandler(this.add_exercise_btn_Click);
            // 
            // form_container
            // 
            this.form_container.Controls.Add(this.label1);
            this.form_container.Controls.Add(this.label2);
            this.form_container.Controls.Add(this.name_textbox);
            this.form_container.Controls.Add(this.label3);
            this.form_container.Controls.Add(this.desc_textbox);
            this.form_container.Controls.Add(this.label4);
            this.form_container.Controls.Add(this.img_url_textbox);
            this.form_container.Controls.Add(this.label5);
            this.form_container.Controls.Add(this.target_muscles_textbox);
            this.form_container.Controls.Add(this.add_exercise_btn);
            this.form_container.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.form_container.Location = new System.Drawing.Point(272, 32);
            this.form_container.Name = "form_container";
            this.form_container.Size = new System.Drawing.Size(456, 406);
            this.form_container.TabIndex = 10;
            this.form_container.Paint += new System.Windows.Forms.PaintEventHandler(this.form_container_Paint);
            // 
            // addExerciseModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.form_container);
            this.Name = "addExerciseModal";
            this.Text = "addExerciseModal";
            this.Load += new System.EventHandler(this.addExerciseModal_Load);
            this.form_container.ResumeLayout(false);
            this.form_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox desc_textbox;
        private System.Windows.Forms.TextBox img_url_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox target_muscles_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add_exercise_btn;
        private System.Windows.Forms.FlowLayoutPanel form_container;
    }
}