using System.Windows.Forms;

namespace EmployeeManager
{
    partial class frmDep
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
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.btnDepSave = new System.Windows.Forms.Button();
            this.btnDepClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(107, 22);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(172, 22);
            this.txtDepartment.TabIndex = 0;
            // 
            // btnDepSave
            // 
            this.btnDepSave.Location = new System.Drawing.Point(88, 70);
            this.btnDepSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDepSave.Name = "btnDepSave";
            this.btnDepSave.Size = new System.Drawing.Size(94, 23);
            this.btnDepSave.TabIndex = 1;
            this.btnDepSave.Text = "Save";
            this.btnDepSave.UseVisualStyleBackColor = true;
            this.btnDepSave.Click += new System.EventHandler(this.btnDepSave_Click);
            // 
            // btnDepClose
            // 
            this.btnDepClose.Location = new System.Drawing.Point(188, 70);
            this.btnDepClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDepClose.Name = "btnDepClose";
            this.btnDepClose.Size = new System.Drawing.Size(94, 23);
            this.btnDepClose.TabIndex = 2;
            this.btnDepClose.Text = "Close";
            this.btnDepClose.UseVisualStyleBackColor = true;
            this.btnDepClose.Click += new System.EventHandler(this.btnDepClose_Click);
            this.btnDepClose.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnDepClose_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Department";
            // 
            // frmDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 103);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDepClose);
            this.Controls.Add(this.btnDepSave);
            this.Controls.Add(this.txtDepartment);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDep";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.frmDep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDepartment;
        private Button btnDepSave;
        private Button btnDepClose;
        private Label label1;
    }
}