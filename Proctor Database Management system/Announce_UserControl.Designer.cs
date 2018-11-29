namespace Proctor_Database_Management_system
{
    partial class Announce_UserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.make_announcements = new System.Windows.Forms.Button();
            this.see_announcements = new System.Windows.Forms.Button();
            this.announce_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.see_announcements);
            this.panel1.Controls.Add(this.make_announcements);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 62);
            this.panel1.TabIndex = 0;
            // 
            // make_announcements
            // 
            this.make_announcements.BackColor = System.Drawing.Color.LightCyan;
            this.make_announcements.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.make_announcements.FlatAppearance.BorderSize = 3;
            this.make_announcements.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.make_announcements.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.make_announcements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.make_announcements.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.make_announcements.ForeColor = System.Drawing.Color.Black;
            this.make_announcements.Location = new System.Drawing.Point(0, 0);
            this.make_announcements.Name = "make_announcements";
            this.make_announcements.Size = new System.Drawing.Size(324, 62);
            this.make_announcements.TabIndex = 0;
            this.make_announcements.Text = "New announcement";
            this.make_announcements.UseVisualStyleBackColor = false;
            this.make_announcements.Click += new System.EventHandler(this.make_announcements_Click);
            // 
            // see_announcements
            // 
            this.see_announcements.BackColor = System.Drawing.Color.LightCyan;
            this.see_announcements.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.see_announcements.FlatAppearance.BorderSize = 3;
            this.see_announcements.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.see_announcements.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.see_announcements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.see_announcements.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.see_announcements.ForeColor = System.Drawing.Color.Black;
            this.see_announcements.Location = new System.Drawing.Point(324, 0);
            this.see_announcements.Name = "see_announcements";
            this.see_announcements.Size = new System.Drawing.Size(325, 62);
            this.see_announcements.TabIndex = 1;
            this.see_announcements.Text = "View announcements";
            this.see_announcements.UseVisualStyleBackColor = false;
            this.see_announcements.Click += new System.EventHandler(this.see_announcements_Click);
            // 
            // announce_panel
            // 
            this.announce_panel.BackColor = System.Drawing.Color.Transparent;
            this.announce_panel.BackgroundImage = global::Proctor_Database_Management_system.Properties.Resources.login;
            this.announce_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.announce_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.announce_panel.Location = new System.Drawing.Point(0, 62);
            this.announce_panel.Name = "announce_panel";
            this.announce_panel.Size = new System.Drawing.Size(649, 353);
            this.announce_panel.TabIndex = 1;
            this.announce_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.announce_panel_Paint);
            // 
            // Announce_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.announce_panel);
            this.Controls.Add(this.panel1);
            this.Name = "Announce_UserControl";
            this.Size = new System.Drawing.Size(649, 415);
            this.Load += new System.EventHandler(this.announce_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button see_announcements;
        private System.Windows.Forms.Button make_announcements;
        private System.Windows.Forms.Panel announce_panel;
    }
}
