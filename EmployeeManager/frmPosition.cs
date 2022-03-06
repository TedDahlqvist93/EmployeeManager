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
using DAL.DTO;

namespace EmployeeManager
{
    public partial class frmPosition : Form
    {
        public frmPosition()
        {
            InitializeComponent();

        }

        private void btnDepClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<DEPARTMENT> depList = new List<DEPARTMENT>();
        public PositionDTO detail = new PositionDTO();

        private void frmPosition_Load(object sender, EventArgs e)
        {
            depList = DepartmentBLL.GetDepartments();
            cmbDep.DataSource = depList;
            cmbDep.DisplayMember = "DepartmentName";
            cmbDep.ValueMember = "ID";
            cmbDep.SelectedIndex = -1;
        }

        private void btnDepSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
                MessageBox.Show("Please fill position name");
            else if (cmbDep.SelectedIndex == -1)
                MessageBox.Show("Please select a department");
            else
            {
                POSITION position = new POSITION();
                position.PositionName = textBox1.Text;
                position.DepartmentID = Convert.ToInt32(cmbDep.SelectedValue);
                BLL.PositionBLL.AddPosition(position);
                MessageBox.Show("Position added!");
                textBox1.Clear();
                cmbDep.SelectedIndex = -1;
            }
        }
    }
}