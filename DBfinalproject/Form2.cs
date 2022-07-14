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
    public partial class Form2 : Form
    {
        Controller controllerObj;
        public Form2()
        {
            InitializeComponent();
            //comboBox1_IDSelectAllSSNemployee
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            ////DataTable dt = controllerObj.select_sign_up_ssn();
            ////comboBox1_ID.DataSource = dt;
            ////comboBox1_ID.DisplayMember = "SSN";

            DataTable dt2 = controllerObj.Select_Emp_names_sign_up();
            comboBox1_ID.DataSource = dt2;
            dt2.Columns.Add(
    "Fullname",
    typeof(string),
    "Fname +' ' + Minit+' ' +Lname+' '+SSN ");
            comboBox1_ID.DisplayMember = "fullname";
            comboBox1_ID.ValueMember = "SSN";

        }

        private void button1_Click(object sender, EventArgs e)//button1 is the "confirm" botton
        {

            ///1)check if any box is empty
            if (user_name_textbox.Text == "")
            {
                MessageBox.Show("Enter a user name");
                return;
            }
            if (password_textbox.Text == "")
            {
                MessageBox.Show("Enter a password");
                return;
            }
            if (textBox1_Confirm_Pass.Text == "")
            {
                MessageBox.Show("Confirm your password");
                return;
            }
            if (comboBox1_ID.Text == "")
            {
                MessageBox.Show("Select your ID");
                return;
            }
            //if(comboBox1_Role.Text=="")
            //{
            //    MessageBox.Show("choose the Rule");
            //    return;
            //}
            //if (textBox1_ID.Text == "")
            //{
            //    MessageBox.Show("Enter the ID");
            //    return;
            //}comboBox1_ID
            //if (textBox1_Role.Text == "")
            //{
            //    MessageBox.Show("choose the Rule");
            //    return;
            //}

            //////////
            //2)confirm the password 
            if (textBox1_Confirm_Pass.Text != password_textbox.Text)
            {
                MessageBox.Show("Your password not confirmed");
                textBox1_Confirm_Pass.Clear();
                return;
            }
            ///3)check if the user name is allready exist,as we assume that user names are unique
            int UA_Count = controllerObj.check_UA_existance(user_name_textbox.Text);
            if (UA_Count == 1)
            {
                MessageBox.Show("This user name is already exist, enter another one");
                return;
            }
            /////////
            //Later:chheck valid type related to the entered(id)ssn
            ///
            ///
            //int result =controllerObj.Insert_new_UA(textBox1_ID.Text, user_name_textbox.Text, password_textbox.Text);           
            // int result = controllerObj.Insert_new_UA(comboBox1_ID.Text, user_name_textbox.Text, password_textbox.Text);
            int result = controllerObj.Insert_new_UA(comboBox1_ID.SelectedValue.ToString(), user_name_textbox.Text, password_textbox.Text);
            if (result == 0)
            {
                MessageBox.Show("Failed to creat a new User Account");
            }
            else
            {
                MessageBox.Show("The User Account is created successfully");
            }
        }
        private void user_name_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_ID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void textBox1_Confirm_Pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
