using System.Windows.Forms;
namespace EmployeeManager
{
    partial class frmPositionList
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
            this.btnPosListClose = new System.Windows.Forms.Button();
            this.btnPosListNew = new System.Windows.Forms.Button();
            this.btnPosListDelete = new System.Windows.Forms.Button();
            this.btnPosListUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPosListClose
            // 
            this.btnPosListClose.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPosListClose.Location = new System.Drawing.Point(15, 271);
            this.btnPosListClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPosListClose.Name = "btnPosListClose";
            this.btnPosListClose.Size = new System.Drawing.Size(112, 39);
            this.btnPosListClose.TabIndex = 3;
            this.btnPosListClose.Text = "Close";
            this.btnPosListClose.UseVisualStyleBackColor = true;
            this.btnPosListClose.Click += new System.EventHandler(this.btnPosListClose_Click);
            // 
            // btnPosListNew
            // 
            this.btnPosListNew.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPosListNew.Location = new System.Drawing.Point(15, 10);
            this.btnPosListNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPosListNew.Name = "btnPosListNew";
            this.btnPosListNew.Size = new System.Drawing.Size(112, 44);
            this.btnPosListNew.TabIndex = 0;
            this.btnPosListNew.Text = "New";
            this.btnPosListNew.UseVisualStyleBackColor = true;
            this.btnPosListNew.Click += new System.EventHandler(this.btnPosListNew_Click);
            // 
            // btnPosListDelete
            // 
            this.btnPosListDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPosListDelete.Location = new System.Drawing.Point(16, 107);
            this.btnPosListDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPosListDelete.Name = "btnPosListDelete";
            this.btnPosListDelete.Size = new System.Drawing.Size(112, 44);
            this.btnPosListDelete.TabIndex = 2;
            this.btnPosListDelete.Text = "Delete";
            this.btnPosListDelete.UseVisualStyleBackColor = true;
            // 
            // btnPosListUpdate
            // 
            this.btnPosListUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPosListUpdate.Location = new System.Drawing.Point(15, 58);
            this.btnPosListUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPosListUpdate.Name = "btnPosListUpdate";
            this.btnPosListUpdate.Size = new System.Drawing.Size(112, 44);
            this.btnPosListUpdate.TabIndex = 1;
            this.btnPosListUpdate.Text = "Update";
            this.btnPosListUpdate.UseVisualStyleBackColor = true;
            this.btnPosListUpdate.Click += new System.EventHandler(this.btnPosListUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(569, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPosListNew);
            this.panel1.Controls.Add(this.btnPosListUpdate);
            this.panel1.Controls.Add(this.btnPosListClose);
            this.panel1.Controls.Add(this.btnPosListDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(587, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 324);
            this.panel1.TabIndex = 1;
            // 
            // frmPositionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 324);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPositionList";
            this.Text = "Position List";
            this.Load += new System.EventHandler(this.frmPositionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnPosListClose;
        private Button btnPosListNew;
        private Button btnPosListDelete;
        private Button btnPosListUpdate;
        private DataGridView dataGridView1;
        private Panel panel1;
    }
}