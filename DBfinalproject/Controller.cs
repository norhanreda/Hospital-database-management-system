using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBfinalproject
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        ////////////////////Norhan reda/////////////////////

        //////////accountant pannel //////////////////
        ////////// updata employee salary///////////////
        public DataTable Selectemployeewithssn(int ssn)
        {
            string query = "SELECT * FROM Employee  where SSN='" + ssn + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Selectemployeeusername(string n)
        {
            string query = "SELECT SSN,Fname,Minit,Lname,Email,Employee_Address,Gender,salary,Employee_Type,Birth_Date,Department_NUM,Hire_Date FROM Employee as e,User_Account as u  where u.UserName='" + n + "' and e.SSN=u.User_SSN;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllSSNemployee()
        {
            string query = "SELECT SSN FROM Employee;";
            return dbMan.ExecuteReader(query);
        }
        public int UpdateSalary(int ssn,int Salary)
        {
            string query = "update Employee set salary='" + Salary + "'  where SSN='" + ssn + "';";
                            
            return dbMan.ExecuteNonQuery(query);
        }

        ////////////////GET patient money//////////
        public DataTable Selectexamineprice(int pssn,string pdate)
        {
            string query = "SELECT  Examine_Price  FROM Patient as p,Examine as e  where p.Patient_SSN='" + pssn + "' and p.Patient_SSN=e.Patient_SSN and e.Examine_Date='" + pdate + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Selectlabtestprice(int pssn, string pdate)
        {
            string query = "SELECT  l.Test_Name,l.Test_Price  FROM Patient as p,Have as h,Lab_test as l  where p.Patient_SSN='" + pssn + "' and p.Patient_SSN=h.Patient_SSN and h.Test_Id=l.Test_Id and h.Test_Date='" + pdate + "'    ;";
            return dbMan.ExecuteReader(query);
        }


        public DataTable Selectmedicineprice(int pssn, string pdate)//updated
        {
            string query = "SELECT m.Medicine_Name,m.Medicine_Price   FROM   Patient as p,Medicine as m,assign_medicine as w where p.Patient_SSN='" + pssn + "' and  w.medicine_id = m.Medicine_Id and p.Patient_SSN=w.patint_ssn and w.Assignment_Date='" + pdate + "'    ;";
            return dbMan.ExecuteReader(query);
        }

        public int Insertlabtest(int Test_Id, string Test_Name, int Test_Price,string isav)
        {
            string query = "INSERT INTO Lab_test(Test_Id, Test_Name, Test_Price,Is_Available)" +
                            "Values ('" + Test_Id + "','" + Test_Name + "','" + Test_Price +"','" + isav + "');";
            return dbMan.ExecuteNonQuery(query);
        }



       /////added new////////

        public DataTable Selectemployeemobiles(string n)
        {
            string query = "SELECT  Emobile_Mobile FROM Employee as e,User_Account as u,E_Mobile as m  where u.UserName='" + n + "' and e.SSN=u.User_SSN and e.SSN=m.Employee_SSN ;";
            return dbMan.ExecuteReader(query);
        }



        public DataTable Selectemployeedepartment(string n)
        {
            string query = "SELECT Department_Name  FROM Employee ,Department,User_Account  where UserName='" + n + "' and  SSN=User_SSN and Department_Number=Department_NUM ;";
            return dbMan.ExecuteReader(query);
        }





        ////////////////////////////



        ////////////////////end update employee salary//////////
        /* public DataTable Selectmoney()
         {
             string query = "SELECT  FROM Patient,Have,Lab_test ;";
             return dbMan.ExecuteReader(query);
         }*/

        /////////////////admistrartor insert and update department/////////
        public int Insertdepartment(int Dnumber,string  Dname, int Mgr_ssn,string date)
        {
            string query = "INSERT INTO Department (Department_Number, Department_Name,Manager_SSN,Manager_Start_Date)" +
                            "Values ('" + Dnumber + "','" + Dname + "','" + Mgr_ssn + "','" +date +"');";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable Selectemployeenames()
        {
            string query = "SELECT Fname,Minit,Lname,SSN FROM Employee ;";  
            return dbMan.ExecuteReader(query);
        }
        public DataTable Selectdepartmentnames()
        {
            string query = "SELECT Department_Name,Department_Number FROM Department ;";  
            return dbMan.ExecuteReader(query);
        }
        public int deleteDepartment(int dnum)
        {
            string query = "DELETE FROM Department where Department_Number='" + dnum + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int updateDepartment(int dnum,int ssn,string date )
        {
            string query = "UPDATE Department set Manager_SSN='" + ssn + "' ,Manager_Start_Date='" + date + "' where Department_Number='" + dnum + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        ////samaa to norhan:do we need the following func?:-
        public DataTable SelectemployeeType()
        {
            string query = "SELECT type FROM Employee ;"; 
            return dbMan.ExecuteReader(query);
        }
        ////////
        public int InsertEmployee(int SSN, string Fname, string Minit, string Lname, string Email, string Address, string Gender, int salary, string type, string Bdate, int Dno, string hire_Date)
        {
            string query = "INSERT INTO Employee (SSN,Fname,Minit,Lname	,Email,	Employee_Address,Gender,salary,Employee_Type,Birth_Date,Department_NUM,Hire_Date )" +
                            "Values ('" + SSN + "','" + Fname + "','" + Minit + "','" + Lname + "','" + Email + "','" + Address + "','" + Gender + "','" + salary + "','" + type + "','" + Bdate + "','" + Dno + "','" +hire_Date+ "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int deleteEmployee(int ssn)
        {
            string query = "DELETE FROM Employee where SSN='" + ssn + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int updateEmployeeSalary(int ssn,int salary )
        {
            string query = "UPDATE Employee set salary='" + salary + "' where SSN='" + ssn + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int updateEmployeeAddress(int ssn, string address)
        {
            string query = "UPDATE Employee set Employee_Address='" + address +  "' where SSN='" + ssn + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int updateEmployeeDno(int ssn, int dno)
        {
            string query = "UPDATE Employee set  Department_NUM='" + dno + "' where SSN='" + ssn + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        ////////////////end admistrartor insert and update department////////

        //////////nurse///////////////

        public int Insertmedicalreport(int Report_Id,int Patient_SSN,string Report_Date,int Patient_SBP,int Patient_DBP,int Patient_Diapetes,int Patient_Height,int Patient_Weight )
        {
            string query = "INSERT INTO medical_report (Report_Id,Patient_SSN,Report_Date,Patient_SBP,Patient_DBP,Patient_Diapetes,Patient_Height,Patient_Weight)" +
                            "Values ('" + Report_Id + "','" + Patient_SSN + "','" + Report_Date + "','" + Patient_SBP + "','" + Patient_DBP + "','" + Patient_Diapetes + "','" + Patient_Height + "','" + Patient_Weight + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable Selecttestname()
        {
            string query = "SELECT Test_Name,Test_Id FROM Lab_test;";
            return dbMan.ExecuteReader(query);
        }


        public int deletelabtest(int Test_Id)
        {
            string query = "DELETE FROM Lab_test where Test_Id='" + Test_Id + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int updatelabprice(int Test_Id, int Test_Price)
        {
            string query = "UPDATE Lab_test set Test_Price='" + Test_Price + "'  where Test_Id='" + Test_Id + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int updatelab_av(int Test_Id, string av)
        {
            string query = "UPDATE Lab_test set Is_Available='" + av + "'  where Test_Id='" + Test_Id + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Insertintohave(int Patient_SSN, int Test_Id, string Test_Date)
        {
            string query = "INSERT INTO Have(Patient_SSN, Test_Id, Test_Date)" +
                            "Values ('" + Patient_SSN+ "','" + Test_Id+ "','" + Test_Date + "');";
            return dbMan.ExecuteNonQuery(query);
        }


        public int check_medicalreprtid(int Report_Id)//we assume that user names are unique
        {
            string query = "select COUNT(*) from medical_report where Report_Id ='" + Report_Id + "';";
            return (int)dbMan.ExecuteScalar(query);

        }


        public int check_ssn(int SSN)//we assume that user names are unique
        {
            string query = "select COUNT(*) from Employee where SSN ='" + SSN + "';";
            return (int)dbMan.ExecuteScalar(query);

        }
        public int check_ssn_patient(int SSN)//we assume that user names are unique
        {
            string query = "select COUNT(*) from Patient where Patient_SSN ='" + SSN + "';";
            return (int)dbMan.ExecuteScalar(query);

        }


        public int check_Email(string Email)//we assume that user names are unique
        {
            string query = "select COUNT(*) from Employee where Email ='" + Email + "';";
            return (int)dbMan.ExecuteScalar(query);

        }

        public int check_departmentNum(int Department_Number)//we assume that user names are unique
        {
            string query = "select COUNT(*) from Department where Department_Number ='" + Department_Number + "';";
            return (int)dbMan.ExecuteScalar(query);

        }

        public int check_departmentName(string Department_Name)//we assume that user names are unique
        {
            string query = "select COUNT(*) from Department where Department_Name ='" + Department_Name + "';";
            return (int)dbMan.ExecuteScalar(query);

        }

        public int check_manegerssn(int Manager_SSN)//we assume that user names are unique
        {
            string query = "select COUNT(*) from Department where Manager_SSN ='" + Manager_SSN + "';";
            return (int)dbMan.ExecuteScalar(query);

        }

        public int check_patientssn(int Patient_SSN)//we assume that user names are unique
        {
            string query = "select COUNT(*) from Patient where Patient_SSN ='" + Patient_SSN + "';";
            return (int)dbMan.ExecuteScalar(query);

        }


        public int check_labid(int Test_Id)//we assume that user names are unique
        {
            string query = "select COUNT(*) from Lab_test where Test_Id ='" + Test_Id + "';";
            return (int)dbMan.ExecuteScalar(query);

        }

        public int check_labname(string Test_Name)//we assume that user names are unique
        {
            string query = "select COUNT(*) from Lab_test where Test_Name ='" + Test_Name + "';";
            return (int)dbMan.ExecuteScalar(query);

        }

        


        public int Insert_Employee_Mobile(int SSN, string mobile)
        {
            string query = "INSERT INTO E_Mobile (Employee_SSN,Emobile_Mobile)" +
                            "Values ('" + SSN + "','" + mobile + "');";

            return dbMan.ExecuteNonQuery(query);
        }



        public DataTable showemployeewithssn(int ssn)
        {
            string query = "SELECT  SSN,Fname,Minit,Lname,Email,Employee_Address,Gender,salary,Employee_Type,Birth_Date,Department_NUM,Hire_Date,Department_Name FROM Employee,Department  where SSN='" + ssn + "' and Department_Number=Department_NUM;";
            return dbMan.ExecuteReader(query);
        }



        public int updateEmployeeUsername(string oUserName, string User_Password, string nUserName)
        {
            string query = "UPDATE User_Account set UserName='" + nUserName + "' where UserName='" + oUserName + "' and User_Password='" + User_Password + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int check_username(string UserName)
        {
            string query = "select COUNT(*) from User_Account where UserName='" + UserName + "'  ;";
            return (int)dbMan.ExecuteScalar(query);

        }

        public int check_userpass(string User_Password, string UserName)
        {
            string query = "select COUNT(*) from User_Account where  User_Password='" + User_Password + "' and UserName='" + UserName + "'  ;";
            return (int)dbMan.ExecuteScalar(query);

        }

        //_______________________________________________________________________________________mobile

        public int updateEmployeemobile(int ssn, string mobile,string oldmobile)
        {
            string query = "UPDATE E_Mobile set Emobile_Mobile='" + mobile + "' where Employee_SSN='" + ssn + "' and Emobile_Mobile='"+ oldmobile+"';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int check_mob(int ssn, string mobile)
        {
            string query = "select COUNT(*) from E_Mobile where Emobile_Mobile='" + mobile + "' and Employee_SSN='" + ssn + "'  ;";
            return (int)dbMan.ExecuteScalar(query);

        }
        public int updatepatientmobile(int ssn, string mobile, string oldmobile)
        {
            string query = "UPDATE P_Mobile set Patient_Mobile='" + mobile + "' where Patient_SSN='" + ssn + "' and Patient_Mobile='" + oldmobile + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int check_mob_patient(int ssn, string mobile)
        {
            string query = "select COUNT(*) from P_Mobile where Patient_Mobile='" + mobile + "' and Patient_SSN='" + ssn + "'  ;";
            return (int)dbMan.ExecuteScalar(query);

        }
        public int check_mobE(string Emobile_Mobile)
        {
            string query = "select COUNT(*) from E_Mobile  where Emobile_Mobile='" + Emobile_Mobile + "' ;";
            return (int)dbMan.ExecuteScalar(query);

        }

        public int check_mobP(string Patient_Mobile)
        {
            string query = "select COUNT(*) from P_Mobile  where Patient_Mobile='" + Patient_Mobile + "' ;";
            return (int)dbMan.ExecuteScalar(query);

        }
        ////////////end norhan reda/////////////////


        /////////////////samaa hazem//////////////////

        //////user_form1/////
        public DataTable user_sign_in(string user_name)
        {
            string query = "select User_Password,Employee_Type from User_Account,Employee where UserName ='" + user_name+ "' AND SSN=User_SSN;";
            return dbMan.ExecuteReader(query);

        }
        public int Insert_new_UA(string USSN, string uname, string password)
        {
            string query = "INSERT INTO User_Account " +
                            "Values ('" + USSN + "','" + uname + "','" + password + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int check_UA_existance(string uname)//we assume that user names are unique
        {
            string query = "select COUNT(*) from User_Account where UserName ='" + uname + "';";
            return (int)dbMan.ExecuteScalar(query);

        }
        public int Update_UA_password(/*string USSN,*/ string uname, string new_password)
        {
            string query = "UPDATE User_Account " +
                            "SET User_Password='" + new_password + "' where UserName='" + uname + "';";//??do i need the ussn?
            return dbMan.ExecuteNonQuery(query);
        }
        //public DataTable sele
        public DataTable select_sign_up_ssn()
        {
            string query = "SELECT SSN FROM Employee" +
                            " EXCEPT" +
                            " SELECT User_SSN FROM User_Account ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Select_Emp_names_sign_up()
        {
            string query = "SELECT Fname,Minit,Lname,SSN FROM Employee where SSN IN (SELECT SSN FROM Employee EXCEPT  SELECT User_SSN FROM User_Account );";
            return dbMan.ExecuteReader(query);
        }
        public string get_isav(int num)
        {
            string query = "SELECT Is_Available FROM Lab_test where Test_Id='" + num + "';";
            return (string)dbMan.ExecuteScalar(query);
        }

        //_____________________________________________ HODA _________________________________________________
        public int Insert_Patient(int SSN, string Fname, string Minit, string Lname, int Age, string Address, string Gender)
        {
            string query = "INSERT INTO Patient (Patient_SSN,Patient_Fname,Patient_Minit,Patient_Lname,Patient_Address,Patient_Gender,Patient_Age )" +
                            "Values ('" + SSN + "','" + Fname + "','" + Minit + "','" + Lname + "','" + Address + "','" + Gender + "','" + Age + "');";

            return dbMan.ExecuteNonQuery(query);
        } 
        public int Insert_Patient_Mobile(int SSN, string mobile)
        {
            string query = "INSERT INTO P_Mobile (Patient_SSN,Patient_Mobile )" +
                            "Values ('" + SSN + "','" + mobile + "');";

            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable Select_patient_withssn(int ssn)//not used
        {
            string query = "SELECT Patient.Patient_SSN,Patient_Fname,Patient_Minit,Patient_Lname,Patient_Address,Patient_Gender,Patient_Age,Patient_Mobile FROM Patient,P_Mobile where Patient.Patient_SSN=P_Mobile.Patient_SSN and Patient.Patient_SSN='" + ssn + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Select_patient_withssn2(int ssn)
        {
            string query = "SELECT Patient.Patient_SSN,Patient_Fname,Patient_Minit,Patient_Lname,Patient_Address,Patient_Gender,Patient_Age FROM Patient where Patient.Patient_SSN='" + ssn + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Select_patient_mobile(int ssn)
        {
            string query = "SELECT Patient_Mobile FROM P_Mobile,Patient where Patient.Patient_SSN=P_Mobile.Patient_SSN and Patient.Patient_SSN='" + ssn + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Select_patients_names()
        {
            string query = "SELECT Patient_Fname,Patient_Minit,Patient_Lname,Patient_SSN FROM Patient ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Select_Doctors_inDepartment(int num)//not used
        {
            string query = "SELECT Doctor.Doctor_SSN, Var_Patient_Num, Fixed_Patient_Num, Doctor_Day, Doctor_Date, Start_Hour, End_Hour from Employee, Doctor where Doctor.Doctor_SSN= Employee.SSN and Employee.Department_NUM='" + num + "';";
            return dbMan.ExecuteReader(query);
        }
        //public DataTable Select_Doctors_available_inDepartment(int num)
        //{
        //    string query = "SELECT Doctor.Doctor_SSN,Fname,Minit,Lname,Doctor_Day, Doctor_Date, Start_Hour, End_Hour,Fixed_Patient_Num,Var_Patient_Num from Employee, Doctor where Doctor.Doctor_SSN= Employee.SSN and Var_Patient_Num < Fixed_Patient_Num  and Employee.Department_NUM='" + num + "';";
        //    return dbMan.ExecuteReader(query);
        //}    
        public DataTable Select_Doctors_available_inDepartment(int num,string date)
        {
            string query = "SELECT Doctor.Doctor_SSN,Fname,Minit,Lname,Doctor_Day, Doctor_Date, Start_Hour, End_Hour,Fixed_Patient_Num,Var_Patient_Num from Employee, Doctor where Doctor.Doctor_SSN= Employee.SSN and Var_Patient_Num < Fixed_Patient_Num  and Employee.Department_NUM='" + num + "' and Doctor_Date >= '" + date + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Select_departments_numbers()
        {
            string query = "SELECT Department_Number FROM Department ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Select_availabledoctors(int num)
        {
            string query = "SELECT Doctor_SSN,Fname,Minit,Lname FROM Doctor,Employee where Doctor.Doctor_SSN= Employee.SSN and Var_Patient_Num < Fixed_Patient_Num  and Employee.Department_NUM='" + num + "';"; 
            return dbMan.ExecuteReader(query);
        }
        public int Insert_Examine(int DSSN, int PSSN, string date, int price, int pnum)
        {
            string query = "INSERT INTO Examine (Doctor_SSN,Patient_SSN,Examine_Date,Examine_Price,Patient_Num )" +
                            "Values ('" + DSSN + "','" + PSSN + "','" + date + "','" + price + "','" + pnum + "');";

            return dbMan.ExecuteNonQuery(query);
        }
        ////////public int Insert_Examine(int DSSN, int PSSN, string date, int price)//to try
        ////////{
        ////////    string query = "INSERT INTO Examine (Doctor_SSN,Patient_SSN,Examine_Date,Examine_Price )" +
        ////////                    "Values ('" + DSSN + "','" + PSSN + "','" + date + "','" + price + "');";

        ////////    return dbMan.ExecuteNonQuery(query);
        ////////}


        public int Update_var_patient_number(int DSSN, string date)
        {
            string query = "UPDATE Doctor " +
                            "SET Var_Patient_Num=Var_Patient_Num+1 where Doctor_SSN='" + DSSN + "'and Doctor_Date='" +date + "';" ; 
            return dbMan.ExecuteNonQuery(query);
        }
        public int Update_var_patient_number_dec(int DSSN, string date)
        {
            string query = "UPDATE Doctor " +
                            "SET Var_Patient_Num=Var_Patient_Num-1 where Doctor_SSN='" + DSSN + "'and Doctor_Date='" + date + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int get_var_patient_number(int DSSN, string date)
        {
            string query = "SELECT Var_Patient_Num FROM Doctor where Doctor_SSN='" + DSSN + "'and Doctor_Date='" + date + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int get_fixed_patient_number(int DSSN, string date)
        {
            string query = "SELECT Fixed_Patient_Num FROM Doctor where Doctor_SSN='" + DSSN + "'and Doctor_Date='" + date + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public float get_starthour(int DSSN, string date)
        {
            string query = "SELECT Start_Hour FROM Doctor where Doctor_SSN='" + DSSN + "'and Doctor_Date='" + date + "';";
            return (float)dbMan.ExecuteScalar(query);
        }
        public float get_endhour(int DSSN, string date)
        {
            string query = "SELECT End_Hour FROM Doctor where Doctor_SSN='" + DSSN + "'and Doctor_Date='" + date + "';";
            return (float)dbMan.ExecuteScalar(query);
        }
        public DataTable Select_recep_names()
        {
            string query = "SELECT Fname,Minit,Lname,SSN FROM Employee where Employee_Type = 'Receptionist' ;";
            return dbMan.ExecuteReader(query);
        }
        public int count_examine(int dssn, string date, int pssn)
        {
            string query = "SELECT count(Patient_SSN) FROM Examine where Doctor_SSN='" + dssn + "' AND Examine_Date='" + date + "' AND Patient_SSN='" + pssn + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int insert_doc(int ssn,string day,string date, int s,int end , int f,int var)
        {
            string query = "INSERT INTO Doctor (Doctor_SSN,Doctor_Day,Doctor_Date,Start_Hour,End_Hour,Fixed_Patient_Num,Var_Patient_Num )" +
                            "Values ('" + ssn + "','" + day + "','" + date + "','" + s + "','"+ end + "','"+ f + "','" + var + "');";

            return dbMan.ExecuteNonQuery(query);
        }

        
        public int Update_doc_starthour(int ssn, string date, float shour)
        {
            string query = "update Doctor set Start_Hour='" + shour + "'  where Doctor_SSN='" + ssn + "' and Doctor_Date='"+ date + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Update_doc_end(int ssn, string date, float shour)
        {
            string query = "update Doctor set End_Hour='" + shour + "'  where Doctor_SSN='" + ssn + "' and Doctor_Date='" + date + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Update_doc_fixed(int ssn, string date, int fix)
        {
            string query = "update Doctor set Fixed_Patient_Num ='" + fix + "'  where Doctor_SSN='" + ssn + "' and Doctor_Date='" + date + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int delete_doc_appointment(int ssn,string date)
        {
            string query = "DELETE FROM Doctor where Doctor_SSN='" + ssn + "' and Doctor_Date='" + date + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int delete_examine(int ssn, string date, int pssn)
        {
            string query = "DELETE FROM Examine where Doctor_SSN='" + ssn + "'and Examine_Date='" + date +"' and Patient_SSN='"+pssn+"';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int update_page(int ssn, int age)
        {
            string query = "UPDATE Patient set Patient_Age='" + age + "' where Patient_SSN='" + ssn + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int update_paddress(int ssn, string address)
        {
            string query = "UPDATE Patient set Patient_Address='" + address + "' where Patient_SSN='" + ssn + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable Select_patients_schedule(int pssn, string date)//updated date
        {
            string query = "SELECT Patient_SSN,Doctor.Doctor_SSN,Fname,Minit,Lname,Doctor_Day, Doctor_Date, Start_Hour, End_Hour,Examine_Price,Patient_Num from Employee, Doctor,Examine where Doctor.Doctor_SSN= Employee.SSN and Doctor.Doctor_SSN=Examine.Doctor_SSN and Doctor_Date=Examine_Date and Patient_SSN='" + pssn + "'and Doctor_Date >='" + date + "' ;";
            return dbMan.ExecuteReader(query);
        }
        //_________________doctor________________________
        public DataTable Select_doctor_names()//not used
        {
            string query = "SELECT Fname,Minit,Lname,SSN FROM Employee where Employee_Type = 'Doctor' ;";
            return dbMan.ExecuteReader(query);
        }
        //public DataTable Select_Doctors_schedule(string uname)
        //{
        //    string query = "SELECT Doctor.Doctor_SSN,Fname,Minit,Lname,Doctor_Day, Doctor_Date, Start_Hour, End_Hour,Fixed_Patient_Num,Var_Patient_Num from Employee, Doctor,User_Account where Doctor.Doctor_SSN= Employee.SSN and Doctor.Doctor_SSN= User_SSN and UserName='" + uname + "';";
        //    return dbMan.ExecuteReader(query);
        //}
        public DataTable Select_Doctors_schedule(string uname,string date)//updated date
        {
            string query = "SELECT Doctor.Doctor_SSN,Fname,Minit,Lname,Doctor_Day, Doctor_Date, Start_Hour, End_Hour,Fixed_Patient_Num,Var_Patient_Num from Employee, Doctor,User_Account where Doctor.Doctor_SSN= Employee.SSN and Doctor.Doctor_SSN= User_SSN and UserName='" + uname + "'and Doctor_Date >='"+ date + "' ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Select_medicines()
        {
            string query = "SELECT Medicine_Name,Medicine_Id FROM Medicine;";
            return dbMan.ExecuteReader(query);
        }
        public int Insert_presc(int prid,string diag)
        {
            string query = "INSERT INTO Prescription (Prescription_Id,Diagnose )" +
                            "Values ('" + prid + "','" + diag + "');";

            return dbMan.ExecuteNonQuery(query);
        }
        public int count_presc_id(int prid)
        {
            string query = "SELECT count(Prescription_Id) FROM Prescription where Prescription_Id='" + prid + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int Insert_write_presc(int ssn, string date,int pssn,int prid )
        {
            string query = "INSERT INTO Write_prescription (Doctor_SSN,Doctor_Date,Patient_SSN,Prescription_Id)" +
                             "Values ('" + ssn + "','" +  date + "','" + pssn + "','" + prid + "');";

            return dbMan.ExecuteNonQuery(query);
        }
        public int get_ssn_of_username(string uname)
        {
            string query = "SELECT User_SSN FROM User_Account where UserName='" + uname + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int count_doctor_date(int ssn ,string date)
        {
            string query = "SELECT count(Doctor_Date) FROM Doctor where Doctor_SSN='" + ssn + "' AND Doctor_Date='" + date+ "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int Insert_pre_med(int prid, int medid, int dos)
        {
            string query = "INSERT INTO Pre_med (Prescription_Id,Medicine_Id,Medicine_Dosage)" +
                             "Values ('" + prid + "','" + medid + "','" + dos + "');";

            return dbMan.ExecuteNonQuery(query);
        }
        public int count_med_pre(int med, int pre)
        {
            string query = "SELECT count(Medicine_Id) FROM Pre_med where Medicine_Id='" + med + "' AND Prescription_Id='" + pre + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int Insert_desc_labtest(int dssn,string date, int pssn, int tid)
        {
            string query = "INSERT INTO Descripe_labtest (Doctor_SSN,Test_Date,Patient_SSN,Test_Id)" +
                             "Values ('" + dssn + "','" + date + "','" + pssn + "','" + tid + "');";

            return dbMan.ExecuteNonQuery(query);
        }
        public int count_desc_labtest(int dssn, string date, int pssn, int tid)
        {
            string query = "SELECT count(Test_Id) FROM Descripe_labtest where Test_Id='" + tid + "' AND Doctor_SSN='" + dssn + "' AND Test_Date='" + date + "' AND Patient_SSN='" + pssn + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable Select_Patient_presc(int ssn)
        {
            string query = "SELECT * from Write_prescription,Pre_med where Pre_med.Prescription_Id=Write_prescription.Prescription_Id and Patient_SSN='" + ssn + "';";
            return dbMan.ExecuteReader(query);
        }
        //public DataTable Select_Patient_presc(int ssn, string date)//updated
        //{
        //    string query = "SELECT * from Write_prescription,Pre_med where Pre_med.Prescription_Id=Write_prescription.Prescription_Id and Patient_SSN='" + ssn + "';";
        //    return dbMan.ExecuteReader(query);
        //}
        public DataTable Select_Patient_tests(int ssn)
        {
            string query = "SELECT * from Descripe_labtest where Patient_SSN='" + ssn + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Select_Patient_record(int ssn)
        {
            string query = "SELECT * from medical_report where Patient_SSN='" + ssn + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Select_Patient_tests_to_use(int ssn)
        {
            string query = "SELECT Doctor_SSN,Fname,Minit,Lname,Patient_SSN,Lab_test.Test_Id,Test_Name,Test_Date from Descripe_labtest,Lab_test,Employee where Descripe_labtest.Test_Id=Lab_test.Test_Id and SSN=Doctor_SSN and Patient_SSN='" + ssn + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Select_Patient_presc_to_use(int ssn)
        {
            string query = "SELECT Doctor_SSN,Fname,Minit,Lname,Patient_SSN,Doctor_Date,Prescription.Prescription_Id,Diagnose,Medicine.Medicine_Id,Medicine_Name,Medicine_Dosage from Write_prescription,Pre_med,Prescription,Employee,Medicine where Medicine.Medicine_Id=Pre_med.Medicine_Id and Write_prescription.Prescription_Id=Prescription.Prescription_Id and Pre_med.Prescription_Id=Write_prescription.Prescription_Id and SSN=Doctor_SSN and Patient_SSN='" + ssn + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Select_Patient_presc_to_use_pharmacist(int ssn)
        {
            string query = "SELECT Doctor_SSN,Fname,Minit,Lname,Patient_SSN,Doctor_Date,Prescription.Prescription_Id,Medicine.Medicine_Id,Medicine_Name,Medicine_Dosage from Write_prescription,Pre_med,Prescription,Employee,Medicine where Medicine.Medicine_Id=Pre_med.Medicine_Id and Write_prescription.Prescription_Id=Prescription.Prescription_Id and Pre_med.Prescription_Id=Write_prescription.Prescription_Id and SSN=Doctor_SSN and Patient_SSN='" + ssn + "';";
            return dbMan.ExecuteReader(query);
        }

        //____________________________________________________________________________________________________
        ////////////////////////////////////////////samaa:pharmacist////////////////////////////////
        ///lw el mdeice aslan alreadu mwgod
        public int Insert_Medicine(string Medicine_Id, string Medicine_Name, string Medicine_Price, string Medicine_Quantity)
        {
            string query = "INSERT INTO Medicine " +
                            "Values ('" + Medicine_Id + "','" + Medicine_Name + "','" + Medicine_Price + "','" + Medicine_Quantity + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int check_Medicine_Name_existance(string Med_name)//we assume that user names are unique
        {
            string query = "select COUNT(*) from Medicine where Medicine_Name ='" + Med_name + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int check_Medicine_id_existance(string Med_id)//we assume that user names are unique
        {
            string query = "select COUNT(*) from Medicine where Medicine_Id ='" + Med_id + "';";
            return (int)dbMan.ExecuteScalar(query);

        }
        public DataTable Select_Med_info(string med_id)
        {
            string query = "SELECT Medicine_Price,Medicine_Quantity from Medicine where Medicine_Id='" + med_id + "';";
            return dbMan.ExecuteReader(query);
        }
        public int delete_Medicine(string med_id)
        {
            string query = "DELETE FROM Medicine where Medicine_Id='" + med_id + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Update_med_quantity(string med_quant, string med_id)
        {
            string query = "update Medicine set Medicine_Quantity='" + med_quant + "'  where Medicine_Id='" + med_id + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Update_med_price(string med_price, string med_id)
        {
            string query = "update Medicine set Medicine_Price='" + med_price + "'  where Medicine_Id='" + med_id + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        ///assign medicine to a patient
        public int assign_P_Med(string Medicine_Id, string patient_ssn, string Date)
        {
            string query = "INSERT INTO assign_medicine " +
            "Values ('" + Medicine_Id + "','" + patient_ssn + "','" + Date + "');";

            return dbMan.ExecuteNonQuery(query);
        }
    }
}



