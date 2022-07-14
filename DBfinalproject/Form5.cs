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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.Lab_test' table. You can move, or remove it, as needed.
            this.Lab_testTableAdapter.Fill(this.DataSet2.Lab_test);

            this.reportViewer1.RefreshReport();
        }
    }
}
