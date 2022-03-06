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
using DAL.DAO;
using DAL.DTO;
using BLL;
using System.IO;

namespace EmployeeManager
{
    public partial class frmEmp : Form
    {
        public frmEmp()
        {
            InitializeComponent();
        }


        private void btnDepClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.IsNumber(e);
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.IsNumber(e);
        }
        EmployeeDTO dto = new EmployeeDTO();
        private void frmEmp_Load(object sender, EventArgs e)
        {
            dto = EmployeeBLL.GetAll();
            cmbDepartment.DataSource = dto.Departments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            combofull = true;
        }
        bool combofull = false;
        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
            int departmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
            cmbPosition.DataSource = dto.Positions.Where(x => x.DepartmentID == departmentID).ToList();
            }
        }
        string fileName = "";

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Load(openFileDialog1.FileName);
                txtImagePath.Text = openFileDialog1.FileName;
                string Unique = Guid.NewGuid().ToString();
                fileName += Unique + openFileDialog1.SafeFileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
                MessageBox.Show("Username is empty");
            else if (!EmployeeBLL.isUnique(txtUsername.Text))
                MessageBox.Show("This username is used by another employee, please choose another");
            else if (txtPassword.Text.Trim() == "")
                MessageBox.Show("Password is Empty");
            else if (txtName.Text.Trim() == "")
                MessageBox.Show("Name is empty");
            else if (txtLastName.Text.Trim() == "")
                MessageBox.Show("Last name is empty");
            else if (txtSalary.Text.Trim() == "")
                MessageBox.Show("Salary is empty");
            else if (dateTimePicker1.Text.Trim() == "")
                MessageBox.Show("Birthday is empty");
            else if (cmbDepartment.Text.Trim() == "")
                MessageBox.Show("Department is empty");
            else if (cmbPosition.Text.Trim() == "")
                MessageBox.Show("Position is empty");
            else
            {
                EMPLOYEE employee = new EMPLOYEE();
                employee.Username = txtUsername.Text;
                employee.Password = txtPassword.Text;
                employee.isAdmin = chAdmin.Checked;
                employee.Name = txtName.Text;
                employee.LastName = txtLastName.Text;
                employee.Name = txtName.Text;
                employee.Salary = Convert.ToInt32(txtSalary.Text);
                employee.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                employee.PositionID = Convert.ToInt32(cmbDepartment.SelectedValue);
                employee.Address = txtAddress.Text;
                employee.Birthday = dateTimePicker1.Value;
                employee.ImagePath = fileName;

                EmployeeBLL.AddEmployee(employee);
                File.Copy(txtImagePath.Text, @"images\\" + fileName);
                MessageBox.Show("Employee was added");

                txtUsername.Clear();
                txtPassword.Clear();
                chAdmin.Checked = false;
                txtName.Clear();
                txtLastName.Clear();
                txtSalary.Clear();
                txtAddress.Clear();
                txtImagePath.Clear();
                pictureBox2.Image = null;
                cmbDepartment.SelectedIndex = -1;
                cmbPosition.DataSource = dto.Positions;
                cmbPosition.SelectedIndex = -1;
                combofull = true;
                dateTimePicker1.Value = DateTime.Today;
            }

        }
        bool isUnique = false;
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
                MessageBox.Show("Username is empty");
            else
            {
                isUnique = EmployeeBLL.isUnique(txtUsername.Text);
                if (!isUnique)
                    MessageBox.Show("This username is already in use");
                else
                    MessageBox.Show("This username is usable!");
            }
        }
    }
}
