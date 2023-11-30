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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // day_name
            // 
            this.day_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.day_name.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.day_name.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.day_name.Location = new System.Drawing.Point(338, 104);
            this.day_name.Name = "day_name";
            this.day_name.Size = new System.Drawing.Size(121, 22);
            this.day_name.TabIndex = 0;
            this.day_name.Text = "label1";
            this.day_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // exercises_groups_combobox
            // 
            this.exercises_groups_combobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.exercises_groups_combobox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.exercises_groups_combobox.FormattingEnabled = true;
            this.exercises_groups_combobox.Location = new System.Drawing.Point(338, 200);
            this.exercises_groups_combobox.Name = "exercises_groups_combobox";
            this.exercises_groups_combobox.Size = new System.Drawing.Size(121, 21);
            this.exercises_groups_combobox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(338, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Location = new System.Drawing.Point(338, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zestaw ćwiczeń";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // calendarDayModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exercises_groups_combobox);
            this.Controls.Add(this.day_name);
            this.Name = "calendarDayModal";
            this.Text = "calendarDayModal";
            this.Load += new System.EventHandler(this.calendarDayModal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label day_name;
        private System.Windows.Forms.ComboBox exercises_groups_combobox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}