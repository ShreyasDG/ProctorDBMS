namespace Proctor_Database_Management_system
{
    partial class make_announcements_userControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title_textBox = new System.Windows.Forms.TextBox();
            this.content_textBox = new System.Windows.Forms.RichTextBox();
            this.submit_announcement = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.content_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.link_tbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title_textBox
            // 
            this.title_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_textBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.title_textBox.Location = new System.Drawing.Point(154, 64);
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.Size = new System.Drawing.Size(362, 29);
            this.title_textBox.TabIndex = 0;
            this.title_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // content_textBox
            // 
            this.content_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content_textBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.content_textBox.Location = new System.Drawing.Point(154, 107);
            this.content_textBox.Name = "content_textBox";
            this.content_textBox.Size = new System.Drawing.Size(362, 138);
            this.content_textBox.TabIndex = 1;
            this.content_textBox.Text = "";
            // 
            // submit_announcement
            // 
            this.submit_announcement.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.submit_announcement.FlatAppearance.BorderSize = 3;
            this.submit_announcement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.submit_announcement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.submit_announcement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_announcement.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_announcement.ForeColor = System.Drawing.Color.DarkCyan;
            this.submit_announcement.Location = new System.Drawing.Point(128, 271);
            this.submit_announcement.Name = "submit_announcement";
            this.submit_announcement.Size = new System.Drawing.Size(112, 34);
            this.submit_announcement.TabIndex = 2;
            this.submit_announcement.Text = "SUBMIT";
            this.submit_announcement.UseVisualStyleBackColor = true;
            this.submit_announcement.Click += new System.EventHandler(this.submit_announcement_Click);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.DarkCyan;
            this.title_label.Location = new System.Drawing.Point(57, 64);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(89, 21);
            this.title_label.TabIndex = 3;
            this.title_label.Text = "TITLE *";
            // 
            // content_label
            // 
            this.content_label.AutoSize = true;
            this.content_label.BackColor = System.Drawing.Color.Transparent;
            this.content_label.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content_label.ForeColor = System.Drawing.Color.DarkCyan;
            this.content_label.Location = new System.Drawing.Point(28, 109);
            this.content_label.Name = "content_label";
            this.content_label.Size = new System.Drawing.Size(118, 21);
            this.content_label.TabIndex = 4;
            this.content_label.Text = "CONTENT *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(295, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Link";
            // 
            // link_tbox
            // 
            this.link_tbox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.link_tbox.Location = new System.Drawing.Point(358, 280);
            this.link_tbox.Name = "link_tbox";
            this.link_tbox.Size = new System.Drawing.Size(206, 20);
            this.link_tbox.TabIndex = 6;
            // 
            // make_announcements_userControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proctor_Database_Management_system.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.link_tbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.content_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.submit_announcement);
            this.Controls.Add(this.content_textBox);
            this.Controls.Add(this.title_textBox);
            this.Name = "make_announcements_userControl";
            this.Size = new System.Drawing.Size(649, 353);
            this.Load += new System.EventHandler(this.make_announcements_userControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title_textBox;
        private System.Windows.Forms.RichTextBox content_textBox;
        private System.Windows.Forms.Button submit_announcement;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label content_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox link_tbox;
    }
}
