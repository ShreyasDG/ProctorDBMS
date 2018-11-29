namespace Proctor_Database_Management_system
{
    partial class Results_UserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.result_dataGrid = new System.Windows.Forms.DataGridView();
            this.result_label = new System.Windows.Forms.Label();
            this.fail_btn = new System.Windows.Forms.Button();
            this.cgpa_check = new System.Windows.Forms.Button();
            this.cgpa = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.result_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // result_dataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.result_dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.result_dataGrid.BackgroundColor = System.Drawing.Color.LightCyan;
            this.result_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result_dataGrid.Location = new System.Drawing.Point(54, 90);
            this.result_dataGrid.Name = "result_dataGrid";
            this.result_dataGrid.Size = new System.Drawing.Size(542, 212);
            this.result_dataGrid.TabIndex = 0;
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.BackColor = System.Drawing.Color.Transparent;
            this.result_label.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_label.ForeColor = System.Drawing.Color.DarkCyan;
            this.result_label.Location = new System.Drawing.Point(273, 55);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(100, 22);
            this.result_label.TabIndex = 1;
            this.result_label.Text = "RESULTS";
            // 
            // fail_btn
            // 
            this.fail_btn.BackColor = System.Drawing.Color.LightCyan;
            this.fail_btn.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.fail_btn.FlatAppearance.BorderSize = 3;
            this.fail_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.fail_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.fail_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fail_btn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fail_btn.ForeColor = System.Drawing.Color.Black;
            this.fail_btn.Location = new System.Drawing.Point(54, 317);
            this.fail_btn.Name = "fail_btn";
            this.fail_btn.Size = new System.Drawing.Size(141, 33);
            this.fail_btn.TabIndex = 2;
            this.fail_btn.Text = "Check for fail";
            this.fail_btn.UseVisualStyleBackColor = false;
            this.fail_btn.Click += new System.EventHandler(this.fail_btn_Click);
            // 
            // cgpa_check
            // 
            this.cgpa_check.BackColor = System.Drawing.Color.LightCyan;
            this.cgpa_check.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.cgpa_check.FlatAppearance.BorderSize = 3;
            this.cgpa_check.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.cgpa_check.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.cgpa_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cgpa_check.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgpa_check.ForeColor = System.Drawing.Color.Black;
            this.cgpa_check.Location = new System.Drawing.Point(333, 317);
            this.cgpa_check.Name = "cgpa_check";
            this.cgpa_check.Size = new System.Drawing.Size(137, 33);
            this.cgpa_check.TabIndex = 3;
            this.cgpa_check.Text = "CGPA check";
            this.cgpa_check.UseVisualStyleBackColor = false;
            this.cgpa_check.Click += new System.EventHandler(this.cgpa_check_Click);
            // 
            // cgpa
            // 
            this.cgpa.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgpa.Location = new System.Drawing.Point(485, 325);
            this.cgpa.Name = "cgpa";
            this.cgpa.Size = new System.Drawing.Size(100, 24);
            this.cgpa.TabIndex = 4;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.LightCyan;
            this.refresh.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.refresh.FlatAppearance.BorderSize = 3;
            this.refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.Black;
            this.refresh.Location = new System.Drawing.Point(503, 51);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(93, 33);
            this.refresh.TabIndex = 5;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Results_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proctor_Database_Management_system.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.cgpa);
            this.Controls.Add(this.cgpa_check);
            this.Controls.Add(this.fail_btn);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.result_dataGrid);
            this.Name = "Results_UserControl";
            this.Size = new System.Drawing.Size(649, 415);
            this.Load += new System.EventHandler(this.Results_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.result_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView result_dataGrid;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.Button fail_btn;
        private System.Windows.Forms.Button cgpa_check;
        private System.Windows.Forms.TextBox cgpa;
        private System.Windows.Forms.Button refresh;
    }
}
