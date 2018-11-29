namespace Proctor_Database_Management_system
{
    partial class PGroup_UserControl
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
            this.member_dataGrid = new System.Windows.Forms.DataGridView();
            this.pgroup_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.member_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // member_dataGrid
            // 
            this.member_dataGrid.BackgroundColor = System.Drawing.Color.LightCyan;
            this.member_dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.member_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.member_dataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.member_dataGrid.GridColor = System.Drawing.Color.DarkCyan;
            this.member_dataGrid.Location = new System.Drawing.Point(94, 107);
            this.member_dataGrid.Name = "member_dataGrid";
            this.member_dataGrid.Size = new System.Drawing.Size(457, 226);
            this.member_dataGrid.TabIndex = 0;
            this.member_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.member_dataGrid_CellContentClick);
            // 
            // pgroup_label
            // 
            this.pgroup_label.AutoSize = true;
            this.pgroup_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgroup_label.ForeColor = System.Drawing.Color.DarkCyan;
            this.pgroup_label.Location = new System.Drawing.Point(188, 56);
            this.pgroup_label.Name = "pgroup_label";
            this.pgroup_label.Size = new System.Drawing.Size(297, 31);
            this.pgroup_label.TabIndex = 1;
            this.pgroup_label.Text = "Proctor group members";
            this.pgroup_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // PGroup_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pgroup_label);
            this.Controls.Add(this.member_dataGrid);
            this.Name = "PGroup_UserControl";
            this.Size = new System.Drawing.Size(649, 415);
            this.Load += new System.EventHandler(this.PGroup_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.member_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label pgroup_label;
        private System.Windows.Forms.DataGridView member_dataGrid;
    }
}
