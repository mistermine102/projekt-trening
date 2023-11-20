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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj nowe ćwiczenie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(296, 104);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(249, 20);
            this.name_textbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Opis";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // desc_textbox
            // 
            this.desc_textbox.Location = new System.Drawing.Point(296, 169);
            this.desc_textbox.Multiline = true;
            this.desc_textbox.Name = "desc_textbox";
            this.desc_textbox.Size = new System.Drawing.Size(249, 85);
            this.desc_textbox.TabIndex = 4;
            // 
            // img_url_textbox
            // 
            this.img_url_textbox.Location = new System.Drawing.Point(296, 295);
            this.img_url_textbox.Name = "img_url_textbox";
            this.img_url_textbox.Size = new System.Drawing.Size(249, 20);
            this.img_url_textbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Link do zdjęcia";
            // 
            // target_muscles_textbox
            // 
            this.target_muscles_textbox.Location = new System.Drawing.Point(296, 353);
            this.target_muscles_textbox.Name = "target_muscles_textbox";
            this.target_muscles_textbox.Size = new System.Drawing.Size(249, 20);
            this.target_muscles_textbox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ćwiczonie mięśnie (oddzielone przecinkami)";
            // 
            // add_exercise_btn
            // 
            this.add_exercise_btn.Location = new System.Drawing.Point(375, 392);
            this.add_exercise_btn.Name = "add_exercise_btn";
            this.add_exercise_btn.Size = new System.Drawing.Size(75, 23);
            this.add_exercise_btn.TabIndex = 9;
            this.add_exercise_btn.Text = "Dodaj";
            this.add_exercise_btn.UseVisualStyleBackColor = true;
            this.add_exercise_btn.Click += new System.EventHandler(this.add_exercise_btn_Click);
            // 
            // addExerciseModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_exercise_btn);
            this.Controls.Add(this.target_muscles_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.img_url_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.desc_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.label1);
            this.Name = "addExerciseModal";
            this.Text = "addExerciseModal";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}