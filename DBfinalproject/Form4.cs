using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBfinalproject
{
    public partial class Form4 : Form
    {
        Controller controllerObj;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
           
           


            DataTable dt1 = controllerObj.Selectdepartmentnames();
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "Department_Name";
            comboBox1.ValueMember = "Department_Number";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.EmployeeTableAdapter.Fill(this.DataSet1.Employee, Convert.ToInt32(comboBox1.SelectedValue.ToString()));

            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.Show();
        }
    }
}
