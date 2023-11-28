namespace projekt_trening.UserControls
{
    partial class calendarDayModal
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
            this.day_name = new System.Windows.Forms.Label();
            this.exercises_groups_combobox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // day_name
            // 
            this.day_name.AutoSize = true;
            this.day_name.Location = new System.Drawing.Point(350, 63);
            this.day_name.Name = "day_name";
            this.day_name.Size = new System.Drawing.Size(35, 13);
            this.day_name.TabIndex = 0;
            this.day_name.Text = "label1";
            this.day_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // exercises_groups_combobox
            // 
            this.exercises_groups_combobox.FormattingEnabled = true;
            this.exercises_groups_combobox.Location = new System.Drawing.Point(353, 156);
            this.exercises_groups_combobox.Name = "exercises_groups_combobox";
            this.exercises_groups_combobox.Size = new System.Drawing.Size(121, 21);
            this.exercises_groups_combobox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calendarDayModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exercises_groups_combobox);
            this.Controls.Add(this.day_name);
            this.Name = "calendarDayModal";
            this.Text = "calendarDayModal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label day_name;
        private System.Windows.Forms.ComboBox exercises_groups_combobox;
        private System.Windows.Forms.Button button1;
    }
}