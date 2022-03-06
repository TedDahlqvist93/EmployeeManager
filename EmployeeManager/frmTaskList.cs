using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DAL.DTO;
using BLL;

namespace EmployeeManager
{
    public partial class frmTaskList : Form
    {
        public frmTaskList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        TaskDTO dto = new TaskDTO();
        private bool combofull = false;
        void FillAllData()
        {
            dto = TaskBLL.GetAll();
            dataGridView1.DataSource = dto.Tasks;

            combofull = false;

            cmbDepartment.DataSource = dto.Departments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            combofull = true;
            cmbState.DataSource = dto.TaskStates;
            cmbState.DisplayMember = "StateName";
            cmbState.ValueMember = "ID";
            cmbState.SelectedIndex = -1;

        }

        TaskDetailDTO detail = new TaskDetailDTO();

        private void frmTaskList_Load(object sender, EventArgs e)
        {
            FillAllData();
           
            dataGridView1.Columns[0].HeaderText = "Task Title";
            dataGridView1.Columns[1].HeaderText = "Username";
            dataGridView1.Columns[2].HeaderText = "Name";
            dataGridView1.Columns[3].HeaderText = "Last Name";
            dataGridView1.Columns[4].HeaderText = "Start Date";
            dataGridView1.Columns[5].HeaderText = "Delivery Date";
            dataGridView1.Columns[6].HeaderText = "Task State";
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmTask frmTask = new frmTask();
            this.Hide();
            frmTask.ShowDialog();
            this.Visible = true;
            FillAllData();
            ClearFilters();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmTask frmTask = new frmTask();
            this.Hide();
            frmTask.ShowDialog();
            this.Visible = true;
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                cmbPosition.DataSource = dto.Positions.Where(x => x.DepartmentID ==
                Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();              
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<TaskDetailDTO> list = dto.Tasks;   

            if (txtUsername.Text.Trim() != "")
                list = list.Where(x => x.Username.Contains(txtUsername.Text)).ToList();

            if (txtName.Text.Trim() != "")
                list = list.Where(x => x.Name.Contains(txtName.Text)).ToList();

            if (txtName.Text.Trim() != "")
                list = list.Where(x => x.LastName.Contains(txtLastName.Text)).ToList();





                if (cmbDepartment.SelectedIndex != -1)
              list = list.Where(x => x.DepartmentID == Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();
           
            if (cmbPosition.SelectedIndex != -1)
                list = list.Where(x => x.PositionID == Convert.ToInt32(cmbPosition.SelectedValue)).ToList();

            if (rbStartDate.Checked)
                list = list.Where(x => x.TaskStartDate > Convert.ToDateTime(dateStart.Value) && 
                x.TaskStartDate < Convert.ToDateTime(dateFinish.Value)).ToList();

            if (rbDeliveryDate.Checked)
                list = list.Where(x => x.TaskDeliveryDate > Convert.ToDateTime(dateFinish.Value) && 
                x.TaskDeliveryDate< Convert.ToDateTime(dateFinish.Value)).ToList();

            if (cmbState.SelectedIndex != -1)
                list = list.Where(x => x.TaskStateID > Convert.ToInt32(cmbState.SelectedValue)).ToList();    



            
            dataGridView1.DataSource = list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }

        private void ClearFilters()
        {
            txtUsername.Clear();
            txtName.Clear();
            txtLastName.Clear();
            combofull = false;
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            cmbPosition.DataSource = dto.Positions;
            combofull = true;
            rbStartDate.Checked = false;
            rbDeliveryDate.Checked = false;
            cmbState.SelectedIndex = -1;
            dataGridView1.DataSource = dto.Tasks;
        }
    }
}
