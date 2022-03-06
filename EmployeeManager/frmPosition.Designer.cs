using System.Windows.Forms;
namespace EmployeeManager
{
    partial class frmPosition
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
            this.btnDepClose = new System.Windows.Forms.Button();
            this.btnDepSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDep = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Department";
            // 
            // btnDepClose
            // 
            this.btnDepClose.Location = new System.Drawing.Point(185, 86);
            this.btnDepClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDepClose.Name = "btnDepClose";
            this.btnDepClose.Size = new System.Drawing.Size(94, 23);
            this.btnDepClose.TabIndex = 3;
            this.btnDepClose.Text = "Close";
            this.btnDepClose.UseVisualStyleBackColor = true;
            this.btnDepClose.Click += new System.EventHandler(this.btnDepClose_Click);
            // 
            // btnDepSave
            // 
            this.btnDepSave.Location = new System.Drawing.Point(85, 86);
            this.btnDepSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDepSave.Name = "btnDepSave";
            this.btnDepSave.Size = new System.Drawing.Size(94, 23);
            this.btnDepSave.TabIndex = 2;
            this.btnDepSave.Text = "Save";
            this.btnDepSave.UseVisualStyleBackColor = true;
            this.btnDepSave.Click += new System.EventHandler(this.btnDepSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 7);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Position";
            // 
            // cmbDep
            // 
            this.cmbDep.FormattingEnabled = true;
            this.cmbDep.Location = new System.Drawing.Point(107, 34);
            this.cmbDep.Name = "cmbDep";
            this.cmbDep.Size = new System.Drawing.Size(172, 24);
            this.cmbDep.TabIndex = 6;
            // 
            // frmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 119);
            this.Controls.Add(this.cmbDep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDepClose);
            this.Controls.Add(this.btnDepSave);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPosition";
            this.Text = "Position";
            this.Load += new System.EventHandler(this.frmPosition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnDepClose;
        private Button btnDepSave;
        private TextBox textBox1;
        private Label label2;
        private ComboBox cmbDep;
    }
}