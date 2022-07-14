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
    public partial class Form1 : Form
    {
        
        Controller controllerObj;
        public Form1()
        {
            InitializeComponent();
            //////samaa/////
            //comboBox1_Role.DataSource = new string[] { "Receptionist","Doctor","Administrator", "Nurse", "Pharmacist", "Accountant" };
            ////////////////
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controllerObj=new Controller();
            //patientregpannel.Visible = false;


            //////select all SSN////////
            DataTable dt1 = controllerObj.SelectAllSSNemployee();
           /* comboBox14.DataSource = dt1;
            comboBox14.DisplayMember = "SSN";*/
           
           

            DataTable dt2 = controllerObj.Selectemployeenames();
            comboBox3.DataSource = dt2;
            comboBox12.DataSource = dt2;
            comboBox4.DataSource = dt2;
            comboBox13.DataSource = dt2;
       
            //needed
            comboBox14.DataSource = dt2;
           /// comboBox8.DataSource = dt2;
          
            dt2.Columns.Add(
     "Fullname",
     typeof(string),
     "Fname +' ' + Minit+' ' +Lname+' '+SSN ");
    

           
            comboBox3.DisplayMember = "fullname";
            comboBox3.ValueMember = "SSN";
           
            comboBox12.DisplayMember = "fullname";
            comboBox12.ValueMember = "SSN";

          

            comboBox4.DisplayMember = "fullname";
            comboBox4.ValueMember = "SSN";

            //needed
            comboBox14.DisplayMember = "fullname";
            comboBox14.ValueMember = "SSN";


            comboBox13.DisplayMember = "fullname";
            comboBox13.ValueMember = "SSN";


            DataTable dt9 = controllerObj.Select_medicines();
            comboBox5.DataSource = dt9;
            comboBox5.DisplayMember = "Medicine_Name";
            comboBox5.ValueMember = "Medicine_Id";


            DataTable dt8 = controllerObj.Selecttestname();
            comboBox8.DataSource = dt8;
            comboBox8.DisplayMember = "Test_Name";
            comboBox8.ValueMember = "Test_Id";

            comboBox23.DataSource = dt8;
            comboBox23.DisplayMember = "Test_Name";
            comboBox23.ValueMember = "Test_Id";

            comboBox6.DataSource = dt8;
            comboBox6.DisplayMember = "Test_Name";
            comboBox6.ValueMember = "Test_Id";




            DataTable dt3 = controllerObj.Selectdepartmentnames();
            comboBox16.DataSource = dt3;
            comboBox16.DisplayMember = "Department_Name";
            comboBox16.ValueMember = "Department_Number";

            comboBox7.DataSource = dt3;
            comboBox7.DisplayMember = "Department_Name";
            comboBox7.ValueMember = "Department_Number";



            comboBox11.DataSource = dt3;
            comboBox11.DisplayMember = "Department_Name";
            comboBox11.ValueMember = "Department_Number";

            


            /* DataTable dt4 = controllerObj.SelectemployeeType();
             comboBox8.DataSource = dt4;

             comboBox8.DisplayMember = "type";*/

            //added by hoda________________________________________________________________________________________________________________________
            //patients names in receptioinst
            DataTable dt4 = controllerObj.Select_patients_names();
            comboBox10.DataSource = dt4;
            comboBox26.DataSource = dt4;
            comboBox15.DataSource = dt4;
            comboBox24.DataSource = dt4;
            comboBox22.DataSource = dt4;
            comboBox20.DataSource = dt4;

            dt4.Columns.Add(
     "Fullname",
     typeof(string),
     "Patient_Fname +' ' + Patient_Minit+' ' +Patient_Lname+' '+Patient_SSN ");

            comboBox10.DisplayMember = "fullname";
            comboBox10.ValueMember = "Patient_SSN";
            comboBox22.DisplayMember = "fullname";
            comboBox22.ValueMember = "Patient_SSN";
            comboBox20.DisplayMember = "fullname";
            comboBox20.ValueMember = "Patient_SSN";
            

            //departments in receptionist
            DataTable dt5 = controllerObj.Selectdepartmentnames();
            comboBox1.DataSource = dt5;
            comboBox1.DisplayMember = "Department_Name"; 
            comboBox1.ValueMember = "Department_Number";


            comboBox19.DataSource = dt4;
            comboBox19.DisplayMember = "fullname";
            comboBox19.ValueMember = "Patient_SSN";

            comboBox26.DataSource = dt4;
            comboBox26.DisplayMember = "fullname";
            comboBox26.ValueMember = "Patient_SSN";

           // comboBox24.DataSource = dt4;
            comboBox24.DisplayMember = "fullname";
            comboBox24.ValueMember = "Patient_SSN";


            comboBox15.DataSource = dt4;
            comboBox15.DisplayMember = "fullname";
            comboBox15.ValueMember = "Patient_SSN";

            DataTable dt6 = controllerObj.Select_doctor_names();
            comboBox21.DataSource = dt6;
            dt6.Columns.Add(
     "Fullname",
     typeof(string),
     "Fname +' ' + Minit+' ' +Lname+' '+SSN ");
            comboBox21.DisplayMember = "fullname";
            comboBox21.ValueMember = "SSN";

            /*  DataTable dt7 = controllerObj.Select_recep_names();
              comboBox8.DataSource = dt6;
              dt7.Columns.Add(
       "Fullname",
       typeof(string),
       "Fname +' ' + Minit+' ' +Lname+' '+SSN ");
              comboBox8.DisplayMember = "fullname";
              comboBox8.ValueMember = "SSN";*/
            /////////////////////////////////////////////////////////////////
            ///samaa
            DataTable dt17 = controllerObj.Select_medicines();
            comboBox17_med_id.DataSource = dt17;
            comboBox17_med_id.DisplayMember = "Medicine_Name";
            comboBox17_med_id.ValueMember = "Medicine_Id";
            ///
            comboBox13_med_id.DataSource = dt17;
            comboBox13_med_id.DisplayMember = "Medicine_Name";
            comboBox13_med_id.ValueMember = "Medicine_Id";
            ////////////////
            DataTable dt134 = controllerObj.Select_patients_names();
            dt134.Columns.Add(
     "Fullname",
     typeof(string),
     "Patient_Fname +' ' + Patient_Minit+' ' +Patient_Lname+' '+Patient_SSN ");
            comboBox17_patient_ssn_N.DataSource = dt134;
            comboBox17_patient_ssn_N.DisplayMember = "fullname";
            comboBox17_patient_ssn_N.ValueMember = "Patient_SSN";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void T_PFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void T_PMname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void T_PLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void T_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            patientsearch.Visible = false;
            
            examinpatien.Visible = false;
            butt55.Visible = false;
            receptionistpersinform.Visible = false;
            patientreg.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //patienpall.Visible = false;
            //patientptp.Visible = false;
            //patientsearchpanel.Visible = true;
            //patientsearchpanel2.Visible = true;
           // patientreg.Visible = false;
          //  patientsearch.Visible = true;
          

            examinpatien.Visible = false;
            butt55.Visible = false;
            receptionistpersinform.Visible = false;
            patientreg.Visible = false;
            patientsearch.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            ///////////////////////////////////////////////////////////////////////////////
            ///samaa check of username and password
            //1)check if the textBox2(or password_textbox)or user name are empty or not
            if (user_name_textbox.Text == "")
            {
               // user_name_textbox.Focus();
               // user_name_textbox.BackColor = Color.Red;
                MessageBox.Show("Enter the user name");
                return;
            }
            else
            {
               // user_name_textbox.Focus();

               // user_name_textbox.BackColor = Color.White;
            }
            if (password_textbox.Text == "")
            {
               // password_textbox.Focus();

               // password_textbox.BackColor = Color.Red;
                //    forgetbutton.Visible = true;
                MessageBox.Show("Enter the password");
                return;
            }
            else
            {
               // password_textbox.Focus();
               // password_textbox.BackColor = Color.White;

            }
            //2)check if this user name exist
            //this check is important before using convert in step3
           int UA_Count = controllerObj.check_UA_existance(user_name_textbox.Text);
            if (UA_Count == 0)
            {
               // user_name_textbox.Focus();
               // user_name_textbox.BackColor = Color.Red;
                MessageBox.Show("This user name dose not exist");
                return;
            }
            else
            {
              //  password_textbox.Focus();
              //  password_textbox.BackColor = Color.White;
            }
            //3)check password validation4
            DataTable dt = controllerObj.user_sign_in(user_name_textbox.Text);
            string value1 = Convert.ToString(dt.Rows[0].ItemArray[0]);//value1==passwprd

            //if (value1 == "")
            //{
            //    MessageBox.Show("This user name dose not exist");
            //    return;
            //}
            string value2 = Convert.ToString(dt.Rows[0].ItemArray[1]);//valu2==user type
            if (password_textbox.Text == value1)
            {
               // password_textbox.Focus();
              //  password_textbox.BackColor = Color.White;
                //3)check validation of user type
                //if(comboBox1_Role.Text== value2)
                {
                    if (value2 == "Receptionist")
                    {

                        /////////////////////check user name ,pssword///////////////////

                        /// if(!(controllerObj.checkusernameandpassword(user_name_textbox.Text,  user_name_textbox.Text))
                        /// {forgetbutton.Visible = true;
                        /// return;
                        /// }

                        /////////////////////////////////////
                        pharmacistpan.Visible = false;
                        Homepanel.Visible = false;
                        doctorpanel.Visible = false;
                        Adminstratorpan.Visible = false;
                        Accountantpanel.Visible = false;
                        nursepanel.Visible = false;
                        labrotist.Visible = false;
                        receptionistpanel.Visible = true;

                    }
                    else if (value2 == "Doctor")
                    {
                        /////////////////////check user name ,pssword///////////////////

                        /// if(!(controllerObj.checkusernameandpassword(user_name_textbox.Text,  user_name_textbox.Text))
                        /// return;

                        /////////////////////////////////////
                        Homepanel.Visible = false;
                        pharmacistpan.Visible = false;
                        Adminstratorpan.Visible = false;
                        Accountantpanel.Visible = false;
                        receptionistpanel.Visible = false;
                        nursepanel.Visible = false;
                        labrotist.Visible = false;
                        doctorpanel.Visible = true;


                    }
                    else if (value2 == "Administrator")
                    {
                        /////////////////////check user name ,pssword///////////////////

                        /// if(!(controllerObj.checkusernameandpassword(user_name_textbox.Text,  user_name_textbox.Text))
                        /// return;

                        /////////////////////////////////////
                        pharmacistpan.Visible = false;
                        Homepanel.Visible = false;
                        Accountantpanel.Visible = false;
                        receptionistpanel.Visible = false;
                        doctorpanel.Visible = false;
                        nursepanel.Visible = false;
                        labrotist.Visible = false;
                        Adminstratorpan.Visible = true;

                    }
                    else if (value2 == "Nurse")
                    {
                        pharmacistpan.Visible = false;
                        Homepanel.Visible = false;
                        Accountantpanel.Visible = false;
                        receptionistpanel.Visible = false;
                        doctorpanel.Visible = false;
                        Adminstratorpan.Visible = false;

                        labrotist.Visible = false;
                        nursepanel.Visible = true;

                    }
                    else if (value2 == "laboratist")
                    {

                        pharmacistpan.Visible = false;
                        Homepanel.Visible = false;
                        Accountantpanel.Visible = false;
                        receptionistpanel.Visible = false;
                        doctorpanel.Visible = false;
                        Adminstratorpan.Visible = false;
                        nursepanel.Visible = false;
                        labrotist.Visible = true;



                    }
                    else if (value2 == "Pharmacist")
                    {
                        /////////////////////check user name ,pssword///////////////////

                        /// if(!(controllerObj.checkusernameandpassword(user_name_textbox.Text,  user_name_textbox.Text))
                        /// return;

                        /////////////////////////////////////

                        Homepanel.Visible = false;
                        Accountantpanel.Visible = false;
                        receptionistpanel.Visible = false;
                        doctorpanel.Visible = false;
                        Adminstratorpan.Visible = false;
                        nursepanel.Visible = false;
                        labrotist.Visible = false;
                        pharmacistpan.Visible = true;

                    }
                    else if (value2 == "Accountant")
                    {
                        /////////////////////check user name ,pssword///////////////////

                        /// if(!(controllerObj.checkusernameandpassword(user_name_textbox.Text,  user_name_textbox.Text))
                        /// return;

                        /////////////////////////////////////
                        Accountantpanel.Visible = true;
                        Homepanel.Visible = false;
                        receptionistpanel.Visible = false;
                        Adminstratorpan.Visible = false;

                        doctorpanel.Visible = false;
                        pharmacistpan.Visible = false;
                        nursepanel.Visible = false;
                        labrotist.Visible = false;


                        Accountantpanel.Visible = true;
                        //    pharmacistpersonpan.Visible = false;

                    }
                }
                //else
                //{
                //    MessageBox.Show("Invalid type");
                //    return;
                //}


            }
            else
            {
               // password_textbox.Focus();
               // password_textbox.BackColor = Color.Red;
                MessageBox.Show("Invalid password");
                password_textbox.Clear();
                return;
            }
            ////////////////////////////////////////////////////////////////////////////////


        }

        private void button3_Click(object sender, EventArgs e)//receptioinist personal information 
        {
            patientsearch.Visible = false;
            patientreg.Visible = false;
            examinpatien.Visible = false;
            butt55.Visible = false;
            receptionistpersinform.Visible = true;
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (password_textbox.PasswordChar == '*')
            {
                button7.BringToFront();
                password_textbox.PasswordChar = '\0';
            }
        }

        private void Homepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (password_textbox.PasswordChar == '\0')
            {
                button6.BringToFront();
                password_textbox.PasswordChar = '*';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            patientsearch.Visible = false;

            examinpatien.Visible = true;
            butt55.Visible = false;
            receptionistpersinform.Visible = false;
            patientreg.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            drnewpanl.Visible = false;
            patientexaminatpan.Visible = false;
            drpersonalinform.Visible = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            drnewpanl.Visible = false;
            
            drpersonalinform.Visible = false;
            patientexaminatpan.Visible = true;
        }

        private void label88_Click(object sender, EventArgs e)
        {

        }

        

        private void button27_Click(object sender, EventArgs e)
        {

        }

       

       

        private void button16_Click(object sender, EventArgs e)
        {
            Updatedepartpan.Visible = false;
            Updateemployeepan.Visible = false;
            insertdepartmentpanl.Visible = false;
            insertemployee.Visible = false;
            Showemployee.Visible = false;
            Showsatistics.Visible = false;
            adminstratorpersinfpanl.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Updatedepartpan.Visible = false;
            Updateemployeepan.Visible = false;
            insertdepartmentpanl.Visible = true;
            insertemployee.Visible = false;
            Showemployee.Visible = false;
            Showsatistics.Visible = false;
            adminstratorpersinfpanl.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Updatedepartpan.Visible = false;
            Updateemployeepan.Visible = false;
            insertdepartmentpanl.Visible = false;
            insertemployee.Visible = true;
            Showemployee.Visible = false;
            Showsatistics.Visible = false;
            adminstratorpersinfpanl.Visible = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Updatedepartpan.Visible = false;
            Updateemployeepan.Visible = true;
            insertdepartmentpanl.Visible = false;
            insertemployee.Visible = false;
            Showemployee.Visible = false;
            Showsatistics.Visible = false;
            adminstratorpersinfpanl.Visible = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Updatedepartpan.Visible = true;
            Updateemployeepan.Visible = false;
            insertdepartmentpanl.Visible = false;
            insertemployee.Visible = false;
            Showemployee.Visible = false;
            Showsatistics.Visible = false;
            adminstratorpersinfpanl.Visible = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //0)empty
            if(comboBox17_med_id.Text == "")
            {
                MessageBox.Show("Select Medicine");
                return;
            }
            //1)
            //Later: validation 



            //string value1 //value1==passwprd
            //2)
            //DataTable dt = controllerObj.Select_Med_info(comboBox17_med_id.Text);
            DataTable dt = controllerObj.Select_Med_info(comboBox17_med_id.SelectedValue.ToString());/////////////////////////////
            textBox43_med_pri.Text = Convert.ToString(dt.Rows[0].ItemArray[0]);
            textBox41_med_quant.Text = Convert.ToString(dt.Rows[0].ItemArray[1]);
            //3)make panel14 visible
            panel14.Visible = true;
        }

        private void button31_Click(object sender, EventArgs e)
        {
           panel14.Visible = false;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            // panel14.Visible = false;
            int result = controllerObj.delete_Medicine(comboBox17_med_id.SelectedValue.ToString());/////////////////////////////////
            if (result == 0)
            {
                MessageBox.Show("The deletion failed");
            }
            else
            {
                MessageBox.Show("The row is deleted successfully!");
            }

        }

        private void button39_Click(object sender, EventArgs e)
        {
            //1)empty
            if (comboBox17_patient_ssn_N.Text == "")
            {
                MessageBox.Show("Select the patient");
                return;
            }
            if (comboBox13_med_id.Text == "")
            {
                MessageBox.Show("Select the medicine");
                return;
            }
            if (assign_Medicine_Quantinty.Text == "")
            {
                MessageBox.Show("Enter the medicine Quantinty");
                return;
            }
            if (dateTimePicker8.Text == "")
            {
                MessageBox.Show("Enter the Date");
                return;
            }
            //Later:
            //2)comboboxes validation

            //3_assign
            DataTable dt = controllerObj.Select_Med_info(comboBox13_med_id.SelectedValue.ToString());
            int old_med_quantity = Convert.ToInt32(dt.Rows[0].ItemArray[1]);//value1==passwprd
            if (old_med_quantity == 0)
            {
                MessageBox.Show("This medicine is finished");
                return;
            }
            int req_quant = Convert.ToInt32(assign_Medicine_Quantinty.Text);
            int new_med_quantity = old_med_quantity - req_quant;
            if (new_med_quantity < 0)
            {
                string msg = "The current quantinty of this medicine = " + old_med_quantity;
                MessageBox.Show(msg);
                MessageBox.Show("Failed to assign the medicine");
                return;
            }
            if (new_med_quantity == 0)
            {
                MessageBox.Show("This medicine is finished now");
                //no return here
            }
            int result1 = controllerObj.assign_P_Med(comboBox13_med_id.SelectedValue.ToString(), comboBox17_patient_ssn_N.SelectedValue.ToString(), dateTimePicker8.Text);
            if (result1 != 0)//note:!=0 not ==0
            {
                int result2 = controllerObj.Update_med_quantity(new_med_quantity.ToString(), comboBox13_med_id.SelectedValue.ToString());
                if (result2 == 0)
                {
                    MessageBox.Show("Failed to update the medicine quantinty");

                }
                else
                {
                    MessageBox.Show("The medicine is assigned successfully!");
                }
            }
            else
            {
                MessageBox.Show("Failed to assign the medicine");
            }
        }
        private void button33_Click(object sender, EventArgs e)
        {
            pharmacistpersonpan.Visible = true;
            Assigmedivtopatpan.Visible = false;
            Upadtemedipan.Visible = false;
            insertmedicineinform.Visible = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {

            pharmacistpersonpan.Visible = false;
            Assigmedivtopatpan.Visible = false;
            Upadtemedipan.Visible = false;
            insertmedicineinform.Visible = true;
        }

        private void button36_Click(object sender, EventArgs e)
        {

            pharmacistpersonpan.Visible = false;
            Assigmedivtopatpan.Visible = false;
            Upadtemedipan.Visible = true;
            insertmedicineinform.Visible = false;
        }

        private void button37_Click(object sender, EventArgs e)
        {

            pharmacistpersonpan.Visible = false;
            Assigmedivtopatpan.Visible = true;
            Upadtemedipan.Visible = false;
            insertmedicineinform.Visible = false;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Accontapersonalinf.Visible = true;
            Accountingpanel.Visible = false;
            Updateempsalary.Visible = false;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Accontapersonalinf.Visible = false;
            Accountingpanel.Visible = true;
            Updateempsalary.Visible = false;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Homepanel.Visible = true;
            pharmacistpan.Visible = false;
            doctorpanel.Visible = false;
            Adminstratorpan.Visible = false;
            Accountantpanel.Visible = false;
            nursepanel.Visible = false;
            labrotist.Visible = false;
            receptionistpanel.Visible = false;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Homepanel.Visible = true;
            pharmacistpan.Visible = false;
            doctorpanel.Visible = false;
            Adminstratorpan.Visible = false;
            Accountantpanel.Visible = false;
            nursepanel.Visible = false;
            labrotist.Visible = false;
            receptionistpanel.Visible = false;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Homepanel.Visible = true;
            pharmacistpan.Visible = false;
            doctorpanel.Visible = false;
            Adminstratorpan.Visible = false;
            Accountantpanel.Visible = false;
            nursepanel.Visible = false;
            labrotist.Visible = false;
            receptionistpanel.Visible = false;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Homepanel.Visible = true;
            pharmacistpan.Visible = false;
            doctorpanel.Visible = false;
            Adminstratorpan.Visible = false;
            Accountantpanel.Visible = false;
            nursepanel.Visible = false;
            labrotist.Visible = false;
            receptionistpanel.Visible = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Homepanel.Visible = true;
            pharmacistpan.Visible = false;
            doctorpanel.Visible = false;
            Adminstratorpan.Visible = false;
            Accountantpanel.Visible = false;
            nursepanel.Visible = false;
            labrotist.Visible = false;
            receptionistpanel.Visible = false;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            Accontapersonalinf.Visible = false;
            Accountingpanel.Visible = false;
            Updateempsalary.Visible = true;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button49_Click(object sender, EventArgs e)
        {

        }

        private void button49_Click_1(object sender, EventArgs e)
        {

        }

        private void forgetbutton_Click(object sender, EventArgs e)
        {
            Form3 form3 =new Form3();
            form3.Show();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            
            //if(comboBox14.Text !="")
                
                {
                    DataTable dt = controllerObj.Selectemployeewithssn(Convert.ToInt32(comboBox14.SelectedValue.ToString()));
                    dataGridView6.DataSource = dt;
                    dataGridView6.Refresh();
                }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            int result;
            int v;
            if (textBox1.Text != "")
            {
                if (Int32.TryParse(textBox1.Text, out v))
                {
                    if (v < 200 || v > 50000)
                    {
                        MessageBox.Show("Enter a valid salary.");
                        result = 0;
                    }
                    else
                    result = controllerObj.UpdateSalary(Convert.ToInt32(comboBox14.SelectedValue.ToString()), v);
                }
                else
                {
                    result = 0;
                }

                if (result == 0)
                {
                    MessageBox.Show("The insertion  failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully!");
                }


            }
            else
                MessageBox.Show("please enter all values !");


        }

        private void button49_Click_2(object sender, EventArgs e)
        {

            {
                DataTable dt = controllerObj.Selectemployeeusername(user_name_textbox.Text);
                dataGridView7.DataSource = dt;
                dataGridView7.Refresh();


                DataTable dt2 = controllerObj.Selectemployeedepartment(user_name_textbox.Text);
                dataGridView27.DataSource = dt2;
                dataGridView27.Refresh();


                DataTable dt3 = controllerObj.Selectemployeemobiles(user_name_textbox.Text);
                dataGridView26.DataSource = dt3;
                dataGridView26.Refresh();

            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox17.Text == "" || textBox20.Text == "")
                MessageBox.Show("please enter all values");
            else
            {
                int v;
                int result;
                if (Int32.TryParse(textBox17.Text, out v))
                {
                    if (controllerObj.check_departmentNum(v) == 1)
                    {
                        MessageBox.Show("a department with the same number exists !");
                        result = 0;
                    }

                    else if (controllerObj.check_departmentName(textBox20.Text) == 1)
                    {

                        MessageBox.Show("a department with the same name exists !");
                        result = 0;
                    }

                    else if (controllerObj.check_manegerssn(Convert.ToInt32(comboBox3.SelectedValue.ToString())) == 1)
                    {

                        MessageBox.Show("this employee is already a maneger to another department  !");
                        result = 0;
                    }
                    else
                    {
                        if (v <= 0 || v > 50)
                        {
                            MessageBox.Show("Enter a valid department number!");
                            result = 0;
                        }
                        else
                        result = controllerObj.Insertdepartment(v, textBox20.Text, Convert.ToInt32(comboBox3.SelectedValue.ToString()), dateTimePicker3.Text);
                    }
                }
                else
                {
                    MessageBox.Show("please enter correct values ");
                    result = 0;
                }
                
                if (result == 0)
                {
                    MessageBox.Show("The insertion  failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully!");
                }
            }







        }

        private void button28_Click(object sender, EventArgs e)
        {
            int result;
            
          /*  if (comboBox3.SelectedValue.ToString() != "")
            {*/

                result = controllerObj.deleteDepartment(Convert.ToInt32(comboBox16.SelectedValue.ToString()));

              

                if (result == 0)
                {
                    MessageBox.Show("The deletion  failed");
                }
                else
                {
                    MessageBox.Show("The row is deleted successfully!");
                }


           /* }
            else
                MessageBox.Show("please enter all values !");*/


        }

        private void button27_Click_1(object sender, EventArgs e)
        {

            int result;

            /*  if (comboBox3.SelectedValue.ToString() != "")
              {*/
            if (controllerObj.check_manegerssn(Convert.ToInt32(comboBox12.SelectedValue.ToString())) == 1)
            {

                MessageBox.Show("this employee is already a maneger to another department  !");
                result = 0;
            }
            else
            {
                result = controllerObj.updateDepartment(Convert.ToInt32(comboBox16.SelectedValue.ToString()), Convert.ToInt32(comboBox12.SelectedValue.ToString()), dateTimePicker11.Text);
                if (result == 0)
                {
                    MessageBox.Show("The edition  failed");
                }
                else
                {
                    MessageBox.Show("The row is edited successfully!");
                }

            }
            /* }
             else
                 MessageBox.Show("please enter all values !");*/


        }

        private void button29_Click(object sender, EventArgs e)
        {
            {
                DataTable dt = controllerObj.Selectemployeeusername(user_name_textbox.Text);
                dataGridView8.DataSource = dt;
                dataGridView8.Refresh();

                DataTable dt2 = controllerObj.Selectemployeedepartment(user_name_textbox.Text);
                dataGridView24.DataSource = dt2;
                dataGridView24.Refresh();


                DataTable dt3 = controllerObj.Selectemployeemobiles(user_name_textbox.Text);
                dataGridView25.DataSource = dt3;
                dataGridView25.Refresh();



            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "" || textBox8.Text == "" || textBox18.Text == "" || textBox19.Text == "" || textBox22.Text == "" || textBox27.Text == "" || textBox21.Text == "")
            {
                MessageBox.Show("please enter all values");
            }
            else if(textBox29.Text == "" && textBox32.Text=="")
            {
                MessageBox.Show("please, enter at least one valid mobile  ");

            }

            else if (textBox29.Text != "" &&
  ((textBox29.Text.Length != 11 || textBox29.Text[0] != '0' || textBox29.Text[1] != '1')
   || (textBox29.Text[2] == '3' || textBox29.Text[2] == '4' || textBox29.Text[2] == '5' || textBox29.Text[2] == '6' || textBox29.Text[2] == '7' || textBox29.Text[2] == '8' || textBox29.Text[2] == '9')))
            {
                MessageBox.Show("Invalid Mobile number 1.");
            }
            else if (textBox32.Text != "" &&
((textBox32.Text.Length != 11 || textBox32.Text[0] != '0' || textBox32.Text[1] != '1')
|| (textBox32.Text[2] == '3' || textBox32.Text[2] == '4' || textBox32.Text[2] == '5' || textBox32.Text[2] == '6' || textBox32.Text[2] == '7' || textBox32.Text[2] == '8' || textBox32.Text[2] == '9')))
            {
                MessageBox.Show("Invalid Mobile number 2.");
            }
            else if (textBox29.Text != "" && controllerObj.check_mobE(textBox29.Text) == 1)
            {
                MessageBox.Show("This mobile already exists.");
            }
            else if (textBox32.Text != "" && controllerObj.check_mobE(textBox32.Text) == 1)
            {
                MessageBox.Show("This mobile already exists.");
            }
            else if (Convert.ToDateTime(dateTimePicker2.Text) > DateTime.Now || Convert.ToDateTime(dateTimePicker5.Text) <= Convert.ToDateTime(dateTimePicker2.Text))
            {
                 MessageBox.Show("please enter a valid date ! .");
            }
            else
            {
                int v1;
                int v2;
                int result;

                if (Int32.TryParse(textBox7.Text, out v1) && Int32.TryParse(textBox27.Text, out v2))

                {
                    if (controllerObj.check_ssn(v1) == 1)
                    {
                        MessageBox.Show("an employee with the same ssn already exists! ");
                        result = 0;
                    }
                    else if (controllerObj.check_Email(textBox21.Text) == 1)
                    {
                        MessageBox.Show("an employee with the same Email already exists! ");
                        result = 0;
                    }

                    else if (textBox21.Text.Contains('@') == false)
                    {
                        MessageBox.Show("invalid Email ! ");
                        result = 0;
                    }

                    else
                    {

                        if (v2 < 200 || v2 > 50000)
                        {
                            MessageBox.Show("Please, Enter a valid salary");
                            result = 0;
                        }
                        else

                            result = controllerObj.InsertEmployee(v1, textBox8.Text, textBox18.Text, textBox19.Text, textBox21.Text, textBox22.Text, comboBox18.Text, v2, comboBox28.Text, dateTimePicker2.Text, Convert.ToInt32(comboBox7.SelectedValue.ToString()), dateTimePicker5.Text);
                        if (textBox29.Text != "")
                        {
                            if (controllerObj.check_mobE(textBox29.Text) == 1)
                            {
                                MessageBox.Show("This mobile already exists.");
                            }
                            else
                            {
                                controllerObj.Insert_Employee_Mobile(v1, textBox29.Text);

                            }
                        }


                        if (textBox32.Text != "")
                        {
                            if (controllerObj.check_mobE(textBox32.Text) == 1)
                            {
                                MessageBox.Show("This mobile already exists.");
                            }
                            else
                            {
                                controllerObj.Insert_Employee_Mobile(v1, textBox32.Text);
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("please enter correct values ");
                    result = 0;
                }
                if (result == 0)
                {
                    MessageBox.Show("The insertion  failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully!");
                }
            }


        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label84_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            int result;

            /*  if (comboBox3.SelectedValue.ToString() != "")
              {*/

            result = controllerObj.deleteEmployee(Convert.ToInt32(comboBox4.SelectedValue.ToString()));



            if (result == 0)
            {
                MessageBox.Show("The deletion  failed");
            }
            else
            {
                MessageBox.Show("The row is deleted successfully!");
            }


            /* }
             else
                 MessageBox.Show("please enter all values !");*/




        }

        private void button23_Click(object sender, EventArgs e)
        {


            

            if (textBox30.Text == "" )
                MessageBox.Show("please enter all values");
            else
            {
                int v1;
               
                int result;

                if (Int32.TryParse(textBox30.Text, out v1))
                {
                    if(v1<200||v1>50000)
                    {

                        MessageBox.Show("please enter a valid salary ");
                        result = 0;
                    }
                    else

                    result = controllerObj.updateEmployeeSalary(Convert.ToInt32(comboBox4.SelectedValue.ToString()), v1);
                }
                else
                {

                    MessageBox.Show("please enter correct values ");
                    result = 0;
                }
           



            if (result == 0)
            {
                MessageBox.Show("The edition  failed");
            }
            else
            {
                MessageBox.Show("The row is edited successfully!");
            }
            }


            


            /* }
             else
              MessageBox.Show("please enter all values !");*/
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox31.Text == "")
                MessageBox.Show("please enter all values");
            else
            {
               
                int result;
               
                    result = controllerObj.updateEmployeeAddress(Convert.ToInt32(comboBox4.SelectedValue.ToString()), textBox31.Text);


                    if (result == 0)
                    {
                        MessageBox.Show("The edition  failed");
                    }
                    else
                    {
                        MessageBox.Show("The row is edited successfully!");
                    }
                
            }


        }

        private void button53_Click(object sender, EventArgs e)
        {
            int result;


            result = controllerObj.updateEmployeeDno(Convert.ToInt32(comboBox4.SelectedValue.ToString()), Convert.ToInt32(comboBox11.SelectedValue.ToString()));


                if (result == 0)
                {
                    MessageBox.Show("The edition  failed");
                }
                else
                {
                    MessageBox.Show("The row is edited successfully!");
                }
            
        }

        private void button41_Click(object sender, EventArgs e)
        {


        }

        private void user_name_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button54_Click(object sender, EventArgs e)//get receptionist personal information 
        {
            DataTable dt = controllerObj.Selectemployeeusername(user_name_textbox.Text);
            dataGridView9.DataSource = dt;
            dataGridView9.Refresh();

            DataTable dt2 = controllerObj.Selectemployeedepartment(user_name_textbox.Text);
            dataGridView20.DataSource = dt2;
            dataGridView20.Refresh();


            DataTable dt3 = controllerObj.Selectemployeemobiles(user_name_textbox.Text);
            dataGridView21.DataSource = dt3;
            dataGridView21.Refresh();


        }

        private void receptionistpersinform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)//insert patient from receptionist
        {
            int result1;
           // int v;
            //check for empty not null cell
            if (textBox10.Text == "" || textBox13.Text == "" || textBox12.Text == "" || textBox11.Text == "" || textBox14.Text == "" || comboBox9.Text == "")
            {
                result1 = 0;
                MessageBox.Show("Please, fill the required information.");
            }

           else
                {

                    //check for mobile if exist 01 ,11digit
                    if (textBox9.Text != "" &&
     ((textBox9.Text.Length != 11 || textBox9.Text[0] != '0' || textBox9.Text[1] != '1')
      || (textBox9.Text[2] == '3' || textBox9.Text[2] == '4' || textBox9.Text[2] == '5' || textBox9.Text[2] == '6' || textBox9.Text[2] == '7' || textBox9.Text[2] == '8' || textBox9.Text[2] == '9')))
                    {
                        MessageBox.Show("Invalid Mobile number 1.");
                    }
                    else if (textBox15.Text != "" &&
        ((textBox15.Text.Length != 11 || textBox15.Text[0] != '0' || textBox15.Text[1] != '1')
        || (textBox15.Text[2] == '3' || textBox15.Text[2] == '4' || textBox15.Text[2] == '5' || textBox15.Text[2] == '6' || textBox15.Text[2] == '7' || textBox15.Text[2] == '8' || textBox15.Text[2] == '9')))
                    {
                        MessageBox.Show("Invalid Mobile number 2.");
                    }
                    else
                    {

                        if (controllerObj.check_ssn_patient(Convert.ToInt32(textBox10.Text)) == 1)
                        {
                            result1 = 0;
                            MessageBox.Show("This ssn already exists.");
                        }

                        else
                        {
                            result1 = controllerObj.Insert_Patient(Convert.ToInt32(textBox10.Text), textBox13.Text, textBox12.Text, textBox11.Text, Convert.ToInt16(textBox14.Text), textBox16.Text, comboBox9.Text);
                            if (result1 == 0)
                            {
                                MessageBox.Show("The insertion  failed");
                            }
                            else
                            {
                                MessageBox.Show("The row is inserted successfully!");
                            }

                            if (textBox9.Text != "")
                            {
                                if (controllerObj.check_mobP(textBox9.Text) == 1)
                                {
                                    MessageBox.Show("This mobile already exists.");
                                }
                                else
                                {
                                    int result2 = controllerObj.Insert_Patient_Mobile(Convert.ToInt32(textBox10.Text), textBox9.Text);
                                    if (result2 == 0)
                                    {
                                        MessageBox.Show("The insertion  failed");
                                    }
                                    else
                                    {
                                        MessageBox.Show("The row is inserted successfully!");
                                    }
                                }
                            }
                            if (textBox15.Text != "")
                            {
                                if (controllerObj.check_mobP(textBox15.Text) == 1)
                                {
                                    MessageBox.Show("This mobile already exists.");
                                }
                                else
                                {
                                    int result2 = controllerObj.Insert_Patient_Mobile(Convert.ToInt32(textBox10.Text), textBox15.Text);
                                    if (result2 == 0)
                                    {
                                        MessageBox.Show("The insertion  failed");
                                    }
                                    else
                                    {
                                        MessageBox.Show("The row is inserted successfully!");
                                    }
                                }
                            }
                        }

                    }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Select_patient_withssn2(Convert.ToInt32(comboBox10.SelectedValue.ToString()));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            DataTable dt1 = controllerObj.Select_patient_mobile(Convert.ToInt32(comboBox10.SelectedValue.ToString()));
            dataGridView10.DataSource = dt1;
            dataGridView10.Refresh();

        }

        private void button8_Click(object sender, EventArgs e)//search for available doctors // updated
        {
            DataTable dt = controllerObj.Select_Doctors_available_inDepartment(Convert.ToInt32(comboBox1.SelectedValue.ToString()),dateTimePicker14.Text);
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();

            if (dataGridView2.Rows.Count > 0 && dataGridView2.Rows != null)
            {
                DataTable dt1 = controllerObj.Select_Doctors_available_inDepartment(Convert.ToInt32(comboBox1.SelectedValue.ToString()), dateTimePicker14.Text);
                comboBox2.DataSource = dt1;
                dt1.Columns.Add(
          "Fullname",
          typeof(string),
          "Fname +' ' + Minit+' ' +Lname+' '+ Doctor_SSN +' '+ Doctor_Date");

                comboBox2.DisplayMember = "fullname";
                comboBox2.ValueMember = "Doctor_SSN";
                
            }
            else
            {
                MessageBox.Show("No Available doctors");
            }
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)//add an appointment
        {
            if (comboBox2.Text == "" || comboBox19.Text == "" || dateTimePicker4.Text == "" || textBox6.Text == "" /*|| textBox3.Text == ""*/)
            {
                MessageBox.Show("Please, fill the required information.");
            }
            else 
            {
                if (dateTimePicker4.Value < dateTimePicker14.Value)
                 {
                      MessageBox.Show("Please, Enter a valid date.");
                 }
                if (controllerObj.count_doctor_date(Convert.ToInt32(comboBox2.SelectedValue.ToString()), dateTimePicker4.Text) == 0)
                {
                    MessageBox.Show("This appointment is not available.");
                }
                else if (controllerObj.count_examine(Convert.ToInt32(comboBox2.SelectedValue.ToString()), dateTimePicker4.Text, Convert.ToInt32(comboBox19.SelectedValue.ToString())) == 1)
                {
                    MessageBox.Show("This appointment alredy exists.");
                }
                if (Convert.ToInt32(textBox6.Text) < 20 || Convert.ToInt32(textBox6.Text) < 5000)
                {
                    MessageBox.Show("Please, Enter a valid price.");
                }
                else
                {
                    int v = controllerObj.get_var_patient_number(Convert.ToInt32(comboBox2.SelectedValue.ToString()), dateTimePicker4.Text) + 1;
                    textBox3.Text = v.ToString();
                    int result = controllerObj.Insert_Examine(Convert.ToInt32(comboBox2.SelectedValue.ToString()), Convert.ToInt32(comboBox19.SelectedValue.ToString()), dateTimePicker4.Text, Convert.ToInt16(textBox6.Text), Convert.ToInt16(textBox3.Text));
                    if (result == 0)
                    {
                        MessageBox.Show("The insertion  failed");
                    }
                    else
                    {
                        MessageBox.Show("The row is inserted successfully!");
                        controllerObj.Update_var_patient_number(Convert.ToInt32(comboBox2.SelectedValue.ToString()), dateTimePicker4.Text);
                    }
                }
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void drpersonalinform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button55_Click(object sender, EventArgs e)//get doctor personal information
        {
            DataTable dt = controllerObj.Selectemployeeusername(user_name_textbox.Text);
            dataGridView5.DataSource = dt;
            dataGridView5.Refresh();

            DataTable dt2 = controllerObj.Selectemployeedepartment(user_name_textbox.Text);
            dataGridView28.DataSource = dt2;
            dataGridView28.Refresh();


            DataTable dt3 = controllerObj.Selectemployeemobiles(user_name_textbox.Text);
            dataGridView29.DataSource = dt3;
            dataGridView29.Refresh();

        }

        private void button56_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Select_Doctors_schedule(user_name_textbox.Text,dateTimePicker16.Text);
            dataGridView5.DataSource = dt;
            dataGridView5.Refresh();
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button62_Click(object sender, EventArgs e)
        {
            nursepersonla.Visible = false;
            medicalreport.Visible = true;
        }

        private void button61_Click(object sender, EventArgs e)
        {
            nursepersonla.Visible = true;
            medicalreport.Visible = false;
        }

        private void nursepersonla_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button20_Click_1(object sender, EventArgs e)//get nurse personal info
        {
            DataTable dt = controllerObj.Selectemployeeusername(user_name_textbox.Text);
            dataGridView3.DataSource = dt;
            dataGridView3.Refresh();

            DataTable dt2 = controllerObj.Selectemployeedepartment(user_name_textbox.Text);
            dataGridView22.DataSource = dt2;
            dataGridView22.Refresh();


            DataTable dt3 = controllerObj.Selectemployeemobiles(user_name_textbox.Text);
            dataGridView23.DataSource = dt3;
            dataGridView23.Refresh();

        }

        private void button57_Click(object sender, EventArgs e)
        {

            if (textBox5.Text == "" ||textBox45.Text == "" || textBox46.Text == "" || textBox47.Text == "" || textBox50.Text == "" || textBox51.Text == "")
                MessageBox.Show("please enter all values");

                 else if(controllerObj.check_medicalreprtid(Convert.ToInt32(textBox5.Text))==1)
            {
                MessageBox.Show("A reoprt  with the same id already exists.");
            }
            else
            {
                int v1,v2,v3,v4,v5,v6;
                
                int result;
                
                if (Int32.TryParse(textBox5.Text, out v1) && Int32.TryParse(textBox45.Text, out v2) && Int32.TryParse(textBox46.Text, out v3) && Int32.TryParse(textBox47.Text, out v4) && Int32.TryParse(textBox50.Text, out v5) && Int32.TryParse(textBox51.Text, out v6))
                    if (v1 > 0 && v2 >= 60 && v2 <= 200 && v3 >= 50 && v3 <= 120 && v4 >= 60 && v4 <= 600 && v5 >= 50 && v5 <= 250 && v6 >= 1 && v6 <= 500)
                        result = controllerObj.Insertmedicalreport(v1, Convert.ToInt32(comboBox24.SelectedValue.ToString()), dateTimePicker12.Text, v2, v3, v4, v5, v6);
                    else
                    {
                        MessageBox.Show("please enter correct values ");
                        result = 0;
                    }
                else
                {
                   // if (textBox45.Text != "" || textBox46.Text != "" || textBox47.Text != "" || textBox50.Text != "" || textBox51.Text != "")
                    MessageBox.Show("please enter correct values ");
                    result = 0;
                }
                
                if (result == 0)
                {
                    MessageBox.Show("The insertion  failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully!");
                }
            }





        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button41_Click_1(object sender, EventArgs e)
        {

            DataTable dt = controllerObj.Selectexamineprice(Convert.ToInt32(comboBox26.SelectedValue.ToString()),dateTimePicker9.Text);
            dataGridView4.DataSource = dt;
            dataGridView4.Refresh();

        }

        private void button65_Click(object sender, EventArgs e)
        {
            Homepanel.Visible = true;
            pharmacistpan.Visible = false;
            doctorpanel.Visible = false;
            Adminstratorpan.Visible = false;
            Accountantpanel.Visible = false;
            nursepanel.Visible = false;
            labrotist.Visible = false;
            receptionistpanel.Visible = false;
        }

        private void button68_Click(object sender, EventArgs e)
        {
            updatelabtest.Visible = true;
            labbutt4.Visible = false;
            labpersonalinfo.Visible = false;
            addlabtest.Visible = false;
        }

        private void button69_Click(object sender, EventArgs e)
        {
            labbutt4.Visible = true;
            updatelabtest.Visible = false;
            labpersonalinfo.Visible = false;
            addlabtest.Visible = false;

        }

        private void button64_Click(object sender, EventArgs e)
        {
            labpersonalinfo.Visible = true;
            labbutt4.Visible = false;
            updatelabtest.Visible = false;
            addlabtest.Visible = false;
        }

        private void button66_Click(object sender, EventArgs e)
        {
            addlabtest.Visible = true;
            labpersonalinfo.Visible = false;
            labbutt4.Visible = false;
            updatelabtest.Visible = false;

        }

        private void button71_Click(object sender, EventArgs e)
        {
            butt55.Visible = true;
            patientsearch.Visible = false;
            patientreg.Visible = false;
            receptionistpersinform.Visible = false;
            examinpatien.Visible = false;
        }

        private void button72_Click(object sender, EventArgs e)
        {
            patientexaminatpan.Visible = false;
            drpersonalinform.Visible = false;
            drnewpanl.Visible = true;
        }

        private void button58_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Selectlabtestprice(Convert.ToInt32(comboBox26.SelectedValue.ToString()), dateTimePicker9.Text);
            dataGridView11.DataSource = dt;
            dataGridView11.Refresh();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Selectmedicineprice(Convert.ToInt32(comboBox26.SelectedValue.ToString()), dateTimePicker9.Text);
            dataGridView12.DataSource = dt;
            dataGridView12.Refresh();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Selectemployeeusername(user_name_textbox.Text);
            dataGridView14.DataSource = dt;
            dataGridView14.Refresh();


            DataTable dt2 = controllerObj.Selectemployeedepartment(user_name_textbox.Text);
            dataGridView18.DataSource = dt2;
            dataGridView18.Refresh();


            DataTable dt3 = controllerObj.Selectemployeemobiles(user_name_textbox.Text);
            dataGridView19.DataSource = dt3;
            dataGridView19.Refresh();




        }

        private void button63_Click(object sender, EventArgs e)
        {

            if (textBox52.Text == "" || textBox53.Text == "" || textBox49.Text == "" ||comboBox17.Text=="")
                MessageBox.Show("please enter all values");
            else
            {
                int v1,v2;
                int result;
                if (Int32.TryParse(textBox53.Text, out v1) && Int32.TryParse(textBox49.Text, out v2))
                    
                    {
                        if (controllerObj.check_labid(v1) == 1)
                        {
                            MessageBox.Show("this lab test id already exists !");
                            result = 0;
                        }
                        else if (controllerObj.check_labname(textBox52.Text) == 1)
                        {
                            MessageBox.Show("this lab test name already exists !");
                            result = 0;
                        }
                        else
                        {
                            if (v2 < 5 || v2 > 5000)
                            {
                                MessageBox.Show("Enter a valid price !");
                                result = 0;
                            }
                            else
                            result = controllerObj.Insertlabtest(v1, textBox52.Text, v2,comboBox17.Text);
                        }
                      }
                else
                {
                    MessageBox.Show("please enter correct values ");
                    result = 0;
                }
                if (result == 0)
                {
                    MessageBox.Show("The insertion  failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully!");
                }
            }

        }

        private void button60_Click(object sender, EventArgs e)
        {

            if (textBox4.Text == "")
                MessageBox.Show("please enter all values");
            else
            {

                int result;
                int v;
                if (int.TryParse(textBox4.Text, out v) && v > 0 && v > 5 && v < 5000)
                {
                    result = controllerObj.updatelabprice(Convert.ToInt32(comboBox8.SelectedValue.ToString()), v);
                }
                else
                {
                    result = 0;
                    MessageBox.Show("please enter a valid price");
                }

                if (result == 0)
                {
                    MessageBox.Show("The edition  failed");
                }
                else
                {
                    MessageBox.Show("The row is edited successfully!");
                }

            }

        }

        private void button73_Click(object sender, EventArgs e)
        {

           

                int result;

                    result = controllerObj.deletelabtest(Convert.ToInt32(comboBox8.SelectedValue.ToString()));
               


                if (result == 0)
                {
                    MessageBox.Show("The edition  failed");
                }
                else
                {
                    MessageBox.Show("The row is edited successfully!");
                }
            




        }

        private void button74_Click(object sender, EventArgs e)
        {
           
              
                int result;
                if (comboBox15.Text == "" || comboBox23.Text == "")
                {
                    MessageBox.Show("please enter all values !");
                    result = 0;
                }
                else if (comboBox15.SelectedValue==null || comboBox23.SelectedValue==null)
                {
                    MessageBox.Show("please enter correct values !");
                    result = 0;
                }

                else if (controllerObj.check_patientssn(Convert.ToInt32(comboBox15.SelectedValue.ToString())) == 0)
                {
                    MessageBox.Show("there is no patient with that name !");
                    result = 0;
                }

                else if (controllerObj.check_labid(Convert.ToInt32(comboBox23.SelectedValue.ToString())) == 0)
                {
                    MessageBox.Show("there is no lab test with that name !");
                    result = 0;
                }



                else
                {
                    if (controllerObj.get_isav(Convert.ToInt32(comboBox23.SelectedValue.ToString())) == "No")
                    {
                        MessageBox.Show("this lab test is not available !");
                        result = 0;
                    }
                    else
                    result = controllerObj.Insertintohave(Convert.ToInt32(comboBox15.SelectedValue.ToString()), Convert.ToInt32(comboBox23.SelectedValue.ToString()), dateTimePicker10.Text);
                }
                    if (result == 0)
                    {
                        MessageBox.Show("The insertion  failed");
                    }
                    else
                    {
                        MessageBox.Show("The row is inserted successfully!");
                    }



            

        }

        private void button13_Click(object sender, EventArgs e)//insert presc and insert write presc
        {
            if (textBox2.Text == "" || comboBox22.Text=="")
            {
                MessageBox.Show("Please, Enter all values.");
            }
            else if (controllerObj.count_presc_id(Convert.ToInt32(textBox2.Text)) == 1)
            {
                MessageBox.Show("A prescription with the same id already exists.");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");

                int result = controllerObj.Insert_presc(Convert.ToInt32(textBox2.Text), textBox23.Text);

                if (result == 0)
                {
                    MessageBox.Show("The insertion  failed");
                }
                else
                {
                    if (comboBox22.Text == "")
                    {
                        MessageBox.Show("Please, select a patient.");
                    }
                    else
                    {
                        int dssn = controllerObj.get_ssn_of_username(user_name_textbox.Text);
                        if (controllerObj.count_doctor_date(dssn, dateTimePicker1.Text) == 0)
                        {
                            MessageBox.Show("Please, enter a valid date.");
                        }
                        else
                        {
                            int result1 = controllerObj.Insert_write_presc(dssn, dateTimePicker1.Text, Convert.ToInt32(comboBox22.SelectedValue.ToString()), Convert.ToInt32(textBox2.Text));
                            if (result1 == 0)
                            {
                                MessageBox.Show("The insertion  failed");
                            }
                            else
                            {
                                MessageBox.Show("The row is inserted successfully!");
                            }
                        }
                    }
                }
            }
        }

        private void button75_Click(object sender, EventArgs e)//insert pre_medicine
        {
            if(textBox2.Text=="" )
            {
                MessageBox.Show("Add a prescription first.");
            }
            else if(comboBox5.Text == "" || textBox25.Text == "")
            {
                MessageBox.Show("Choose a medicine and enter its dosage.");
            }
            else if (controllerObj.count_presc_id(Convert.ToInt32(textBox2.Text)) != 1)
            {
                MessageBox.Show("A prescription with this id not exist.");
            }
            else if(controllerObj.count_med_pre(Convert.ToInt32(comboBox5.SelectedValue.ToString()), Convert.ToInt32(textBox2.Text)) == 1)
            {
                MessageBox.Show("This medicine already exists in this prescription.");
            }
            else
            {
                int result = controllerObj.Insert_pre_med(Convert.ToInt32(textBox2.Text), Convert.ToInt32(comboBox5.SelectedValue.ToString()), Convert.ToInt32(textBox25.Text));
                if (result == 0)
                {
                    MessageBox.Show("The insertion  failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully!");
                }
            }
        }

        private void button76_Click(object sender, EventArgs e)//insert describe labtest          
        {
            if (comboBox22.Text == "")
            {
                MessageBox.Show("Please, select a patient.");
            }
            else if (comboBox6.Text == "")
            {
                MessageBox.Show("Choose a lab test.");
            }
            else
            {
                int dssn = controllerObj.get_ssn_of_username(user_name_textbox.Text);
                if (controllerObj.count_doctor_date(dssn, dateTimePicker1.Text) == 0)
                {
                    MessageBox.Show("Please, enter a valid date.");
                }
                else if (controllerObj.count_desc_labtest(dssn, dateTimePicker1.Text, Convert.ToInt32(comboBox22.SelectedValue.ToString()), Convert.ToInt32(comboBox6.SelectedValue.ToString())) == 1)
                {
                    MessageBox.Show("This Lab test already exists.");
                }
                else
                {
                    int result = controllerObj.Insert_desc_labtest(dssn, dateTimePicker1.Text, Convert.ToInt32(comboBox22.SelectedValue.ToString()), Convert.ToInt32(comboBox6.SelectedValue.ToString()));
                    if (result == 0)
                    {
                        MessageBox.Show("The insertion  failed");
                    }
                    else
                    {
                        MessageBox.Show("The row is inserted successfully!");
                    }
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)//doctor get patient presc
        {
            if (comboBox20.Text == "")
            {
                MessageBox.Show("Select a patient.");
            }
            else
            {
                DataTable dt = controllerObj.Select_Patient_presc_to_use(Convert.ToInt32(comboBox20.SelectedValue.ToString()));
                dataGridView13.DataSource = dt;
                dataGridView13.Refresh();
            }
        }

        private void button77_Click(object sender, EventArgs e)//doctor get patient tests
        {
            if (comboBox20.Text == "")
            {
                MessageBox.Show("Select a patient.");
            }
            else
            {
                DataTable dt = controllerObj.Select_Patient_tests_to_use(Convert.ToInt32(comboBox20.SelectedValue.ToString()));
                dataGridView13.DataSource = dt;
                dataGridView13.Refresh();
            }
        }

        private void button78_Click(object sender, EventArgs e)//doctor get patient record
        {
            if (comboBox20.Text == "")
            {
                MessageBox.Show("Select a patient.");
            }
            else
            {
                DataTable dt = controllerObj.Select_Patient_record(Convert.ToInt32(comboBox20.SelectedValue.ToString()));
                dataGridView13.DataSource = dt;
                dataGridView13.Refresh();
            }
        }

        private void patientsearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {
            //1)check empty
            if(textBox40_med_id.Text== "")
            {
                MessageBox.Show("Enter medicine id");
                return;
            }
            if (textBox38_med_name.Text == "")
            {
                MessageBox.Show("Enter medicine name");
                return;
            }
            if (textBox39_med_price.Text == "")
            {
                MessageBox.Show("Enter medicine price");
                return;
            }
            if (textBox37_med_quantity.Text == "")
            {
                MessageBox.Show("Enter medicine quantinty");
                return;
            }
            ////////////////
            //2)1-chseck int
            int v1;
            bool find;
            find = Int32.TryParse(textBox40_med_id.Text, out v1);
            if (!find || v1 <= 0 || v1 > 20000)//here there is !
            {
                MessageBox.Show("Enter a valid medicine id");
                return;
            }
            find = Int32.TryParse(textBox39_med_price.Text, out v1);
            if (!find|| v1 <= 0)//here there is !
            {
                MessageBox.Show("Enter a valid medicine price");
                return;
            }
            find = Int32.TryParse(textBox37_med_quantity.Text, out v1);
            if (!find || v1 <= 0)//here there is !
            {
                MessageBox.Show("Enter a valid medicine quantinty");
                return;
            }
            //2)2-check string
            find = Int32.TryParse(textBox38_med_name.Text, out v1);
            if (find)//here there is NO !
            {
                MessageBox.Show("Enter a valid medicine name");
                return;
            }
            ////////////////////////
            //3)Unique
            int med_n_Count = controllerObj.check_Medicine_Name_existance(textBox38_med_name.Text);
            if (med_n_Count == 1)
            {
                MessageBox.Show("This medicine name is already exist");
                return;
            }
            //////////////////////////
            ///4)PK
            int med_id_Count = controllerObj.check_Medicine_id_existance(textBox40_med_id.Text);
            if (med_id_Count == 1)
            {
                MessageBox.Show("This medicine id is already exist");
                return;
            }
            /////////////////////////
            //5)insert
            int result = controllerObj.Insert_Medicine(textBox40_med_id.Text, textBox38_med_name.Text, textBox39_med_price.Text, textBox37_med_quantity.Text);
            if (result == 0)
            {
                MessageBox.Show("The insertion failed");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");
            }

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void button86_Click(object sender, EventArgs e)
        {
            //1)check empty
            if (textBox43_med_pri.Text == "")
            {
                MessageBox.Show("Enter medicine price");
                return;
            }
            ////////////////
            ///2)check int
            int v1;
            bool find;
            find = Int32.TryParse(textBox43_med_pri.Text, out v1);
            if (!find || v1 <= 0 ||v1 > 20000)//here there is !
            {
                MessageBox.Show("Enter a valid medicine price");
                return;
            }
            ////////////////////////////
            //3)update
            int result = controllerObj.Update_med_price(textBox43_med_pri.Text, comboBox17_med_id.SelectedValue.ToString());////////////////////////////////
            if (result == 0)
            {
                MessageBox.Show("The update failed");
            }
            else
            {
                MessageBox.Show("The row is updated successfully!");
            }

        }

        private void button87_Click(object sender, EventArgs e)
        {
            //1)check empty
            if (textBox41_med_quant.Text == "")
            {
                MessageBox.Show("Enter medicine quantinty");
                return;
            }
            ////////////////
            ///2)check int
            int v1;
            bool find;
            find = Int32.TryParse(textBox41_med_quant.Text, out v1);
            if (!find || v1 < 0)//here there is !
            {
                MessageBox.Show("Enter a valid medicine quantinty");
                return;
            }
            //m.s:
            else if (v1 == 0)
            {
                MessageBox.Show("This Medicine is finished");
            }
            //end m.s
            ////////////////////////////
            //3)update
            int result = controllerObj.Update_med_quantity(textBox41_med_quant.Text, comboBox17_med_id.SelectedValue.ToString());
            if (result == 0)
            {
                MessageBox.Show("The update failed");
            }
            else
            {
                MessageBox.Show("The row is updated successfully!");
            }

        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox41_med_quant_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox43_med_pri_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button67_Click(object sender, EventArgs e)
        {
            Homepanel.Visible = true;
            pharmacistpan.Visible = false;
            doctorpanel.Visible = false;
            Adminstratorpan.Visible = false;
            Accountantpanel.Visible = false;
            nursepanel.Visible = false;
            labrotist.Visible = false;
            receptionistpanel.Visible = false;
            
        }

        private void button86_phar_get_info_Click(object sender, EventArgs e)
        {

            DataTable dt1 = controllerObj.Selectemployeeusername(user_name_textbox.Text);
            dataGridView15.DataSource = dt1;
            dataGridView15.Refresh();


            DataTable dt2 = controllerObj.Selectemployeedepartment(user_name_textbox.Text);
            dataGridView16.DataSource = dt2;
            dataGridView16.Refresh();


            DataTable dt3 = controllerObj.Selectemployeemobiles(user_name_textbox.Text);
            dataGridView17.DataSource = dt3;
            dataGridView17.Refresh();



        }

        private void butt55_Paint(object sender, PaintEventArgs e)
        {

        }

     private void button85_Click(object sender, EventArgs e)//insert doctor
        {
            if (comboBox21.Text==""||dateTimePicker13.Text=="" || textBox24.Text == "" || textBox26.Text == "" || textBox28.Text == "")
            {
                MessageBox.Show("Please, Enter the required information.");
            }
            else if(dateTimePicker13.Value < dateTimePicker15.Value)//>= done
            {
                MessageBox.Show("Please, Enter a valid date.");
            }
            else if (Convert.ToInt32(textBox24.Text) < 0 || Convert.ToInt32(textBox24.Text) > 23 || Convert.ToInt32(textBox26.Text) < 0 || Convert.ToInt32(textBox26.Text) > 23 )
            {
                MessageBox.Show("Please, Enter a valid hour.");
            }
            else if (Convert.ToInt32(textBox26.Text) <= Convert.ToInt32(textBox24.Text))//invalid if end<=start
            {
                MessageBox.Show("Please, Enter a valid period (start hour should be less than end hour).");
            }
            else if (Convert.ToInt32(textBox28.Text) < 0 || Convert.ToInt32(textBox28.Text) > 30)
            {
                MessageBox.Show("Please, Enter a valid number of patients, maximum 30.");
            }
            else if (controllerObj.count_doctor_date(Convert.ToInt32(comboBox21.SelectedValue.ToString()), dateTimePicker13.Text) == 1)//already exists
            {
                MessageBox.Show("This appointments already exists.");
            }
            else
            {
                textBox33.Text = dateTimePicker13.Value.DayOfWeek.ToString();
                int val = 0;
                textBox34.Text = val.ToString();
                int result = controllerObj.insert_doc(Convert.ToInt32(comboBox21.SelectedValue.ToString()), textBox33.Text, dateTimePicker13.Text, Convert.ToInt32(textBox24.Text), Convert.ToInt32(textBox26.Text), Convert.ToInt32(textBox28.Text), Convert.ToInt32(textBox34.Text));
                if (result == 0)
                {
                    MessageBox.Show("The insertion  failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully!");
                }
            }
        }

     private void examinpatien_Paint(object sender, PaintEventArgs e)
     {

     }

     private void button81_Click(object sender, EventArgs e)//update start hour
     {
         float v1;
         if (comboBox21.Text == "" || dateTimePicker13.Text == "" || textBox24.Text == "" )
         {
             MessageBox.Show("Please, Enter the required information.");
         }
         else if (dateTimePicker13.Value < dateTimePicker15.Value) 
         {
             MessageBox.Show("Please, Enter a valid date.");
         }
         else if (float.TryParse(textBox24.Text, out v1))
         {
             MessageBox.Show("Please, Enter a valid hour.");
         }
         else if (v1 < 0 || v1 > 23)
         {
             MessageBox.Show("Please, Enter a valid hour.");
         }
         else if (controllerObj.count_doctor_date(Convert.ToInt32(comboBox21.SelectedValue.ToString()), dateTimePicker13.Text) == 0)//not exists
         {
             MessageBox.Show("This appointments not exists to be updated.");
         }
         else
         {
             float endhour = controllerObj.get_endhour(Convert.ToInt32(comboBox21.SelectedValue.ToString()), dateTimePicker13.Text);
             if (endhour <= v1)//invalid if end<=start
             {
                 MessageBox.Show("Please, Enter a valid period (start hour should be less than end hour).");
             }

             else
             {
                 int result = controllerObj.Update_doc_starthour(Convert.ToInt32(comboBox21.SelectedValue.ToString()), dateTimePicker13.Text, v1);
                 if (result == 0)
                 {
                     MessageBox.Show("update failed");
                 }
                 else
                 {
                     MessageBox.Show("The appointment is updated successfully!");
                 }
             }
         }   
     }

     private void button82_Click(object sender, EventArgs e)//update end hour
     {
         float v2;
         if (comboBox21.Text == "" || dateTimePicker13.Text == "" || textBox26.Text == "")
         {
             MessageBox.Show("Please, Enter the required information.");
         }
         else if (dateTimePicker13.Value < dateTimePicker15.Value)
         {
             MessageBox.Show("Please, Enter a valid date.");
         }
         else if (float.TryParse(textBox26.Text, out v2))
         {
             MessageBox.Show("Please, Enter a valid hour.");
         }
         else if (v2 < 0 || v2 > 23)
         {
             MessageBox.Show("Please, Enter a valid hour.");
         }
         else if (controllerObj.count_doctor_date(Convert.ToInt32(comboBox21.SelectedValue.ToString()), dateTimePicker13.Text) == 0)//not exists
         {
             MessageBox.Show("This appointments not exists to be updated.");
         }
         else
         {
             float starthour = controllerObj.get_starthour(Convert.ToInt32(comboBox21.SelectedValue.ToString()), dateTimePicker13.Text);
             if (v2 <= starthour)//invalid if end<=start
             {
                 MessageBox.Show("Please, Enter a valid period (start hour should be less than end hour).");
             }

             else
             {
                 int result = controllerObj.Update_doc_end(Convert.ToInt32(comboBox21.SelectedValue.ToString()), dateTimePicker13.Text, v2);
                 if (result == 0)
                 {
                     MessageBox.Show("update failed");
                 }
                 else
                 {
                     MessageBox.Show("The appointment is updated successfully!");
                 }
             }
         }   
     }

     private void button83_Click(object sender, EventArgs e)//update max fixed number
     {
         if (comboBox21.Text == "" || dateTimePicker13.Text == "" || textBox28.Text == "")
         {
             MessageBox.Show("Please, Enter the required information.");
         }
         else if (dateTimePicker13.Value < dateTimePicker15.Value)
         {
             MessageBox.Show("Please, Enter a valid date.");
         }
         else if (Convert.ToInt32(textBox28.Text) < 0 || Convert.ToInt32(textBox28.Text) > 30)
         {
             MessageBox.Show("Please, Enter a valid number of patients, maximum 30.");
         }
         else if (controllerObj.count_doctor_date(Convert.ToInt32(comboBox21.SelectedValue.ToString()), dateTimePicker13.Text) == 0)//not exists
         {
             MessageBox.Show("This appointments not exists to be updated.");
         }
         else
         {
             int result = controllerObj.Update_doc_fixed(Convert.ToInt32(comboBox21.SelectedValue.ToString()), dateTimePicker13.Text, Convert.ToInt32(textBox28.Text));
             if (result == 0)
             {
                 MessageBox.Show("update failed");
             }
             else
             {
                 MessageBox.Show("The appointment is updated successfully!");
             }
         }
     }

     private void button79_Click(object sender, EventArgs e)//delete examine
     {
         if (comboBox2.Text == "" || comboBox19.Text == "" || dateTimePicker4.Text == "")
         {
             MessageBox.Show("Please, fill the required information.");
         }
         else
         {
             if (dateTimePicker4.Value < dateTimePicker14.Value)
             {
                 MessageBox.Show("Please, Enter a valid date.");
             }
             if (controllerObj.count_doctor_date(Convert.ToInt32(comboBox2.SelectedValue.ToString()), dateTimePicker4.Text) == 0)
             {
                 MessageBox.Show("This date is not available.");
             }
             else if (controllerObj.count_examine(Convert.ToInt32(comboBox2.SelectedValue.ToString()), dateTimePicker4.Text, Convert.ToInt32(comboBox19.SelectedValue.ToString())) == 0)
             {
                 MessageBox.Show("This appointment not exists to be deleted.");
             }
             else
             {
                 int result = controllerObj.delete_examine(Convert.ToInt32(comboBox2.SelectedValue.ToString()), dateTimePicker4.Text, Convert.ToInt32(comboBox19.SelectedValue.ToString()));
                 if (result == 0)
                 {
                     MessageBox.Show("The deletion  failed");
                 }
                 else
                 {
                     MessageBox.Show("The appointment is deleted successfully!");
                     controllerObj.Update_var_patient_number_dec(Convert.ToInt32(comboBox2.SelectedValue.ToString()), dateTimePicker4.Text);
                 }
             }
         }
     }

     private void button80_Click(object sender, EventArgs e)//update age
     {
     //    if (textBox10.Text == "" || textBox14.Text == "")
     //    {
     //        MessageBox.Show("Please, fill the required information.");
     //    }
     //    else
     //    {
     //        int result1 = controllerObj.update_page(Convert.ToInt32(textBox10.Text), Convert.ToInt16(textBox14.Text));
     //        if (result1 == 0)
     //        {
     //            MessageBox.Show("update failed");
     //        }
     //        else
     //        {
     //            MessageBox.Show("Information is updated successfully!");
     //        }
     //    }
     }

     private void button84_Click(object sender, EventArgs e)//update address
     {
     //    if (textBox10.Text == "" || textBox16.Text == "")
     //    {
     //        MessageBox.Show("Please, fill the required information.");
     //    }
     //    else
     //    {
     //        int result1 = controllerObj.update_paddress(Convert.ToInt32(textBox10.Text), textBox16.Text);
     //        if (result1 == 0)
     //        {
     //            MessageBox.Show("update failed");
     //        }
     //        else
     //        {
     //            MessageBox.Show("Information is updated successfully!");
     //        }
     //    }
     }

     private void button88_Click(object sender, EventArgs e)//get patients appointments
     {
         DataTable dt = controllerObj.Select_patients_schedule(Convert.ToInt32(comboBox10.SelectedValue.ToString()), dateTimePicker17.Text);
         dataGridView1.DataSource = dt;
         dataGridView1.Refresh();
     }

        private void button89_Click(object sender, EventArgs e)
        {
            Updatedepartpan.Visible = false;
            Updateemployeepan.Visible = false;
            insertdepartmentpanl.Visible = false;
            insertemployee.Visible = false;
            adminstratorpersinfpanl.Visible = false;
            Showemployee.Visible = true;
            Showsatistics.Visible = false;
        }

        private void button90_Click(object sender, EventArgs e)
        {
            Updatedepartpan.Visible = false;
            Updateemployeepan.Visible = false;
            insertdepartmentpanl.Visible = false;
            insertemployee.Visible = false;
            adminstratorpersinfpanl.Visible = false;
            Showemployee.Visible = false;
            Showsatistics.Visible = true;
        }

        private void button96_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
        }

        private void button95_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Show();
        }

        private void button92_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void button91_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.showemployeewithssn(Convert.ToInt32(comboBox13.SelectedValue.ToString()));
            dataGridView30.DataSource = dt;
            dataGridView30.Refresh();

        }

        private void button93_Click(object sender, EventArgs e)
        {

            Form6 f = new Form6();
            f.Show();

        }

        private void button35_Click_1(object sender, EventArgs e)//delete doc appointment
        {
            if (comboBox21.Text == "" || dateTimePicker13.Text == "")
            {
                MessageBox.Show("Please, Enter the required information.");
            }
            else if (dateTimePicker13.Value < dateTimePicker15.Value)
            {
                MessageBox.Show("Please, Enter a valid date.");
            }
            else if (controllerObj.count_doctor_date(Convert.ToInt32(comboBox21.SelectedValue.ToString()), dateTimePicker13.Text) == 0)//not exists
            {
                MessageBox.Show("This appointments not exists to be deleted.");
            }
            else
            {
                int result = controllerObj.delete_doc_appointment(Convert.ToInt32(comboBox21.SelectedValue.ToString()), dateTimePicker13.Text);
                if (result == 0)
                {
                    MessageBox.Show("deletion failed");
                }
                else
                {
                    MessageBox.Show("The appointment is deleted successfully!");
                }
            }
        }

        private void button94_Click(object sender, EventArgs e)//update emp mobile
        {
            if (textBox35.Text == "" || textBox36.Text == "")
            {
                MessageBox.Show("Please, Enter old and new mobile phones.");
            }
            else
            {
                if (textBox35.Text != "" &&
                ((textBox35.Text.Length != 11 || textBox35.Text[0] != '0' || textBox35.Text[1] != '1')
                || (textBox35.Text[2] == '3' || textBox35.Text[2] == '4' || textBox35.Text[2] == '5' || textBox35.Text[2] == '6' || textBox35.Text[2] == '7' || textBox35.Text[2] == '8' || textBox35.Text[2] == '9')))
                {
                    MessageBox.Show("Please, Enter a valid mobile phones in old mobile.");
                }
                else if (textBox36.Text != "" &&
                ((textBox36.Text.Length != 11 || textBox36.Text[0] != '0' || textBox36.Text[1] != '1')
                || (textBox36.Text[2] == '3' || textBox36.Text[2] == '4' || textBox36.Text[2] == '5' || textBox36.Text[2] == '6' || textBox36.Text[2] == '7' || textBox36.Text[2] == '8' || textBox36.Text[2] == '9')))
                {
                    MessageBox.Show("Please, Enter a valid mobile phones in new mobile.");
                }
                else
                {
                    if (controllerObj.check_mob(Convert.ToInt32(comboBox4.SelectedValue.ToString()), textBox35.Text) == 0)//not found
                    {
                        MessageBox.Show("This mobile not exists to be updated.");
                    }
                    else
                    {
                        if (controllerObj.check_mobE(textBox36.Text) == 1)
                        {
                            MessageBox.Show("This mobile already exists.");
                        }
                        else
                        {
                            int result = controllerObj.updateEmployeemobile(Convert.ToInt32(comboBox4.SelectedValue.ToString()), textBox36.Text, textBox35.Text);
                            if (result == 0)
                            {
                                MessageBox.Show("update failed");
                            }
                            else
                            {
                                MessageBox.Show("The mobile is updated successfully!");
                            }
                        }
                    }
                }
            }
        }

        private void button97_Click(object sender, EventArgs e)//update patient mobile
        {
            // if (textBox37.Text == "" || textBox38.Text == "")
            //{
            //    MessageBox.Show("Please, Enter old and new mobile phones.");
            //}
            //else
            //{
            //    if (textBox37.Text != "" &&
            //    ((textBox37.Text.Length != 11 || textBox37.Text[0] != '0' || textBox37.Text[1] != '1')
            //    || (textBox37.Text[2] == '3' || textBox37.Text[2] == '4' || textBox37.Text[2] == '5' || textBox37.Text[2] == '6' || textBox37.Text[2] == '7' || textBox37.Text[2] == '8' || textBox37.Text[2] == '9')))
            //    {
            //        MessageBox.Show("Please, Enter a valid mobile phones in old mobile.");
            //    }
            //    else if (textBox38.Text != "" &&
            //    ((textBox38.Text.Length != 11 || textBox38.Text[0] != '0' || textBox38.Text[1] != '1')
            //    || (textBox38.Text[2] == '3' || textBox38.Text[2] == '4' || textBox38.Text[2] == '5' || textBox38.Text[2] == '6' || textBox38.Text[2] == '7' || textBox38.Text[2] == '8' || textBox38.Text[2] == '9')))
            //    {
            //        MessageBox.Show("Please, Enter a valid mobile phones in new mobile.");
            //    }
            //    else
            //    {
            //        if(controllerObj.check_mob(Convert.ToInt32(comboBox4.SelectedValue.ToString()),textBox37.Text)==0)//not found
            //        {
            //            MessageBox.Show("This mobile not exists to be updated.");
            //        }
            //        else
            //        {
            //            int result = controllerObj.updateEmployeemobile(Convert.ToInt32(comboBox4.SelectedValue.ToString()),textBox38.Text,textBox37.Text );
            //           if (result == 0)
            //           {
            //              MessageBox.Show("update failed");
            //           }
            //            else
            //          {
            //               MessageBox.Show("The mobile is updated successfully!");
            //          }
            //        }
            //    }
        }



        // private void button79_Click(object sender, EventArgs e)//delete doc appointment
        // {
        //    
        //}
    

        private void button80_Click_1(object sender, EventArgs e)//update age patient
        {
        if (comboBox10.Text == "" || textBox40.Text == "")
         {
             MessageBox.Show("Please, fill the required information.");
         }
         else
         {
             int result1 = controllerObj.update_page(Convert.ToInt32(comboBox10.SelectedValue.ToString()), Convert.ToInt16(textBox40.Text));
             if (result1 == 0)
             {
                 MessageBox.Show("update failed");
             }
             else
             {
                 MessageBox.Show("Information is updated successfully!");
             }
         }
     }

        private void button84_Click_1(object sender, EventArgs e)//update address patient
        {
        if (comboBox10.Text == "" || textBox39.Text == "")
         {
             MessageBox.Show("Please, fill the required information.");
         }
         else
         {
             int result1 = controllerObj.update_paddress(Convert.ToInt32(comboBox10.SelectedValue.ToString()), textBox39.Text);
             if (result1 == 0)
             {
                 MessageBox.Show("update failed");
             }
             else
             {
                 MessageBox.Show("Information is updated successfully!");
             }
         }
        }

        private void button97_Click_1(object sender, EventArgs e)//update mobile patient
        {
            if (comboBox10.Text == "" || textBox37.Text == "" || textBox38.Text == "")
            {
                MessageBox.Show("Please, Enter old and new mobile phones.");
            }
            else
            {
                if (textBox37.Text != "" &&
                ((textBox37.Text.Length != 11 || textBox37.Text[0] != '0' || textBox37.Text[1] != '1')
                || (textBox37.Text[2] == '3' || textBox37.Text[2] == '4' || textBox37.Text[2] == '5' || textBox37.Text[2] == '6' || textBox37.Text[2] == '7' || textBox37.Text[2] == '8' || textBox37.Text[2] == '9')))
                {
                    MessageBox.Show("Please, Enter a valid mobile phones in old mobile.");
                }
                else if (textBox38.Text != "" &&
                ((textBox38.Text.Length != 11 || textBox38.Text[0] != '0' || textBox38.Text[1] != '1')
                || (textBox38.Text[2] == '3' || textBox38.Text[2] == '4' || textBox38.Text[2] == '5' || textBox38.Text[2] == '6' || textBox38.Text[2] == '7' || textBox38.Text[2] == '8' || textBox38.Text[2] == '9')))
                {
                    MessageBox.Show("Please, Enter a valid mobile phones in new mobile.");
                }
                else
                {
                    if (controllerObj.check_mob_patient(Convert.ToInt32(comboBox10.SelectedValue.ToString()), textBox37.Text) == 0)//not found
                    {
                        MessageBox.Show("This mobile not exists to be updated.");
                    }
                    else if(controllerObj.check_mobP(textBox38.Text)==1)
                    {
                        MessageBox.Show("This mobile already exists.");
                    }
                    else
                    {
                        int result = controllerObj.updatepatientmobile(Convert.ToInt32(comboBox10.SelectedValue.ToString()), textBox38.Text, textBox37.Text);
                        if (result == 0)
                        {
                            MessageBox.Show("update failed");
                        }
                        else
                        {
                            MessageBox.Show("The mobile is updated successfully!");
                        }
                    }
                }
            }
        }

        private void button98_Click(object sender, EventArgs e)
        {
            int result;
            if (comboBox27.Text == "")
                MessageBox.Show("please enter all values");
            else
            {
                result = controllerObj.updatelab_av(Convert.ToInt32(comboBox8.SelectedValue.ToString()),comboBox27.Text);
                if (result == 0)
                {
                    MessageBox.Show("The edition  failed");
                }
                else
                {
                    MessageBox.Show("The row is edited successfully!");
                }

            }

        }

        private void button99_Click(object sender, EventArgs e)
        {
            if(comboBox15.Text == "")
            {
                MessageBox.Show("Select a patient.");
            }
            else
            {
                DataTable dt = controllerObj.Select_Patient_tests_to_use(Convert.ToInt32(comboBox15.SelectedValue.ToString()));
                dataGridView31.DataSource = dt;
                dataGridView31.Refresh();
            }
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button100_Click(object sender, EventArgs e)
        {
                if (comboBox17_patient_ssn_N.Text == "")
                {
                    MessageBox.Show("Select a patient.");
                }
                else
                {
                    DataTable dt = controllerObj.Select_Patient_presc_to_use_pharmacist(Convert.ToInt32(comboBox17_patient_ssn_N.SelectedValue.ToString()));
                    dataGridView32.DataSource = dt;
                    dataGridView32.Refresh();
                }
            
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }
    }
}