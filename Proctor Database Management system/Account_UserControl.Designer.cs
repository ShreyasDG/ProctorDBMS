namespace Proctor_Database_Management_system
{
    partial class Account_UserControl
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
            this.update_btn = new System.Windows.Forms.Button();
            this.fname_tbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lname_tbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.email_tbox = new System.Windows.Forms.TextBox();
            this.contact_tbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.LightCyan;
            this.update_btn.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.update_btn.FlatAppearance.BorderSize = 3;
            this.update_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.update_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.ForeColor = System.Drawing.Color.Black;
            this.update_btn.Location = new System.Drawing.Point(425, 388);
            this.update_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(141, 53);
            this.update_btn.TabIndex = 0;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_click);
            // 
            // fname_tbox
            // 
            this.fname_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_tbox.ForeColor = System.Drawing.Color.DarkCyan;
            this.fname_tbox.Location = new System.Drawing.Point(385, 132);
            this.fname_tbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fname_tbox.Name = "fname_tbox";
            this.fname_tbox.Size = new System.Drawing.Size(257, 28);
            this.fname_tbox.TabIndex = 1;
            this.fname_tbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("CSD16", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(231, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(231, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lname_tbox
            // 
            this.lname_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_tbox.ForeColor = System.Drawing.Color.DarkCyan;
            this.lname_tbox.Location = new System.Drawing.Point(385, 197);
            this.lname_tbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lname_tbox.Name = "lname_tbox";
            this.lname_tbox.Size = new System.Drawing.Size(257, 28);
            this.lname_tbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(231, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // email_tbox
            // 
            this.email_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_tbox.ForeColor = System.Drawing.Color.DarkCyan;
            this.email_tbox.Location = new System.Drawing.Point(385, 257);
            this.email_tbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.email_tbox.Name = "email_tbox";
            this.email_tbox.Size = new System.Drawing.Size(257, 28);
            this.email_tbox.TabIndex = 6;
            // 
            // contact_tbox
            // 
            this.contact_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_tbox.ForeColor = System.Drawing.Color.DarkCyan;
            this.contact_tbox.Location = new System.Drawing.Point(385, 320);
            this.contact_tbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contact_tbox.Name = "contact_tbox";
            this.contact_tbox.Size = new System.Drawing.Size(257, 28);
            this.contact_tbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(231, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contact";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Proctor_Database_Management_system.Properties.Resources.account;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(451, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 75);
            this.panel1.TabIndex = 9;
            // 
            // Account_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proctor_Database_Management_system.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contact_tbox);
            this.Controls.Add(this.email_tbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lname_tbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fname_tbox);
            this.Controls.Add(this.update_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Account_UserControl";
            this.Size = new System.Drawing.Size(865, 511);
            this.Load += new System.EventHandler(this.Account_UserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.TextBox fname_tbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lname_tbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email_tbox;
        private System.Windows.Forms.TextBox contact_tbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}
