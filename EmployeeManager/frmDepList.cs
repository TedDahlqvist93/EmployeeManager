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
    public partial class frmDepList : Form
    {
        public frmDepList()
        {
            InitializeComponent();
        }

        private void btnDepListNew_Click(object sender, EventArgs e)
        {

        }

        private void btnDepListUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDepListDelete_Click(object sender, EventArgs e)
        {

        }
        private void btnDepListClose_Click(object sender, EventArgs e)
        {

        }

        private void btnDepListClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmDep frmDep = new frmDep();
            this.Hide();
            frmDep.ShowDialog();
            this.Visible = true;
            list = DepartmentBLL.GetDepartments();
            dataGridView1.DataSource = list;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmDep frmDep = new frmDep();
            this.Hide();
            frmDep.ShowDialog();
            this.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<DEPARTMENT> list = new List<DEPARTMENT>();
        private void frmDepList_Load(object sender, EventArgs e)
        {
            list = BLL.DepartmentBLL.GetDepartments();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].HeaderText = "Department ID";
            dataGridView1.Columns[1].HeaderText = "Department Name";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
