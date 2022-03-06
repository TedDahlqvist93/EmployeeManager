using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace EmployeeManager
{
    public partial class frmDep : Form
    {
        public frmDep()
        {
            InitializeComponent();
        }

        private void btnDepClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDepClose_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }

        private void btnDepSave_Click(object sender, EventArgs e)
        {
            if (txtDepartment.Text.Trim() == "")
                MessageBox.Show("Please fill the name field");
            else
            {
                DEPARTMENT department = new DEPARTMENT();
                department.DepartmentName = txtDepartment.Text;
                BLL.DepartmentBLL.AddDepartment(department);
                MessageBox.Show("Department was added");
                txtDepartment.Clear();
            }
        }

        private void frmDep_Load(object sender, EventArgs e)
        {

        }
    }
}
