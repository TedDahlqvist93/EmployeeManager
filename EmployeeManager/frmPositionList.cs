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
using DAL.DTO;

namespace EmployeeManager
{
    public partial class frmPositionList : Form
    {
        public frmPositionList()
        {
            InitializeComponent();
        }

        private void btnPosListClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPosListNew_Click(object sender, EventArgs e)
        {
            frmPosition frmPos = new frmPosition();
            this.Hide();
            frmPos.ShowDialog();
            this.Visible = true;
        }

        private void btnPosListUpdate_Click(object sender, EventArgs e)
        {
            frmPosition frmPos = new frmPosition();
            this.Hide();
            frmPos.ShowDialog();
            this.Visible = true;
            FillGrid();
        }
        List<PositionDTO> positionList = new List <PositionDTO>();
        void FillGrid()
        {
            positionList = PositionBLL.GetPositions();
            dataGridView1.DataSource = positionList;
        }

        private void frmPositionList_Load(object sender, EventArgs e)
        {
            FillGrid();
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[0].HeaderText = "Department Name";
            dataGridView1.Columns[2].HeaderText = "Position Name";
        }
    }
}
