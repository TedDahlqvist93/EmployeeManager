using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DAO;
using DAL.DTO;
using DAL;
using BLL;

namespace EmployeeManager
{
    public partial class frmSalary : Form
    {
        public frmSalary()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }

        SalaryDTO dto = new SalaryDTO();
        private bool combofull;
        public SalaryDetailDTO detail = new SalaryDetailDTO();

        private void frmSalary_Load(object sender, EventArgs e)
        {
            dto = SalaryBLL.GetAll();
            dataGridView1.DataSource = dto.Employees;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Username";
            dataGridView1.Columns[2].HeaderText = "Name";
            dataGridView1.Columns[3].HeaderText = "Lastname";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;

            combofull = false;
            cmbDepartment.DataSource = dto.Departments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";

            cmbPosition.DataSource = dto.Positions;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;

            if (dto.Departments.Count > 0)
            combofull = true;

            cmbMonth.DataSource = dto.Months;
            cmbMonth.DisplayMember = "MonthName";
            cmbMonth.ValueMember = "ID";
            cmbMonth.SelectedIndex = -1;


        }
        SALARY salary = new SALARY();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();             
            txtSalary.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtYear.Text = DateTime.Today.Year.ToString();
            salary.EmployeeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (salary.EmployeeID == 0)
                MessageBox.Show("Please select an employee from table");
            else if (txtYear.Text.Trim() == "")
                MessageBox.Show("Please fill the year");
            else if (txtSalary.Text.Trim() == "")
                MessageBox.Show("Salary is empty");
            else if ((cmbMonth.SelectedIndex == -1))
                MessageBox.Show("Please select a month");
            else

            {
                salary.Year = Convert.ToInt32(txtSalary.Text);
                salary.MonthID = Convert.ToInt32(cmbMonth.SelectedValue);
                salary.Amount = Convert.ToInt32(txtSalary.Text);
                SalaryBLL.AddSalary(salary);
                MessageBox.Show("Salary was added");
                cmbMonth.SelectedIndex = -1;

            }
        }
    



    }
}
