using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.All_User_Control
{
    public partial class Uc_Employee : UserControl
    {
        function fn = new function();
        String query;
        public Uc_Employee()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void Uc_Employee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if  ( txtName.Text !="" && txtMobile.Text != "" && txtGender.Text !="" && txtEmail.Text !="" && txtUserName.Text != ""&& txtPassWord.Text !="")
            {
                String name =txtName.Text;
                Int64 mobile =Int64.Parse(txtMobile.Text);
                String gender =txtGender.Text;
                String email =txtEmail.Text;
                String username =txtUserName.Text;
                String pass =txtPassWord.Text;
                query = "INSERT INTO employee (ename,mobile,gender,emailid,username,pass) VALUES ('"+name+"','"+mobile+"','"+gender+"','"+email+"','"+username+"','"+pass+"') ";
                fn.setData(query,"Employee Registered.");
                clearAll();
                getMaxID();
            }
            else
            {
                MessageBox.Show("Fill all Fields.", "Warning.....", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmployee.SelectedIndex == 1)
            {
                //show data from employee register into employee detail then register employee 
                setEmployee(guna2DataGridView2);
            }
            else if(tabEmployee.SelectedIndex==2)
            {
                setEmployee(guna2DataGridView1);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where eid = "+txtID.Text+" ";
                    fn.setData(query,"Records Deleted.");
                    tabEmployee_SelectedIndexChanged(this,null);
                }
            }
        }
        private void Uc_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
        //========================Required Method==================
        public void getMaxID()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSET.Text = (num + 1).ToString();
            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtUserName.Clear();
            txtPassWord.Clear();
        }
        public void setEmployee(DataGridView dvg)
        {
            query = "select * from employee";
            DataSet ds = fn.getData(query);
            dvg.DataSource = ds.Tables[0];
        }
    }
}
