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
    public partial class Form3 : Form
    {
        Controller controllerObj;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1)check empty
            //if (comboBox1_Role.Text == "")
            //{
            //    MessageBox.Show("choose the Rule");
            //    return;
            //}
            //if (textBox1_ID.Text == "")
            //{
            //    MessageBox.Show("Enter the ID");
            //    return;
            //}
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
            //2)confirm the password
            if (textBox1_Confirm_Pass.Text != password_textbox.Text)
            {
                MessageBox.Show("Your password not confirmed");
                textBox1_Confirm_Pass.Clear();
                return;
            }
            //3)check user name existance
            int UA_Count = controllerObj.check_UA_existance(user_name_textbox.Text);
            if (UA_Count == 0)
            {
                MessageBox.Show("This user name dose not exist");
                return;
            }
            else
            {

                int result = controllerObj.Update_UA_password(user_name_textbox.Text, password_textbox.Text);
                if (result == 0)
                {
                    MessageBox.Show("Failed to change the password");
                }
                else
                {
                    MessageBox.Show("The password changed successfully");
                }
            }

        }
        private void user_name_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
