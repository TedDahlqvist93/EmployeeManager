using System;
using System.Windows.Forms;

namespace EmployeeManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmpList empList = new frmEmpList();
            this.Hide();
            empList.ShowDialog();
            this.Visible = true;
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            frmTaskList taskList = new frmTaskList();
            this.Hide();
            taskList.ShowDialog();
            this.Visible = true;
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            frmSalaryList salaryList = new frmSalaryList();
            this.Hide();
            salaryList.ShowDialog();
            this.Visible = true;
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            frmPermissionList permissionList = new frmPermissionList();
            this.Hide();
            permissionList.ShowDialog();
            this.Visible = true;
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            frmDepList depList = new frmDepList();
            this.Hide();
            depList.ShowDialog();
            this.Visible = true;
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            frmPositionList positionList = new frmPositionList();
            this.Hide();
            positionList.ShowDialog();
            this.Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }


    }}