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
    public partial class Form6 : Form
    {
        Controller controllerObj;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int result;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                result = 0;
                MessageBox.Show("please enter all values !");
            }
            else if (controllerObj.check_username(textBox1.Text)==0)
            {
                result=0;
                MessageBox.Show("please enter a correct user Name  !");
            }

            else if (controllerObj.check_userpass(textBox2.Text,textBox1.Text) == 0)
            {
                result = 0;
                MessageBox.Show("please enter a correct password  !");
            }
            else if (controllerObj.check_username(textBox3.Text) == 1)
            {
                result = 0;
                MessageBox.Show("this user name already exists  !");

            }
            else
            result = controllerObj.updateEmployeeUsername(textBox1.Text,textBox2.Text,textBox3.Text);



            if (result == 0)
            {
                MessageBox.Show("The edition  failed");
            }
            else
            {
                MessageBox.Show("The user Name is edited successfully!");
            }




        }

        private void Form6_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }
    }
}
